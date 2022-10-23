using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;

namespace SchoolManagementSystem.UI.Areas.TeacherAdmin.Controllers
{
    [Area("TeacherAdmin")]
    [Authorize]
    public class TeacherController : Controller
    {

        #region ctr
        private readonly IEmailAuditService _emailAuditService;       
        public TeacherController(IEmailAuditService emailAuditService)
        {          
            _emailAuditService = emailAuditService;
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeacherMessage()
        {
            List<EmailAuditDataViewModel> list = new List<EmailAuditDataViewModel>();
            try
            {
                list = _emailAuditService.GetEmails(this.User.Identity.Name, Roles.Teacher.ToString());
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
