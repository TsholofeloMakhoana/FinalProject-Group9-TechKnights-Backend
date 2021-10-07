using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Domain.Services;

namespace SchoolManagementSystem.UI.Areas.ParentAdmin.Controllers
{
    [Area("ParentAdmin")]
    [Authorize]
    public class ParentController : Controller
    {
        #region ctr
        private readonly IEmailAuditService _emailAuditService;
        private readonly IParentService _parentService;
        public ParentController(IEmailAuditService emailAuditService,
            IParentService parentService)           
        {
            _parentService = parentService;
            _emailAuditService = emailAuditService;
            
        }
        #endregion


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ParentInformation()
        {
            return View();
        }
        public IActionResult StudentAssignment()
        {
            return View();
        }
        public IActionResult StudentExam()
        {
            return View();
        }
        public IActionResult StudentFinancial()
        {
            return View();
        }
    


        public IActionResult ParentMessage()
        {
            List<EmailAuditDataViewModel> list = new List<EmailAuditDataViewModel>();
            try
            {
                list = _emailAuditService.GetEmails(this.User.Identity.Name, Roles.Parent.ToString());
            }
            catch (Exception ex)
            {
                ViewBag.ValidationMessage = DatabaseErrors.ErrorOccured;
            }
            return View(list);
        }
    }
}
