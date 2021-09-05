using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ParentController(IParentService parentService)
        {
            _parentService = parentService;
        }
        #endregion
        public ActionResult Index()
        {
            return View();
        }

        // GET: ParentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                var create = _parentService.CreateParent(model);
                if (create != null)
                {
                    if (create == HttpStatusCode.OK.ToString())
                    {
                        ViewBag.ValidationMessage = "New Parent has been added successfully.";
                        return View();
                    }
                    ViewBag.ValidationMessage = create;
                }               
            }
            return View();
        }
        #endregion

        // GET: ParentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List()
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
