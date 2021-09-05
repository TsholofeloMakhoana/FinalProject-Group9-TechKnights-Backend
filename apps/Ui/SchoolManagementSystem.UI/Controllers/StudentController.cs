﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace SchoolManagementSystem.UI.Controllers
{

    [Authorize]
    public class StudentController : Controller
    {


        #region ctr
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        #region Create Student
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel model)
        {
            if (model is not null)
            {
                model.ApplicationStatus = Status.InProcess.ToString();
                model.StudentNumber = "45909350";
                // model.genericViewModel.DateCreated = DateTime.Now;
                model.CreatedBy = "SystemAdmin";
                // model.genericViewModel.DateOfBirth = DateTime.Now;

                var create = _studentService.CreateStudent(model);
                if (create != null)
                {
                    if (create == HttpStatusCode.OK.ToString())
                    {
                        ViewBag.ValidationMessage = "New student has been added successfully.";
                        return View();
                    }
                    ViewBag.ValidationMessage = create;
                }
            }
            return View();
        }
        #endregion

        public ActionResult Edit(int id)
        {
            return View();
        }

    
        [HttpPost,ValidateAntiForgeryToken]
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
            List<StudentViewModel> list = new List<StudentViewModel>();
            try
            {
                list = _studentService.GetAllStudents();
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
