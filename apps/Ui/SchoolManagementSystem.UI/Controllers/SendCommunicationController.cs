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
    public class SendCommunicationController : Controller
    {

        private readonly IStudentService _studentService;
        private readonly IParentService _parentService;
        private readonly ITeacherService _teacherService;
        private readonly IEmailAuditService _emailAuditService;
        public SendCommunicationController(IStudentService studentService,
            IParentService parentService, ITeacherService teacherService,
            IEmailAuditService emailAuditService)
        {
            _studentService = studentService;
            _parentService = parentService;
            _teacherService = teacherService;
            _emailAuditService = emailAuditService;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region ListView
        public ActionResult StudentCommunication()
        {
            List<StudentViewModel> list = new List<StudentViewModel>();
            list = _studentService.GetAllStudents();
            return View(list);
        }

        public ActionResult ParentCommunication()
        {
            List<ParentViewModel> list = new List<ParentViewModel>();
            list = _parentService.GetAllParents();
            return View(list);
        }

        public ActionResult TeacherCommunication()
        {
            List<TeacherViewModel> list = new List<TeacherViewModel>();
            list = _teacherService.GetTeachers();
            return View(list);
        }

        #endregion



        
        #region SendToParent
        [HttpGet]
        public IActionResult SendToParent(int id)
        {
            if (id > 0)
            {
                var sqlGet = _parentService.GetParent(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/SendCommunication/Index");
        }


        [HttpPost]
        public IActionResult SendToParent(ParentViewModel model)
        {
            var send = _emailAuditService.SendEmail(model.ParentId,model.EmailAudit.EmailSubject, model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", model.EmailAudit.Body, model.Title+" "+model.Firstname +" "+model.Surname, Roles.Parent.ToString());
            if(send != null)
            {
                if (send == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidateErrorMessage = "Email successfully sent to " + model.Firstname + " " + model.Surname;
                    return Redirect("/SendCommunication/ParentCommunication");
                }
                ViewBag.ValidateErrorMessage = "En error Occured, Please try again.";
                return View();
            }
            ViewBag.ValidateErrorMessage = "Please make sure all the field are caputured";
            return View();
        }
        #endregion




        #region SendToTeacher
        [HttpGet]
        public IActionResult SendToTeacher(int id)
        {
            if (id > 0)
            {
                var sqlGet = _teacherService.GetTeachers(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/SendCommunication/Index");
        }

        public IActionResult SendToTeacher(TeacherViewModel model)
        {
            var send = _emailAuditService.SendEmail(model.TeacherId, model.EmailAudit.EmailSubject, model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", model.EmailAudit.Body, model.Title + " " + model.Firstname + " " + model.Surname, Roles.Teacher.ToString());
            if (send != null)
            {
                if (send == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidateErrorMessage = "Email successfully sent to " + model.Firstname + " " + model.Surname;
                    return Redirect("/SendCommunication/TeacherCommunication");
                }
                ViewBag.ValidateErrorMessage = "En error Occured, Please try again.";
                return View();
            }
            ViewBag.ValidateErrorMessage = "Please make sure all the field are caputured";
            return View();
        }
        #endregion



        #region SendToStudent
        [HttpGet]
        public IActionResult SendToStudent(int id)
        {
            if (id > 0)
            {
                var sqlGet = _studentService.GetStudentById(id);
                if (sqlGet != null)
                {
                    return View(sqlGet);
                }
            }
            return Redirect("/SendCommunication/Index");
        }
        public IActionResult SendToStudent(StudentViewModel model)
        {
            var send = _emailAuditService.SendEmail(model.StudentId, model.EmailAudit.EmailSubject, model.PersonalEmailAddress, Roles.SystemAdmin.ToString() + "Email", model.EmailAudit.Body, model.Title + " " + model.Firstname + " " + model.Surname, Roles.Student.ToString());
            if (send != null)
            {
                if (send == HttpStatusCode.OK.ToString())
                {
                    ViewBag.ValidateErrorMessage = "Email successfully sent to " + model.Firstname + " " + model.Surname;
                    return Redirect("/SendCommunication/StudentCommunication");
                }
                ViewBag.ValidateErrorMessage = "En error Occured, Please try again.";
                return View();
            }
            ViewBag.ValidateErrorMessage = "Please make sure all the field are caputured";
            return View();
        }
        #endregion
    }
}
