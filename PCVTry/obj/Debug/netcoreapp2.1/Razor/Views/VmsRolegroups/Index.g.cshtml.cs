#pragma checksum "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e56bcd4ba1ee67259f9b18b1bc44f1994e1c504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VmsRolegroups_Index), @"mvc.1.0.view", @"/Views/VmsRolegroups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VmsRolegroups/Index.cshtml", typeof(AspNetCore.Views_VmsRolegroups_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e56bcd4ba1ee67259f9b18b1bc44f1994e1c504", @"/Views/VmsRolegroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69dc469ac0f93126037a0bcfc88d15baf964f9d3", @"/Views/_ViewImports.cshtml")]
    public class Views_VmsRolegroups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PCVTry.Models.VmsRolegroup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9a2a9b319f4db0bf956b3c2ca0314e", async() => {
                BeginContext(143, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 48, false);
#line 16 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 48, false);
#line 19 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 44, false);
#line 22 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 43, false);
#line 25 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(657, 51, false);
#line 28 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(708, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(764, 49, false);
#line 31 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(813, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(869, 51, false);
#line 34 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(920, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(976, 48, false);
#line 37 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1080, 43, false);
#line 40 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1179, 59, false);
#line 43 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1294, 52, false);
#line 46 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1402, 38, false);
#line 49 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1496, 46, false);
#line 52 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1598, 47, false);
#line 55 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1701, 56, false);
#line 58 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1875, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1924, 47, false);
#line 67 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2027, 47, false);
#line 70 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(2074, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2130, 43, false);
#line 73 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2229, 42, false);
#line 76 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2327, 50, false);
#line 79 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2433, 48, false);
#line 82 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2537, 50, false);
#line 85 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2643, 47, false);
#line 88 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(2690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2746, 42, false);
#line 91 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(2788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2844, 58, false);
#line 94 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2902, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2958, 51, false);
#line 97 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3065, 37, false);
#line 100 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(3102, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3158, 45, false);
#line 103 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3203, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3259, 46, false);
#line 106 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3305, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3361, 55, false);
#line 109 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3416, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3471, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32efed0285a4c2894d9eb407942e139", async() => {
                BeginContext(3528, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                       WriteLiteral(item.VmsroleGroupId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3536, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3556, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556c8230faf94e6a8318ec189d1abf6a", async() => {
                BeginContext(3616, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                          WriteLiteral(item.VmsroleGroupId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3627, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3647, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e701571cf9a48a5950d06a768b212be", async() => {
                BeginContext(3706, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                         WriteLiteral(item.VmsroleGroupId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3716, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\lil-v\source\repos\PCVTry\PCVTry\Views\VmsRolegroups\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3755, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PCVTry.Models.VmsRolegroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
