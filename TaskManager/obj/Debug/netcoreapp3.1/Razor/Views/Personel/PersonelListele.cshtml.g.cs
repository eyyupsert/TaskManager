#pragma checksum "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "511f054d906b0f767e8283b8b6618d5543eee932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_PersonelListele), @"mvc.1.0.view", @"/Views/Personel/PersonelListele.cshtml")]
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
#line 1 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511f054d906b0f767e8283b8b6618d5543eee932", @"/Views/Personel/PersonelListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_PersonelListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
  
    ViewData["Title"] = "Personel Listele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <a href=""/Personel/YeniPersonelEkle"" class=""btn btn-info"" style=""margin:10px"">Personel Ekle</a>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Personel No</th>
                <th scope=""col"">Personel İsim</th>
                <th scope=""col"">Personel Departman</th>
                <th scope=""col"">İşe Başlama Tarihi</th>
                <th scope=""col"">Telefon Numarası</th>
                <th scope=""col"">Mail Adresi</th>
                <th scope=""col"">Personel Sil</th>
                <th scope=""col"">Personel Güncelle</th>
            </tr>
        </thead>

");
#nullable restore
#line 23 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 26 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                Write(x.personelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 27 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                Write(x.personelAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                              Write(x.personelSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                Write(x.depart.departmanAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 29 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                Write(x.iseBaslamaTarihi.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
               Write(String.Format("{0:+90 (###) ### ## ##}", Decimal.Parse(x.telNo)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
                Write(x.mailAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n                <td><button type=\"button\" class=\"btn btn-danger\">Sil</button></td>\r\n                <td><button type=\"button\" class=\"btn btn-info\">Güncelle</button></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\eyyup\Documents\GitHub\TaskManager\TaskManager\Views\Personel\PersonelListele.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
