using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SchoolManagementSystem.UI.Controllers
{

    [Authorize]
    public class ParentController : Controller
    {
        #region ctr
        private readonly IParentService _parentService;
        private readonly IEmailAuditService _emailAuditService;
        public ParentController(IParentService parentService, 
            IEmailAuditService emailAuditService)
        {
            _emailAuditService = emailAuditService;
            _parentService = parentService;
        }
        #endregion

    
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Details(int id)
        {
            if (id > 0)
            {
                var sqlGet = _parentService.GetParent(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Parent/List");
        }

        #region Create Parent
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(ParentViewModel model)
        {
            if (model is not null)
            {
                model.CreatedBy = "SystemAdmin";
                model.IsActive = true;

                var isIdExist = _parentService.IsParentExist(model.IdOrPassport);
                if (isIdExist != HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessag = isIdExist;
                    return View();
                }
                var isEmailExist = _parentService.IsEmailExist(model.PersonalEmailAddress);
                if (isIdExist != HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessag = isEmailExist;
                    return View();
                }
                var modelValidation = GenericLogic.ValidateParentString(model);
                if (modelValidation == HttpStatusCode.OK.ToString())
                {
                    var create = _parentService.CreateParent(model);
                    if (create != null)
                    {
                        if (int.Parse(create) > 0)
                        {
                            var message = "New parent has been added successfully. Please give parent access to the system.";
                            TempData["ValidationMessage"] = message;                
                            TempData["Role"] = Roles.Parent.ToString();
                            _emailAuditService.SendEmail(int.Parse(create), "New Parent", model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", message, model.Title + " " + model.Firstname + " " + model.Surname, Roles.Parent.ToString());

                            return Redirect("/Identity/Account/Register?id=" + int.Parse(create));
                        }
                        ViewBag.ValidationMessage = create;
                        return View();
                    }
                }
                ViewBag.ValidationMessage = modelValidation;
                return View();
            }
            ViewBag.ValidationMessage = "Something went wrong. Please try again";
            return View();
        }
        #endregion

        // GET: ParentController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                var sqlGet = _parentService.GetParent(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Parent/List");
        }

        // POST: ParentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ParentViewModel model)
        {
            if (model != null && model.ParentId > 0)
            {
                var update = _parentService.UpdateParentDetails(model);
                if (update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Parent details updated successfully";
                    return Redirect("/Parent/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
        }

        // GET: ParentController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var sqlGet = _parentService.GetParent(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Parent/List");
        }

        // POST: ParentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, bool isactive=true)
        {
            if (id > 0)
            {
                var update = _parentService.DeleteParent(id);
                if (update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Parent deteled successfully";
                    return Redirect("/Parent/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
        }

        public ActionResult List()
        {
            List<ParentViewModel> list = new List<ParentViewModel>();
            try
            {
                list = _parentService.GetAllParents();
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }

        public ActionResult AssignParent()
        {
            List<ParentViewModel> list = new List<ParentViewModel>();
            try
            {
                TempData["Role"] = Roles.Parent.ToString();
                list = _parentService.GetAllParents();
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
