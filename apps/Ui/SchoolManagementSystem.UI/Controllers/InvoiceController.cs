using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace SchoolManagementSystem.UI.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IStudentService studentService,
            IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
            _studentService = studentService;
        }
        public IActionResult Index()
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
        [HttpGet]
        public IActionResult CreateInvoice(int id)
        {
            try
            {
                if (id > 0)
                {
                    ViewBag.StudentId = id;
                    ViewBag.StudentInvoiceList = _invoiceService.GetInvoiceById(id);

                    return View();
                }
            }
            catch
            {

            }
            return Redirect("/Invoice/Index");
        }

        [HttpPost]
        public IActionResult CreateInvoice(InvoiceDataViewModel model)
        {
            if (model != null)
            {
                var sSave = _invoiceService.CreateInvoice(model);
                if (sSave != null)
                {
                    if (sSave == HttpStatusCode.OK.ToString())
                    {
                        ViewBag.StudentInvoiceList = _invoiceService.GetInvoiceById(model.StudentId);
                        ViewBag.SuccessMessage = "Invoice item successfully added";
                    }
                    if (sSave.Contains(DatabaseErrors.ErrorOccured))
                    {
                        ViewBag.SuccessMessage = sSave;
                    }
                }
                else
                {
                    ViewBag.SuccessMessage = "Could not save because the grades";
                }
            }
            return View();
        }
    }
}
