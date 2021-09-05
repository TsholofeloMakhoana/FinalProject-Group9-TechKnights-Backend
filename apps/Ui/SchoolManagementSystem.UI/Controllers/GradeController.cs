using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Net;


namespace SchoolManagementSystem.UI.Controllers
{
    [Authorize]
    public class GradeController : Controller
    {

        #region ctr
        private readonly IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        #endregion



        public ActionResult Index()
        {
            List<GradeViewModel> list = new List<GradeViewModel>();
            try
            {
                list = _gradeService.ListAllGrades();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(list);
        }

        // GET: GradeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GradeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GradeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GradeViewModel model)
        {
            if (model != null)
            {
                var sSave = _gradeService.CreateGrade(model);
                if (sSave != null)
                {
                    if (sSave == HttpStatusCode.OK.ToString())
                    {
                        ViewBag.SuccessMessage = "Grade successfully added ";                     
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

        // GET: GradeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GradeController/Edit/5
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

        // GET: GradeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GradeController/Delete/5
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
