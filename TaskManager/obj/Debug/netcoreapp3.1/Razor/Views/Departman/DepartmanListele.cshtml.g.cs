#pragma checksum "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc99474a0a73f5c50bd249b3f7eb2337a81d8746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departman_DepartmanListele), @"mvc.1.0.view", @"/Views/Departman/DepartmanListele.cshtml")]
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
#line 1 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc99474a0a73f5c50bd249b3f7eb2337a81d8746", @"/Views/Departman/DepartmanListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Departman_DepartmanListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Departman>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
  
    ViewData["Title"] = "departmanListeleView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Departman Id</th>\r\n            <th scope=\"col\">Departman Ad</th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> ");
#nullable restore
#line 18 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
    Write(d.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
   Write(d.departmanAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 445, 2);
            WriteAttributeValue("", 416, "/Departman/DepartmanSil/", 416, 24, true);
#nullable restore
#line 20 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
WriteAttributeValue("", 440, d.Id, 440, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Sil </a></td>\r\n    \r\n</tr>\r\n");
#nullable restore
#line 23 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Departman\DepartmanListele.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Departman/YeniDepartman\" class=\"btn btn-info\"> Departman Ekle </a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Departman>> Html { get; private set; }
    }
}
#pragma warning restore 1591