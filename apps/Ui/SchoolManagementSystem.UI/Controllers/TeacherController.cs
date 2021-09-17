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
    public class TeacherController : Controller
    {
        #region ctr
        private readonly ITeacherService _teacherService;
        private readonly IEmailAuditService _emailAuditService;
        public TeacherController(ITeacherService teacherService,
            IEmailAuditService emailAuditService)
        {
            _teacherService = teacherService;
            _emailAuditService = emailAuditService;
        }
        #endregion
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            if (id > 0)
            {
                var sqlGet = _teacherService.GetTeachers(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Teacher/List");
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherViewModel model)
        {
            if (model is not null)
            {
                model.CreatedBy = Roles.SystemAdmin.ToString();
                model.IsActive = true;
                var isIdExist = _teacherService.IsTeacherExist(model.IdOrPassport);
                if (isIdExist != HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = isIdExist;
                    return View();
                }
                var isEmailExist = _teacherService.IsEmailExist(model.PersonalEmailAddress);
                if (isIdExist != HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = isEmailExist;
                    return View();
                }
                var modelValidation = GenericLogic.ValidateTeacherString(model);
                if (modelValidation == HttpStatusCode.OK.ToString())
                {
                    var create = _teacherService.CreateTeacher(model);
                    if (create != null)
                    {
                        if (int.Parse(create) > 0)
                        {
                            var message = "New teacher has been added successfully. Please give teacher access to the system.";
                            TempData["ValidationMessage"] = message;
                            TempData["Role"] = Roles.Teacher.ToString();
                            _emailAuditService.SendEmail(int.Parse(create), "New Teacher", model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", message, model.Title + " " + model.Firstname + " " + model.Surname, Roles.Teacher.ToString());

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

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                var sqlGet = _teacherService.GetTeachers(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Teacher/List");
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TeacherViewModel model)
        {
            if (model != null && model.TeacherId > 0)
            {
                var update = _teacherService.UpdateTeacherDetails(model);
                if (update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Teacher details updated successfully";
                    return Redirect("/Teacher/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
        }

        // GET: TeacherController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var sqlGet = _teacherService.GetTeachers(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Teacher/List");
        }

        // POST: TeacherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, bool isactive=true)
        {
            if (id > 0)
            {
                var update = _teacherService.DeleteTeacher(id);
                if (update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Teacher deteled successfully";
                    return Redirect("/Teacher/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
        }


        public ActionResult List()
        {
            List<TeacherViewModel> list = new List<TeacherViewModel>();
            try
            {
                list = _teacherService.GetTeachers();
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
        public ActionResult AssignTeacher()
        {
            List<TeacherViewModel> list = new List<TeacherViewModel>();
            try
            {
                TempData["Role"] = Roles.Teacher.ToString();
                list = _teacherService.GetTeachers();
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
