using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Notification;
using SchoolManagementSystem.Shared;

namespace SchoolManagementSystem.UI.Areas.Identity.Pages.Account
{
    [Authorize(Roles= "SystemAdmin")]
    public class RegisterModel : PageModel
    {

        #region ctr
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailAuditService _emailAuditService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IParentService _parentService;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IParentService parentService,
            IStudentService studentService,
            IEmailAuditService emailAuditService,
             ITeacherService teacherService)
        {
            _userManager = userManager;           
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            _parentService = parentService;
            _studentService = studentService;
            _teacherService = teacherService;
            _emailAuditService = emailAuditService;
        }
        #endregion

  

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            public string Role { get; set; }
            public int UserId { get; set; }
            public int GradeId { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (this.User.IsInRole(Roles.SystemAdmin.ToString()))
            {
                try
                {
                    var role = string.Empty;
                    if (id == null)
                    {
                        role = Roles.SystemAdmin.ToString();
                        TempData["RoleName"] = role;
                        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                        return Page();
                    }
                    role = TempData["Role"].ToString();                
                    if (role != null)
                    {
                        
                        if (role == Roles.Parent.ToString())
                        {
                            var parent = _parentService.GetParent(int.Parse(id));
                            if (parent != null)
                            {
                                var passWord = parent.Firstname;
                                TempData["Emails"] = parent.PersonalEmailAddress;
                                TempData["Password"] = passWord + parent.ParentId + "**P";
                                TempData["RoleName"] = Roles.Parent.ToString();
                                TempData["Fnames"] = parent.Firstname + " " + parent.Surname;
                                TempData["UserId"] = parent.ParentId;
                            }
                        }

                        if (role == Roles.Student.ToString())
                        {
                            var student = _studentService.GetStudentById(int.Parse(id));
                            if (student != null)
                            {
                                var passWord = student.Firstname;
                                TempData["Emails"] = student.PersonalEmailAddress;
                                TempData["Password"] = passWord + student.StudentId + "$$S";
                                TempData["RoleName"] = Roles.Student.ToString();
                                TempData["Fnames"] = student.Firstname + " " + student.Surname;
                                TempData["UserId"] = student.StudentId;                                                         
                            }
                        }
                        if (role == Roles.Teacher.ToString())
                        {
                            var teacher = _teacherService.GetTeachers(int.Parse(id));
                            if (teacher != null)
                            {
                                var passWord = teacher.Firstname;
                                TempData["Emails"] = teacher.PersonalEmailAddress;
                                TempData["Password"] = passWord + teacher.TeacherId + "@@T";
                                TempData["RoleName"] = Roles.Teacher.ToString();
                                TempData["Fnames"] = teacher.Firstname + " " + teacher.Surname;
                                TempData["UserId"] = teacher.TeacherId;
                            }
                        }
                        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                        return Page();
                    }
                }
                catch 
                {
                    ViewData["RoleName"] = Roles.SystemAdmin.ToString();                  
                    return Page();
                }
            }
            return RedirectToPage("/Home/Index");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var sRole = Input.Role;                   
                    await _userManager.AddToRoleAsync(user, sRole.ToString());
                   
                    if(sRole == Roles.Student.ToString())
                        _studentService.UpdateUserId(Input.UserId, user.Id);
                    if (sRole == Roles.Parent.ToString())
                        _parentService.UpdateParentUserId(Input.UserId, user.Id);
                    if(sRole == Roles.Teacher.ToString())
                        _teacherService.UpdateTeacherUserId(Input.UserId, user.Id);

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);
                    string yourNewLoginDetails = "You login details Username: <b>" + Input.Email + "</b> and Password: <b>" + Input.Password +" </b>";
                    SystemNotificationHelper.ConfirmRegistration(Input.Email, Input.Email, $" <br/><br/>Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.", yourNewLoginDetails);
                    _emailAuditService.SendEmail(Input.UserId, "Login Details", Input.Email, Roles.SystemAdmin.ToString() + "Email", "Please check your mail  & confirm your account. " + yourNewLoginDetails,  " Dear " + Input.Email, Input.Role);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
