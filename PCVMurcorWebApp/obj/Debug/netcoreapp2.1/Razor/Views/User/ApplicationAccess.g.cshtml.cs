#pragma checksum "/Users/TagEldinAhmed/Documents/GitHub/CoreWebApp/PCVMurcorWebApp/Views/User/ApplicationAccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a3f7240546a98d6e7973b7d1e8c985f0e05ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ApplicationAccess), @"mvc.1.0.view", @"/Views/User/ApplicationAccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ApplicationAccess.cshtml", typeof(AspNetCore.Views_User_ApplicationAccess))]
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
#line 1 "/Users/TagEldinAhmed/Documents/GitHub/CoreWebApp/PCVMurcorWebApp/Views/_ViewImports.cshtml"
using PCVMurcorWebApp;

#line default
#line hidden
#line 2 "/Users/TagEldinAhmed/Documents/GitHub/CoreWebApp/PCVMurcorWebApp/Views/_ViewImports.cshtml"
using PCVMurcorWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11a3f7240546a98d6e7973b7d1e8c985f0e05ca3", @"/Views/User/ApplicationAccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3304b302107d55235fc22cc7595314d71a2e04", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ApplicationAccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/TagEldinAhmed/Documents/GitHub/CoreWebApp/PCVMurcorWebApp/Views/User/ApplicationAccess.cshtml"
  
    ViewData["Title"] = "ApplicationAccess";

#line default
#line hidden
            BeginContext(55, 143, true);
            WriteLiteral("<h2>Application Access</h2>\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(198, 14587, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f92a7cfdba6422b82dc82f3b29cbba0", async() => {
                BeginContext(268, 13639, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">VMS Role/Group (based on User's Job Title)</label>
                    <div class=""col-sm-10"">
                        <div class=""checkbook"">
                            <table>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Accounting Group</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />IT Group</label>

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" valu");
                WriteLiteral(@"e="""" />Admin Support</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Processing/Shipping Group</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Assignor</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />QC Supervisor/Lead</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
        ");
                WriteLiteral(@"                                <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Auditor</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />QC</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Client Services Dept. Mgr.</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Sales Group</label>
                                    </td>
                                </tr>
                ");
                WriteLiteral(@"                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Client Services Group</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Status Group</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Commercial Group</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Vendor Relations Group</label>
 ");
                WriteLiteral(@"                                   </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Contractor QC</label>
                                    </td>
                                </tr>

                            </table>
                        </div>
                    </div>

                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Copy Additional Access of:</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""copy"" placeholder="""" />
                    </div>
                    <div class=""col-sm-10"">
                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />PCI Access</label>
                        <label class=""checkbox-inline""><input");
                WriteLiteral(@" type=""checkbox"" value="""" />FDIC Access</label>
                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />CRM Access</label>
                    </div>
                </div>

                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Copy:</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""copy"" placeholder="""" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">OTS Additional Access</label>
                    <div class=""col-sm-10"">
                        <div class=""checkbook"">
                            <table>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Return Order</label>
                  ");
                WriteLiteral(@"                      &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Multi Assign</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Delete Order</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />To Reassign</label>
                                    </td>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Recrea");
                WriteLiteral(@"te Order</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Appraisal Tag to Shipping</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Maintain Tag Reasons</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Maintain Clarification Reasons</label>
                                    </td>
                                </tr>
                                <tr>
                                    <t");
                WriteLiteral(@"d>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Audit Admin</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Dispute Queue Access</label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">BPO Role/Group</label>
                    <div class=""col-sm-10"">
                        <div class=""checkbook"">
                            <table>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input");
                WriteLiteral(@" type=""checkbox"" value="""" />BPO Admin</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Contract QC</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />FDIC QC</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Hold Orderss</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
            ");
                WriteLiteral(@"                            <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Mark Order Shipped</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />QC (basic)</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />QC Plus</label>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />QC Supervisor</label>
                                    </td>
                                </tr>
                  ");
                WriteLiteral(@"              <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />View Rules</label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">LRV Role/Group</label>
                    <div class=""col-sm-10"">
                        <div class=""checkbook"">
                            <table>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />LRV Admin (with all LRV special modules)</label>
                                    </td>
                                </tr>
                                <tr>
           ");
                WriteLiteral(@"                         <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Fannie QC (Only Fannie Queue)</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />Regular QC (Regular Review Queue)</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""checkbox-inline""><input type=""checkbox"" value="""" />All Queues (All Queues with some special modules)</label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

       ");
                WriteLiteral(@"         <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">Mas500 Access (Accounting Department Only)</label>
                    <div class=""col-sm-10"">
                        <select class=""form-control"" id=""selAcc"" placeholder=""---Select Role---"">
                            ");
                EndContext();
                BeginContext(13907, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "514a3086879d436993f98e7c9352c6d5", async() => {
                    BeginContext(13915, 17, true);
                    WriteLiteral("---Select Role---");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13941, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(13971, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74bf8869e942493f8e2cce4593ddac60", async() => {
                    BeginContext(13979, 13, true);
                    WriteLiteral("Administrator");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14001, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14031, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7796273a31a4f5e99c0158f92eca3ec", async() => {
                    BeginContext(14039, 8, true);
                    WriteLiteral("AP Clerk");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14056, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14086, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c27b10a699944b895336ba729d60603", async() => {
                    BeginContext(14094, 13, true);
                    WriteLiteral("AP Specialist");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14116, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14146, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e53e11c3bbf43ba9a1a580b4c5a19a6", async() => {
                    BeginContext(14154, 13, true);
                    WriteLiteral("AR Specialist");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14176, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14206, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ddffa1ead14c2f8ac75cf45a27c355", async() => {
                    BeginContext(14214, 5, true);
                    WriteLiteral("Other");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14228, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14258, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d9cd534c24f41a2849a90e095d2d556", async() => {
                    BeginContext(14266, 17, true);
                    WriteLiteral("Senior Accountant");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14292, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(14322, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "274aa6fee9a4489b9570c47fabbd5257", async() => {
                    BeginContext(14330, 16, true);
                    WriteLiteral("Staff Accountant");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14355, 423, true);
                WriteLiteral(@"
                        </select>
                    </div>
                </div>

                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""pwd"">If OTHER,</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""other"" placeholder="""" />
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
            BeginContext(14785, 153, true);
            WriteLiteral("\r\n\r\n            <a href=\"/User/requirements\">Previous</a> &emsp;\r\n            <a href=\"/User/reviewerinfo\">Next</a>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
