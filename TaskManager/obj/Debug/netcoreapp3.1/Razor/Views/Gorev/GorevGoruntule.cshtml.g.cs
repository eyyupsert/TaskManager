#pragma checksum "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1859f57a634cb642b1cce96c297c5cc2360044bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gorev_GorevGoruntule), @"mvc.1.0.view", @"/Views/Gorev/GorevGoruntule.cshtml")]
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
#line 1 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1859f57a634cb642b1cce96c297c5cc2360044bf", @"/Views/Gorev/GorevGoruntule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Gorev_GorevGoruntule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gorev>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/photo/list.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
  
    ViewData["Title"] = "GorevGoruntule";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Görev No</th>
                <th scope=""col"">Görev Sahibi</th>
                <th scope=""col"">Görev Ad</th>
                <th scope=""col"">Görev Güncelle</th>
                <th scope=""col"">Görev Durum</th>
                <th scope=""col"">Görev Detay </th>
                <th scope=""col"">Son Teslim Tarihi </th>
            </tr>
        </thead>
");
#nullable restore
#line 21 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
         foreach (var x in Model)
        {
            var durum = x.gorevDurum;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td> ");
#nullable restore
#line 25 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        Write(x.gorevId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 26 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        Write(x.per.personelAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
                          Write(x.per.personelSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 27 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        Write(x.gorevAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td>\r\n            <button type=\"button\" class=\"btn btn-danger\">x</button>\r\n            <button type=\"button\" class=\"btn btn-info\">+</button>\r\n        </td>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
         if (durum == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Yapılmadı</td>\r\n");
#nullable restore
#line 36 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
         if (durum == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Yapıldı</td>\r\n");
#nullable restore
#line 40 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td><button type=\"button\" class=\"btn btn-info\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1859f57a634cb642b1cce96c297c5cc2360044bf6762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button></td>\r\n        <td> ");
#nullable restore
#line 42 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        Write(x.gorevSonTeslimTarihi.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Gorev\GorevGoruntule.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gorev>> Html { get; private set; }
    }
}
#pragma warning restore 1591