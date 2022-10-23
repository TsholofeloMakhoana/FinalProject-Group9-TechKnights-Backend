#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d97bf32d096b34c8af6829ae144abd30e463f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StudentAdmin_Views_Student_Finance), @"mvc.1.0.view", @"/Areas/StudentAdmin/Views/Student/Finance.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73d97bf32d096b34c8af6829ae144abd30e463f2", @"/Areas/StudentAdmin/Views/Student/Finance.cshtml")]
    public class Areas_StudentAdmin_Views_Student_Finance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Shared.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
  
    ViewData["Title"] = "MyFinance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/StudentAdmin/Student/Index""> Student </a>/ My Finance
        </div>
    </div>
</section>

<!-- start: INVOICE -->
<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""invoice"">
                <div class=""row invoice-logo"">
                    <div class=""col-sm-6"">
                        <img");
            BeginWriteAttribute("alt", " alt=\"", 683, "\"", 689, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"assets/images/your-logo-here.png\">\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <p class=\"text-dark\">\r\n                            ");
#nullable restore
#line 26 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                       Write(Html.DisplayFor(m => m.StudentNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 26 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                                Write(Html.DisplayFor(m => m.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"text-light\"> ");
#nullable restore
#line 26 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                                                                                                Write(Html.DisplayFor(m => m.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                                                                                                                                   Write(Html.DisplayFor(m => m.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </small>
                        </p>
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <h4>Client:</h4>
                        <div class=""well"">
                            <address>
                                <strong class=""text-dark"">Student Address.</strong>
                                <br>
                                ");
#nullable restore
#line 38 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                           Write(Html.DisplayFor(m => m.PhysicalAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br>\r\n                                ");
#nullable restore
#line 40 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                           Write(Html.DisplayFor(m => m.PhysicalProvince));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 40 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                                      Write(Html.DisplayFor(m => m.PostalAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br>\r\n                                <abbr title=\"Phone\">P:</abbr> ");
#nullable restore
#line 42 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                         Write(Html.DisplayFor(m => m.CelPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </address>\r\n                            <address>\r\n                                <strong class=\"text-dark\">E-mail:</strong>\r\n                                <a href=\"mailto:#\">\r\n                                    ");
#nullable restore
#line 47 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                               Write(Html.DisplayFor(m => m.PersonalEmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </a>
                            </address>
                        </div>
                    </div>
                    <div class=""col-sm-4"">
                        <h4>We appreciate your business.</h4>
                        <div class=""padding-bottom-30 padding-top-10 text-dark"">
                            Thanks for being a student.
                            A detailed summary of your invoice is below.
                            <br>
                            If you have questions, we're happy to help.
                            <br>
                            Email Ovasia@gmail.com or contact us through other support channels.
                        </div>
                    </div>
                    <div class=""col-sm-4 pull-right"">
                        <h4>Payment Details:</h4>
                        <ul class=""list-unstyled invoice-details padding-bottom-30 padding-top-10 text-dark"">
                            <li>
              ");
            WriteLiteral(@"                  <strong>V.A.T Reg #:</strong> 233243444
                            </li>
                            <li>
                                <strong>Account Name:</strong> Ovasia Ltd
                            </li>
                            <li>
                                <strong>SWIFT code:</strong> 1233F4343ABCDEW
                            </li>
                            <li>
                                <strong>DATE:</strong> 10/10/2021
                            </li>
                            <li>
                                <strong>DUE:</strong> 11/10/2021
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th> # </th>
                   ");
            WriteLiteral(@"                 <th> title </th>
                                    <th class=""hidden-480""> Description </th>
                                    <th class=""hidden-480""> Amount </th>
                                    <th class=""hidden-480""> AmountPaid </th>
                                    <th class=""hidden-480""> DueAmount </th>
                                    <th> Status </th>
                                    <th> PaymentMethod </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 100 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                 foreach (var item in ViewBag.Finance)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td> ");
#nullable restore
#line 103 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                        Write(item.InvoiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 104 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td class=\"hidden-480\"> ");
#nullable restore
#line 105 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td class=\"hidden-480\"> $");
#nullable restore
#line 106 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                            Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td class=\"hidden-480\"> $");
#nullable restore
#line 107 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                            Write(item.AmountPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td class=\"hidden-480\"> $");
#nullable restore
#line 108 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                                            Write(item.Due);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 109 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 110 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                       Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 112 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\StudentAdmin\Views\Student\Finance.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-12 invoice-block"">
                        <ul class=""list-unstyled amounts text-small"">
                            <li>
                                <strong>Sub-Total:</strong> $12,876
                            </li>
                            <li>
                                <strong>Discount:</strong> 9.9%
                            </li>
                            <li>
                                <strong>VAT:</strong> 22%
                            </li>
                            <li class=""text-extra-large text-dark margin-top-15"">
                                <strong>Total:</strong> $11,400
                            </li>
                        </ul>
                        <br>
                        <a onclick=""javascript:window.print();"" class=""btn btn-lg btn-prima");
            WriteLiteral(@"ry hidden-print"">
                            Print <i class=""fa fa-print""></i>
                        </a>
                        <a class=""btn btn-lg btn-primary btn-o hidden-print"">
                            Submit Your Invoice <i class=""fa fa-check""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end: INVOICE -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Shared.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
