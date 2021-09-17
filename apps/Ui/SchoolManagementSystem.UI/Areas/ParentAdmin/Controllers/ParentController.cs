using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace SchoolManagementSystem.UI.Areas.ParentAdmin.Controllers
{
    [Area("ParentAdmin")]
    [Authorize]
    public class ParentController : Controller
    {
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
            return View();
        }
    }
}
