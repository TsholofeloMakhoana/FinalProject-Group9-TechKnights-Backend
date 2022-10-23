using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.UI.Models;
using System.Diagnostics;


namespace SchoolManagementSystem.UI.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IParentService _parentService;
        private readonly ITeacherService _teacherService;
        public HomeController(IStudentService studentService,
            IParentService parentService, ITeacherService teacherService)
        {
            _studentService = studentService;
            _parentService = parentService;
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            if (this.User.IsInRole(Roles.Student.ToString()))
            {
                return Redirect("/StudentAdmin/Student/Index");
            }
            if (this.User.IsInRole(Roles.Parent.ToString()))
            {
                return Redirect("/ParentAdmin/Parent/Index");
            }
            if (this.User.IsInRole(Roles.Teacher.ToString()))
            {
                return Redirect("/TeacherAdmin/Teacher/Index");
            }
            if (this.User.IsInRole(Roles.SystemAdmin.ToString()))
            {
                ViewBag.StudentCount = _studentService.StudentCount();
                ViewBag.TeacherCount = _teacherService.TeacherCount();
                ViewBag.ParentCount = _parentService.ParentCount();
                return View();
            }
            return Redirect("/identity/account/login");
        }
    }
}
