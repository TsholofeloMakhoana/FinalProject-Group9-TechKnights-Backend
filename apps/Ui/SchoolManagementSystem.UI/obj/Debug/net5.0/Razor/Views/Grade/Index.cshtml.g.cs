#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Grade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "560f9b99c32c3a8ec8ea4014a1ddf0107ba6eb30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grade_Index), @"mvc.1.0.view", @"/Views/Grade/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"560f9b99c32c3a8ec8ea4014a1ddf0107ba6eb30", @"/Views/Grade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Grade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.UI.Models.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Grade\Index.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/Student/Index""> Index </a>/ Parent List
        </div>
    </div>
</section>

<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">     
        <div class=""col-md-12"">            
            <div class=""panel-body"">
                <button class=""btn btn-primary btn-o pull-left"" data-toggle=""modal"" data-target="".bs-example-modal-lg"">
                    Create Grades
                </button>
            </div>
            <table class=""table table-striped table-bordered table-hover table-full-width"" id=""sample_1"">
                <thead>
                    <tr>
                        <th>Browser</th>
                        <th class=""hidden-xs"">Creator</th>
                        <th>
                            Cost (
                            USD)
                        </th>
                        <th");
            WriteLiteral(@" class=""hidden-xs""> Software license</th>
                        <th>
                            Current
                            layout engine
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Amaya</td>
                        <td class=""hidden-xs"">
                            W3C,
                            INRIA
                        </td>
                        <td>Free</td>
                        <td class=""hidden-xs"">W3C</td>
                        <td>Amaya</td>
                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>
<!-- end: DYNAMIC TABLE -->
<!-- Large Modal -->
<div class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal");
            WriteLiteral(@"-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"" id=""myModalLabel"">Create Grade</h4>
            </div>
            <div class=""modal-body"">




                <div class=""container-fluid container-fullw bg-white"">
                    <div class=""row"">

");
#nullable restore
#line 79 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Grade\Index.cshtml"
                         using (Html.BeginForm("Create", "Student", new { @class = "smart-wizard", role = "form" }))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <fieldset>
                                        <legend>
                                           Creat Grade
                                        </legend>
                                        <div class=""form-group"">
                                            <div class=""row"">
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label>
                                                            Grade
                                                        </label>
                                                        <input type=""text"" placeholder=""Enter grades"" class=""form-control"" name=""firstName"" />
                                                    </div>
                                  ");
            WriteLiteral(@"              </div>
                                                <div class=""col-md-3"">
                                                    <div class=""form-group"">
                                                        <label>
                                                            Grade Points
                                                        </label>
                                                        <input type=""text"" placeholder=""Enter points"" class=""form-control"" name=""firstName"" />

                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <div class=""form-group"">
                                                        <label class=""control-label "">
                                                         Grade Fees
                                                        </label>
            ");
            WriteLiteral(@"                                            <input type=""text"" placeholder=""Enter fees"" class=""form-control"" name=""firstName"" />
                                                    </div>
                                                </div>                                           
                                                
                                                <div class=""col-md-12"">
                                                    <div class=""form-group"">
                                                        <label class=""control-label"">
                                                            Grade Description
                                                        </label>
                                                        <textarea placeholder=""Grade Description"" id=""form-field-22"" class=""form-control""></textarea> </div>
                                                </div>                                              
                                          ");
            WriteLiteral(@"  </div>
                                        </div>
                                    </fieldset>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <button id=""submit"" class=""btn btn-primary next-step btn-wide pull-right"">
                                    Save changes <i class=""fa fa-arrow-circle-right""></i>
                                </button>
                            </div>
");
#nullable restore
#line 133 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Grade\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btn-o"" data-dismiss=""modal"">
                    Close
                </button>              
            </div>
        </div>
    </div>
</div>
<!-- /Large Modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.UI.Models.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
