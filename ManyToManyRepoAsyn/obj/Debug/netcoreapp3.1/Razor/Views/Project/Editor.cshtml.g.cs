#pragma checksum "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Editor), @"mvc.1.0.view", @"/Views/Project/Editor.cshtml")]
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
#line 1 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\_ViewImports.cshtml"
using RelationshipManyToManyCore3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\_ViewImports.cshtml"
using RelationshipManyToManyCore3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c", @"/Views/Project/Editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905f97f8a1ec4b45305dd28da690a8597b938ae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManyToManyCore.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
  
    ViewData["Title"] = "Project Editor";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h4>");
#nullable restore
#line 7 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c6374", async() => {
                WriteLiteral("\n        <!-- <div class=\"m-1 p-1\">\n\n            -->\n        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 288, "\"", 305, 1);
#nullable restore
#line 12 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
WriteAttributeValue("", 296, Model.Id, 296, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        <div class=\"p-1\">\n            <div class=\"row\">\n                <div class=\"col\"><strong>Name </strong></div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col\">\n\n\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c7375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 21 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col""><strong>Data </strong></div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <input type=""date"" id=""Date"" name=""Date""");
                BeginWriteAttribute("value", "\n                           value=\"", 842, "\"", 917, 1);
#nullable restore
#line 30 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
WriteAttributeValue("", 877, Model.Date.Value.ToString("yyyy-MM-dd"), 877, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n            </div>\n        </div>\n\n");
#nullable restore
#line 35 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
         foreach (var item in ViewBag.Students)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-row\">\n                <div class=\"form-group col-1\">\n");
#nullable restore
#line 39 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
                     if (Model.StudentProjectJunction.Any(sp => sp.StudentId == item.Id))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" name=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1292, "\"", 1308, 1);
#nullable restore
#line 41 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
WriteAttributeValue("", 1300, item.Id, 1300, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked />\n");
#nullable restore
#line 42 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" name=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1452, "\"", 1468, 1);
#nullable restore
#line 45 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
WriteAttributeValue("", 1460, item.Id, 1460, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 46 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n                <div class=\"form-group col\">\n                    <label class=\"form-control-label\">");
#nullable restore
#line 49 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
                                                 Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                </div>\n            </div>\n");
#nullable restore
#line 52 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Project\Editor.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br><br>\n        <div class=\"text-center\">\n            <button class=\"btn btn-primary\" type=\"submit\"> Save and exit </button>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c12787", async() => {
                    WriteLiteral("\n                To the list of projects\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3c8636773cdaddb8dc8714ea9d14ac99c0fb3c14367", async() => {
                    WriteLiteral("\n                To the list of studens\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManyToManyCore.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591