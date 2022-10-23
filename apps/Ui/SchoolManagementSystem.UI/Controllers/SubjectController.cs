using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Domain.Services;
using System.Net;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace SchoolManagementSystem.UI.Controllers
{
    [Authorize]
    public class SubjectController : Controller
    {
        #region ctr
        private readonly IModuleService _moduleService;
        public readonly IGradeService _gradeService;
        private readonly ITeacherService _teacherService;
        public SubjectController(IModuleService moduleService,
            ITeacherService teacherService,
            IGradeService gradeService)
        {
            _moduleService = moduleService;
            _gradeService = gradeService;
            _teacherService = teacherService;
        }
        #endregion
        public ActionResult Index()
        {
            List<ModuleViewModel> list = new List<ModuleViewModel>();
            try
            {
                ViewBag.Grade = _gradeService.ListAllGrades();
                ViewBag.Teacher = _teacherService.GetTeachers();
                list = _moduleService.ListAllModule();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(list);
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
