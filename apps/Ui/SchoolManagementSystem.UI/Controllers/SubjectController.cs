using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Domain.Services;
using System.Net;
using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.UI.Controllers
{
    public class SubjectController : Controller
    {
        #region ctr
        private readonly IModuleService _moduleService;
        public SubjectController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }
        #endregion
        public ActionResult Index()
        {
            List<ModuleViewModel> list = new List<ModuleViewModel>();
            try
            {
                list = _moduleService.ListAllModule();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(list);
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModuleViewModel model)
        {
            if (model != null)
            {
                var sSave = _moduleService.CreateModule(model);
                if (sSave != null)
                {
                    if (sSave == HttpStatusCode.OK.ToString())
                    {
                        ViewBag.SuccessMessage = "Module successfully added ";
                    }
                    if (sSave.Contains(DatabaseErrors.ErrorOccured))
                    {
                        ViewBag.Failed = sSave;
                    }
                }
                else
                {
                    ViewBag.Failed = "Could not save because the grades";
                }
            }
            return RedirectToAction(nameof(Index));
        }

    

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
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

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectController/Delete/5
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
    }
}
