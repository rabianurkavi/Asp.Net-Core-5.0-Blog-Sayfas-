#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89eb57ad7ac7e90a36f402cc26dd1198677a4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89eb57ad7ac7e90a36f402cc26dd1198677a4b6", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı Soyadı</th>\r\n        <th>Sil</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
           Write(item.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
           Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 454, "\"", 506, 2);
            WriteAttributeValue("", 461, "/EmployeeTest/DeleteEmployee/", 461, 29, true);
#nullable restore
#line 20 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 490, item.EmployeeId, 490, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 623, 2);
            WriteAttributeValue("", 578, "/EmployeeTest/UpdateEmployee/", 578, 29, true);
#nullable restore
#line 21 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 607, item.EmployeeId, 607, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/EmployeeTest/AddEmployee/\" class=\"btn btn-outline-primary\">Yeni Çalışan Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
