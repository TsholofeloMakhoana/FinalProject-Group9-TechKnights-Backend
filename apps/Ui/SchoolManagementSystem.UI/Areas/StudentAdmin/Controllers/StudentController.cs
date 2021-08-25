using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.UI.Areas.StudentAdmin.Controllers
{
    [Area("StudentAdmin")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentInformation()
        {
            return View();
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
            return View();
        }

        public IActionResult StudentMessage()
        {
            return View();
        }
    }
}
