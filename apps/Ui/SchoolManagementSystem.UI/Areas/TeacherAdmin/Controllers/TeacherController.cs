using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.UI.Areas.TeacherAdmin.Controllers
{
    [Area("ParentAdmin")]
    [Authorize]
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
    }
}
