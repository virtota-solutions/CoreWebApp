#pragma checksum "C:\Users\curti\Desktop\SeniorProjectFrontEnd\CoreWebApp\PCVMurcorWebApp\Views\User\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695445f80c6be2a8ee1bedec878154cc1e3706a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Post), @"mvc.1.0.view", @"/Views/User/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Post.cshtml", typeof(AspNetCore.Views_User_Post))]
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
#line 1 "C:\Users\curti\Desktop\SeniorProjectFrontEnd\CoreWebApp\PCVMurcorWebApp\Views\_ViewImports.cshtml"
using PCVMurcorWebApp;

#line default
#line hidden
#line 2 "C:\Users\curti\Desktop\SeniorProjectFrontEnd\CoreWebApp\PCVMurcorWebApp\Views\_ViewImports.cshtml"
using PCVMurcorWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695445f80c6be2a8ee1bedec878154cc1e3706a0", @"/Views/User/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179cd0e116c21aa66bea105ae616cdc3b7b2fb71", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Requirements", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\curti\Desktop\SeniorProjectFrontEnd\CoreWebApp\PCVMurcorWebApp\Views\User\Post.cshtml"
  
    ViewData["Title"] = "Post";

#line default
#line hidden
            BeginContext(42, 1590, true);
            WriteLiteral(@"
<h2>Post</h2>
<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""Name"">Name:</label>
                <div class=""col-sm-10"">
                    <p>null</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""pwd"">Job Title</label>
                <div class=""col-sm-10"">
                    <p>null</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""pwd"">Department</label>
                <div class=""col-sm-10"">
                    <p>null</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""pwd"">Office</label>
                <div class=""col-sm-10"">
                    <p>null</p>
");
            WriteLiteral(@"                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""pwd"">Manager's Name</label>
                <div class=""col-sm-10"">
                    <p>null</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""pwd"">Is he/she a manager?</label>
                <div class=""col-sm-10"">
                    <p>null</p>
                </div>
            </div>

            
            ");
            EndContext();
            BeginContext(1632, 4159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44cb5f01b7c447ab08e67ac4334c272", async() => {
                BeginContext(1702, 4082, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" >Request Type</label>
                    <div class=""col-sm-10"">
                        <p>null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" >Request By</label>
                    <div class=""col-sm-10"">
                        <p>null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"">Start Date</label>
                    <div class=""col-sm-10"">
                        <p>null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" >End Date</label>
                    <div class=""col-sm-10"">
                        <p>null</p>
                    </div>
                </div>

 ");
                WriteLiteral(@"               <div class=""form-group"">
                    <label class=""control-label col-sm-2"" >Floor and Cube Number</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"">Move to</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""DidNum"">DID Number</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""DualMon"">Dual Monitor</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </d");
                WriteLiteral(@"iv>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""RemoAcc"">Remote Access</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""RemoLap"">Mgr/Remote Laptop</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""Mobile"">Mobile Phone</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""CopyProfile"">Copy Profile for Citrix &Aacute; Security Access</label>
    ");
                WriteLiteral(@"                <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""UserStatusChange"">Change Status to</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""UserNameChange"">Change Username to</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""LOA"">For REMOVE USER REQUEST OR LOA Forward Emails to</label>
                    <div class=""col-sm-10"">
                        <p>Null</p>
                    </div>
                </div>
            ");
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
            BeginContext(5791, 42, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
