#pragma checksum "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7fd08be9d16650fc2e683e0d31ffd76d6ad76d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Detail.cshtml", typeof(AspNetCore.Views_Employee_Detail))]
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
#line 1 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7fd08be9d16650fc2e683e0d31ffd76d6ad76d6", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 245, true);
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <nav aria-label=\"breadcrumb\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(277, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7fd08be9d16650fc2e683e0d31ffd76d6ad76d64064", async() => {
                BeginContext(321, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(329, 55, true);
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(384, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7fd08be9d16650fc2e683e0d31ffd76d6ad76d65693", async() => {
                BeginContext(406, 13, true);
                WriteLiteral("Employee List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(423, 344, true);
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Employee Details</li>
                </ol>
            </nav><br /><br />
            <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 767, "\"", 801, 1);
#line 14 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 773, Url.Content(Model.ImageUrl), 773, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 156, true);
            WriteLiteral(" alt=\"\" />\r\n                <div class=\"wrap align-items-center ml-5\">\r\n                    <p class=\"font-weight-bold text-success\" style=\"font-size:20px\">");
            EndContext();
            BeginContext(959, 14, false);
#line 16 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                                               Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(973, 63, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Role: ");
            EndContext();
            BeginContext(1037, 17, false);
#line 17 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                    Write(Model.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 65, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Gender: ");
            EndContext();
            BeginContext(1120, 12, false);
#line 18 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                      Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 71, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Date Of Birth: ");
            EndContext();
            BeginContext(1204, 32, false);
#line 19 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                            Write(Model.DOB.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 73, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Employee Number: ");
            EndContext();
            BeginContext(1310, 16, false);
#line 20 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                              Write(Model.EmployeeNo);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 67, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">NI Number: ");
            EndContext();
            BeginContext(1394, 25, false);
#line 21 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                        Write(Model.NationalInsuranceNo);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 75, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Email: <a href=\"#\">");
            EndContext();
            BeginContext(1495, 11, false);
#line 22 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                                Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1506, 69, true);
            WriteLiteral("</a></p>\r\n                    <p class=\"font-weight-normal\">Phone: <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1575, "\"", 1598, 2);
            WriteAttributeValue("", 1582, "tel:", 1582, 4, true);
#line 23 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1586, Model.Phone, 1586, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1599, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1601, 11, false);
#line 23 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 243, true);
            WriteLiteral("</a></p>\r\n                    <br /><br />\r\n                    <p class=\"font-weight-bold\"> Pay & Deductions</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-normal\"> Payment Method: ");
            EndContext();
            BeginContext(1856, 19, false);
#line 27 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                              Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(1875, 71, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Student Loan: ");
            EndContext();
            BeginContext(1947, 17, false);
#line 28 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                            Write(Model.StudentLoan);

#line default
#line hidden
            EndContext();
            BeginContext(1964, 71, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Union Member: ");
            EndContext();
            BeginContext(2036, 17, false);
#line 29 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                                            Write(Model.UnionMember);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 139, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"><i class=\"fas fa-envelope\" style=\"margin-right:0.6em; color:cornflowerblue\"></i> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2192, "\"", 2271, 7);
            WriteAttributeValue("", 2199, "mailto:", 2199, 7, true);
#line 30 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2206, Model.Email, 2206, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2218, "?subject=Payslip&body=Attached", 2218, 30, true);
            WriteAttributeValue(" ", 2248, "within", 2249, 7, true);
            WriteAttributeValue(" ", 2255, "is", 2256, 3, true);
            WriteAttributeValue(" ", 2258, "your", 2259, 5, true);
            WriteAttributeValue(" ", 2263, "paylip.", 2264, 8, true);
            EndWriteAttribute();
            BeginContext(2272, 233, true);
            WriteLiteral(">Send Payslip</a></p>\r\n                    <br /><br />\r\n\r\n                    <p class=\"font-weight-bold\"> Address</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2506, 13, false);
#line 35 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                              Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 57, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2577, 10, false);
#line 36 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                              Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2587, 57, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
            EndContext();
            BeginContext(2645, 14, false);
#line 37 "C:\Users\NHA007\Desktop\Enterprise\Paycompute\Views\Employee\Detail.cshtml"
                                              Write(Model.Postcode);

#line default
#line hidden
            EndContext();
            BeginContext(2659, 142, true);
            WriteLiteral("</p>\r\n                    <br />\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
