#pragma checksum "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb376ae717b6f746b634167b92dd73c64c95aef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProjectStudentSeek), @"mvc.1.0.view", @"/Views/Shared/_ProjectStudentSeek.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb376ae717b6f746b634167b92dd73c64c95aef", @"/Views/Shared/_ProjectStudentSeek.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905f97f8a1ec4b45305dd28da690a8597b938ae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProjectStudentSeek : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { name = "F" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\" style=\"background-color:white;\">\n        ");
#nullable restore
#line 7 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml"
   Write(Html.DropDownList("DistinctList", null,
            htmlAttributes: new { @class = "form-control" }
        ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral(@"    <div class=""col-md-12"">
        <input placeholder=""Od:"" class=""form-control text-box single-line"" type=""text"" onfocus=""(this.type='date')"" onblur=""(this.type='date')"" id=""Od"" name=""Od"">


    </div>
    <div class=""col-md-12"">
        <input placeholder=""Do:"" class=""form-control text-box single-line"" type=""text"" onfocus=""(this.type='date')"" onblur=""(this.type='date')"" id=""Do"" name=""Do"">

    </div>
");
            WriteLiteral("    <div class=\"col-sm-12\">\n        <input type=\"submit\" value=\"Wyszukaj\" />\n    </div>\n");
#nullable restore
#line 25 "C:\Users\czain\Desktop\Repository\Repository\ManyToManyRepoAsyn\ManyToManyRepoAsyn\Views\Shared\_ProjectStudentSeek.cshtml"
}

#line default
#line hidden
#nullable disable
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
