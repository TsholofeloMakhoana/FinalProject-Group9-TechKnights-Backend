using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.UI.Areas.StudentAdmin.Controllers
{
    [Area("StudentAdmin")]
    [Authorize]
    public class StudentController : Controller
    {

        #region ctr
        private readonly IEmailAuditService _emailAuditService;
        private readonly IStudentService _studentService;
        private readonly IInvoiceService _invoiceService;
        public readonly IGradeService _gradeService;
        private readonly IParentService _parentService;
        public StudentController(IEmailAuditService emailAuditService,
            IStudentService studentService, IInvoiceService invoiceService)
        {
            _studentService = studentService;
            _emailAuditService = emailAuditService;
            _invoiceService = invoiceService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentInformation()
        {
            var sqlGet = _studentService.GetStudentByEmailAddress(this.User.Identity.Name);
            if (sqlGet != null)
            {
                ViewBag.EmailCount = _emailAuditService.GetEmails(this.User.Identity.Name, Roles.Student.ToString()).Count();
                ViewBag.Emails = _emailAuditService.GetEmails(this.User.Identity.Name, Roles.Student.ToString());
               
                return View(sqlGet);
            }
            return Redirect("/StudentAdmin/Student/Index");
        }

        public IActionResult Assignment()
        {
            return View();
        }

        public IActionResult Exam()
        {
            return View();
        }

        public IActionResult Finance()
        {
            var getstudentId = _studentService.GetStudentByEmailAddress(this.User.Identity.Name);
           
            ViewBag.Finance = _invoiceService.GetInvoiceById(getstudentId.StudentId);
            return View(getstudentId);
        }

        public IActionResult StudentMessage()
        {
            List<EmailAuditDataViewModel> list = new List<EmailAuditDataViewModel>();
            try
            {
                list = _emailAuditService.GetEmails(this.User.Identity.Name, Roles.Student.ToString());
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
