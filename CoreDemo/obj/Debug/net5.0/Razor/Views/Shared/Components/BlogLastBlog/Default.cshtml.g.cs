#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9435f31cb54894b61f1565a8c891c9dd49e69dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastBlog/Default.cshtml")]
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
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9435f31cb54894b61f1565a8c891c9dd49e69dc", @"/Views/Shared/Components/BlogLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"single-gd tech-btm\">\r\n    <h4>Son Eklenen Post</h4>\r\n    <div class=\"blog-grids\">\r\n        <div class=\"blog-grid-left\">\r\n            <a href=\"single.html\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 269, "\"", 290, 1);
#nullable restore
#line 10 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml"
WriteAttributeValue("", 275, item.BlogImage, 275, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 309, "\"", 315, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"blog-grid-right\">\r\n\r\n            <h5>\r\n                <a href=\"single.html\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml"
                Write(item.BlogContent.Length > 150 ? item.BlogContent.Substring
                                                          (0, item.BlogContent.Substring(0,155).LastIndexOf(" "))+"..."
                                                           : item.BlogContent + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </h5>\r\n        </div>\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 26 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastBlog\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
