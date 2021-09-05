using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.UI.Models;
using System.Diagnostics;


namespace SchoolManagementSystem.UI.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;
        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            if (this.User.IsInRole("Student"))
            {
                return Redirect("/StudentAdmin/Student/Index");
            }
            if (this.User.IsInRole("Parent"))
            {
                return Redirect("/ParentAdmin/Parent/Index");
            }
            if (this.User.IsInRole("Teacher"))
            {
                return Redirect("/TeacherAdmin/Teacher/Index");
            }
            if (this.User.IsInRole("SystemAdmin"))
            {
                ViewBag.StudentCount = _studentService.StudentCount();
                ViewBag.TeacherCount = 0;
                ViewBag.ParentCount = 0;
                return View();
            }
            return Redirect("/identity/account/login");
        }
    }
}
