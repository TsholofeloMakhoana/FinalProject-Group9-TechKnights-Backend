#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Shared\Partial\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6c75a2c6d8d6a6ed3a7b6649664e5351d59713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__Navbar), @"mvc.1.0.view", @"/Views/Shared/Partial/_Navbar.cshtml")]
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
#nullable restore
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6c75a2c6d8d6a6ed3a7b6649664e5351d59713", @"/Views/Shared/Partial/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""sidebar app-aside"" id=""sidebar"">
    <div class=""sidebar-container perfect-scrollbar"">
        <nav>
            <!-- start: SEARCH FORM -->
            <div class=""search-form"">
                <a class=""s-open"" href=""#"">
                    <i class=""ti-search""></i>
                </a>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb6c75a2c6d8d6a6ed3a7b6649664e5351d597134340", async() => {
                WriteLiteral(@"
                    <a class=""s-remove"" href=""#"" target="".navbar-form"">
                        <i class=""ti-close""></i>
                    </a>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        <button class=""btn search-button"" type=""submit"">
                            <i class=""ti-search""></i>
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- end: SEARCH FORM -->
            <!-- start: MAIN NAVIGATION MENU -->
            <div class=""navbar-title"">
                <span>Main Navigation</span>
            </div>
            <ul class=""main-navigation-menu"">
                <li class=""active open"">
                    <a href=""/Home/Index"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-home""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Dashboard </span>
                            </div>
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-settings");
            WriteLiteral(@"""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Student</span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""/Student/Index"">
                                <span class=""title""> Student Home </span>
                            </a>
                        </li>                    
                    </ul>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-layout-grid2""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Teacher </sp");
            WriteLiteral(@"an><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""/Teacher/Index"">
                                <span class=""title"">Teacher Home</span>
                            </a>
                        </li>                      
                    </ul>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-pencil-alt""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Parents </span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu");
            WriteLiteral(@""">
                        <li>
                            <a href=""/Parent/Index"">
                                <span class=""title"">Create Parent</span>
                            </a>
                        </li>                      
                    </ul>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-user""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Accademic Syllabus </span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""/Grade/Index"">
                                <span class=""title""> Add Grade(s) </span");
            WriteLiteral(@">
                            </a>
                        </li>
                        <li>
                            <a href=""/Subject/Index"">
                                <span class=""title""> Add Modules</span>
                            </a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-layers-alt""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Student Admin </span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        
                        <li>
                            <a href=""/StudentAdmin/Stude");
            WriteLiteral(@"nt/Index"">
                                <span class=""title"">Student Admin</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/StudentAdmin/Student/StudentInformation"">
                                <span class=""title"">MyInformation</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/StudentAdmin/Student/Assignment"">
                                <span class=""title"">MyAssignment</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/StudentAdmin/Student/Exam"">
                                <span class=""title"">MyExams</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/StudentAdmin/Student/Finance"">
                                <span class=""title"">");
            WriteLiteral(@"MyFinance</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/StudentAdmin/Student/StudentMessage"">
                                <span class=""title"">MyMessages</span>
                            </a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-layers-alt""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Parent Admin </span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""#"">
      ");
            WriteLiteral(@"                          <span class=""title"">Student Information</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Assignment</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Exams</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Student Finance</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Messages</span>
                            </a>
                        </li>
                    </ul>
                </li>
     ");
            WriteLiteral(@"           <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-layers-alt""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Teacher Admin </span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""#"">
                                <span class=""title"">Student Information</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Assignment</span>
                            </a>
                        </li>
                        <li>
   ");
            WriteLiteral(@"                         <a href=""#"">
                                <span class=""title"">Exams</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"""">
                                <span class=""title"">Student Finance</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title"">Messages</span>
                            </a>
                        </li>
                    </ul>
                </li>



                <li>
                    <a href=""javascript:void(0)"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <i class=""ti-settings""></i>
                            </div>
                            <div class=""item-inner"">
                                <span class=""tit");
            WriteLiteral(@"le""> Setings</span><i class=""icon-arrow""></i>
                            </div>
                        </div>
                    </a>
                    <ul class=""sub-menu"">
                        <li>
                            <a href=""#"">
                                <span class=""title""> Send Email </span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title""> System Errors </span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title""> WebAPI </span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <span class=""title""> User Machines </span>
                            </a>
                        </li>");
            WriteLiteral(@"

                        <li>
                            <a href=""#"">
                                <span class=""title""> User Activities </span>
                            </a>
                        </li>
                    </ul>
                </li>
            </ul>
            <!-- end: MAIN NAVIGATION MENU -->
            <!-- start: CORE FEATURES -->
            <div class=""navbar-title"">
                <span>Core Features</span>
            </div>
            <ul class=""folders"">

                <li>
                    <a href=""#"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <span class=""fa-stack""> <i class=""fa fa-square fa-stack-2x""></i> <i class=""fa fa-terminal fa-stack-1x fa-inverse""></i> </span>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Calendar </span>
                      ");
            WriteLiteral(@"      </div>
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <div class=""item-content"">
                            <div class=""item-media"">
                                <span class=""fa-stack""> <i class=""fa fa-square fa-stack-2x""></i> <i class=""fa fa-folder-open-o fa-stack-1x fa-inverse""></i> </span>
                            </div>
                            <div class=""item-inner"">
                                <span class=""title""> Messages </span>
                            </div>
                        </div>
                    </a>
                </li>
            </ul>
            <!-- end: CORE FEATURES -->
            <!-- start: DOCUMENTATION BUTTON -->
            <div class=""wrapper"">
                <a href=""#"" class=""button-o"">
                    <i class=""ti-help""></i>
                    <span>Documentation</span>
                </a>
            </div");
            WriteLiteral(">\r\n            <!-- end: DOCUMENTATION BUTTON -->\r\n        </nav>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
