#pragma checksum "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1f273d41a673fc0197e1264cbe429cd188a809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VmsRolegroups_Delete), @"mvc.1.0.view", @"/Views/VmsRolegroups/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VmsRolegroups/Delete.cshtml", typeof(AspNetCore.Views_VmsRolegroups_Delete))]
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
#line 1 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\_ViewImports.cshtml"
using PCVTry;

#line default
#line hidden
#line 2 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\_ViewImports.cshtml"
using PCVTry.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1f273d41a673fc0197e1264cbe429cd188a809", @"/Views/VmsRolegroups/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69dc469ac0f93126037a0bcfc88d15baf964f9d3", @"/Views/_ViewImports.cshtml")]
    public class Views_VmsRolegroups_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.VmsRolegroup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>VmsRolegroup</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(253, 48, false);
#line 15 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 44, false);
#line 18 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(433, 48, false);
#line 21 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(525, 44, false);
#line 24 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(613, 44, false);
#line 27 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(701, 40, false);
#line 30 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(785, 43, false);
#line 33 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(872, 39, false);
#line 36 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(955, 51, false);
#line 39 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1050, 47, false);
#line 42 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1141, 49, false);
#line 45 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1234, 45, false);
#line 48 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1323, 51, false);
#line 51 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1418, 47, false);
#line 54 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1509, 48, false);
#line 57 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1601, 44, false);
#line 60 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1689, 43, false);
#line 63 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1776, 39, false);
#line 66 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1859, 59, false);
#line 69 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1962, 55, false);
#line 72 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2061, 52, false);
#line 75 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2157, 48, false);
#line 78 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2249, 38, false);
#line 81 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2331, 34, false);
#line 84 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2409, 46, false);
#line 87 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2499, 42, false);
#line 90 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2541, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2585, 47, false);
#line 93 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2676, 43, false);
#line 96 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2763, 56, false);
#line 99 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2863, 52, false);
#line 102 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2953, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa7e00a185a24bb89c6778a3055faed2", async() => {
                BeginContext(2979, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2989, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14811e9046a04b049a03f40afa6bd59f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VmsroleGroupId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3037, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3121, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "495a08de70aa466d9bbc68584755c1e3", async() => {
                    BeginContext(3143, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(3159, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3172, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.VmsRolegroup> Html { get; private set; }
    }
}
#pragma warning restore 1591
