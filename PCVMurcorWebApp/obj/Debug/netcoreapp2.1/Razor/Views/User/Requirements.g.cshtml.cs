#pragma checksum "C:\Users\curti\Desktop\PCV\CoreWebApp\PCVMurcorWebApp\Views\User\Requirements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd47a8ba62c419091a0319c356e5db5f577a6350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Requirements), @"mvc.1.0.view", @"/Views/User/Requirements.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Requirements.cshtml", typeof(AspNetCore.Views_User_Requirements))]
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
#line 1 "C:\Users\curti\Desktop\PCV\CoreWebApp\PCVMurcorWebApp\Views\_ViewImports.cshtml"
using PCVMurcorWebApp;

#line default
#line hidden
#line 2 "C:\Users\curti\Desktop\PCV\CoreWebApp\PCVMurcorWebApp\Views\_ViewImports.cshtml"
using PCVMurcorWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd47a8ba62c419091a0319c356e5db5f577a6350", @"/Views/User/Requirements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179cd0e116c21aa66bea105ae616cdc3b7b2fb71", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Requirements : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVMurcorWebApp.Models.UserRequirements>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/User/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\curti\Desktop\PCV\CoreWebApp\PCVMurcorWebApp\Views\User\Requirements.cshtml"
  
    ViewData["Title"] = "Requirements";

#line default
#line hidden
            BeginContext(96, 139, true);
            WriteLiteral("\r\n<h2>Requirements</h2>\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(235, 5422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6074e2cf983346c2aa9c7e0e13fd3aa2", async() => {
                BeginContext(305, 5345, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Floor and Cube Number</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""floorNum"" placeholder=""Floor Number"" /><br />
                        <input type=""text"" class=""form-control"" id=""cubeNum"" placeholder=""Cube Number"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Move to</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""floorNum"" placeholder=""Floor Number"" /><br />
                        <input type=""text"" class=""form-control"" id=""cubeNum"" placeholder=""Cube Number"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">DID Nu");
                WriteLiteral(@"mber</label>
                    <div class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">Yes</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">No</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">NA</label>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Dual Monitor</label>
                    <div class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">Yes</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">No</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">NA</label>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""contro");
                WriteLiteral(@"l-label col-sm-2"" for=""pwd"">Remote Access</label>
                    <div class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">Yes</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">No</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">NA</label>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Mgr/Remote Laptop</label>
                    <div class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">Yes</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">No</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">NA</label>
                    </div>
                </div>
                <div class=""form-group"">");
                WriteLiteral(@"
                    <label class=""control-label col-sm-2"" for=""pwd"">Mobile Phone</label>
                    <div class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">Yes</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">No</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"">NA</label>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Copy Profile for Citrix and Security Access</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""secAccess"" placeholder=""Security Access"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Change Status to</label>
                    <div ");
                WriteLiteral(@"class=""col-sm-10"">
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"" />Permanent</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"" />Temporary</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"" />Contractor</label>
                        <label class=""radio-inline""><input type=""radio"" name=""optradio"" />NA</label>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Change Username to</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""changeUserName"" placeholder=""Change Username to"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">For REMOVE USER REQUEST OR LOA Forward Emails to</label>");
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        <input type=\"text\" class=\"form-control\" id=\"fwdEmail\" placeholder=\"Forward Emails to\" />\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5657, 145, true);
            WriteLiteral("\r\n            <a href=\"/User/post\">Submit</a>\r\n\r\n            <a href=\"/User/applicationaccess\">Next</a>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVMurcorWebApp.Models.UserRequirements> Html { get; private set; }
    }
}
#pragma warning restore 1591
