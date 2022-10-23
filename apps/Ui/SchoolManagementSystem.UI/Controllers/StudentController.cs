using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using SchoolManagementSystem.Domain.Engine;

namespace SchoolManagementSystem.UI.Controllers
{

    [Authorize]
    public class StudentController : Controller
    {
        #region ctr
        private readonly IStudentService _studentService;
        private readonly IEmailAuditService _emailAuditService;
        public readonly IGradeService _gradeService;
        private readonly IParentService _parentService;
        public StudentController(IStudentService studentService,
            IEmailAuditService emailAuditService, 
            IParentService parentService,
            IGradeService gradeService)
        {
            _gradeService= gradeService;
            _studentService = studentService;
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
                var sqlGet = _studentService.GetStudentById(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Student/List");
        }

        #region Create Student
        public ActionResult Create()
        {           
            ViewBag.Grade = _gradeService.ListAllGrades();
            ViewBag.Parent = _parentService.GetAllParents();
            return View();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel model)
        {
            if (model is not null)
            {
                try
                {
                    model.ApplicationStatus = Status.InProcess.ToString();
                    model.StudentNumber = RandomString(10);
                    model.CreatedBy = Roles.SystemAdmin.ToString();
                    model.IsActive = true;
                    
                    var isIdExist = _studentService.IsStudentExist(model.IdOrPassport);
                    if (isIdExist != HttpStatusCode.OK.ToString())
                    {
                        ViewBag.ValidationMessag = isIdExist;
                        return View();
                    }
                    var isEmailExist = _studentService.IsEmailExist(model.PersonalEmailAddress);
                    if (isIdExist != HttpStatusCode.OK.ToString())
                    {
                        ViewBag.ValidationMessag = isEmailExist;
                        return View();
                    }

                    var modelValidation = GenericLogic.ValidateString(model);
                    if (modelValidation == HttpStatusCode.OK.ToString())
                    {
                        var create = _studentService.CreateStudent(model);
                        if (create != null)
                        {
                            if (int.Parse(create) > 0)
                            {
                                var message = "New student has been added successfully. Please give student access to the system.";
                                TempData["ValidationMessage"] = message;
                                TempData["Role"] = Roles.Student.ToString();
                                _emailAuditService.SendEmail(int.Parse(create), "New Student", model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", message, model.Title + " " + model.Firstname + " " + model.Surname, Roles.Student.ToString());

                                return Redirect("/Identity/Account/Register?id=" + int.Parse(create));
                            }
                            ViewBag.ValidationMessage = create;
                            return View();
                        }
                    }
                    ViewBag.ValidationMessage = modelValidation;
                    return View();
                }
                catch
                {
                    ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
                    return View();
                }
            }
            ViewBag.ValidationMessage = "Something went wrong. Please try again";
            return View();
        }
        #endregion


      
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                var sqlGet = _studentService.GetStudentById(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Student/List");
        }

    
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Edit(StudentViewModel model)
        {
            if(model != null && model.StudentId >0)
            {
                var update = _studentService.UpdateStudentDetails(model);
                if(update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Student details updated successfully";
                    return Redirect("/Student/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
        }

       
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var sqlGet = _studentService.GetStudentById(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/Student/List");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, bool IsActive=true)
        {
            if (id > 0)
            {
                var update = _studentService.DeleteStudent(id);
                if (update == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidationMessage = "Student deteled successfully";
                    return Redirect("/Student/List");
                }
                ViewBag.ValidationMessage = update;
                return View();
            }
            ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            return View();
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

        public IActionResult AssignStudent()
        {
            List<StudentViewModel> list = new List<StudentViewModel>();
            try
            {
                TempData["Role"] = Roles.Student.ToString();
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
