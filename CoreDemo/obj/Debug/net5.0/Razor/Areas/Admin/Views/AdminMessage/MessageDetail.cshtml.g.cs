#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f36bc994dd97ff04a690c617b413e617d914fdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_MessageDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/MessageDetail.cshtml")]
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
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f36bc994dd97ff04a690c617b413e617d914fdd", @"/Areas/Admin/Views/AdminMessage/MessageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMessage_MessageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
  
    ViewData["Title"] = "MessageDetail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f36bc994dd97ff04a690c617b413e617d914fdd3584", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""ibox "">
                    <div class=""ibox-content mailbox-content"">
                        <div class=""file-manager"">
                            <a class=""btn btn-block btn-primary compose-mail"" href=""/Admin/AdminMessage/ComposeMessage/"">Mesaj Oluştur</a>
                            <div class=""space-25""></div>
                            <h5>Dosyalar</h5>
                            <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                <li><a href=""/Admin/AdminMessage/InBox/""> <i class=""fa fa-inbox ""></i> Gelen Mesajlar <span class=""label label-warning float-right"">");
#nullable restore
#line 20 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                                                                                                                                                               Write(ViewBag.messageInboxTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> </a></li>\r\n                                <li><a href=\"/Admin/AdminMessage/SendBox/\"> <i class=\"fa fa-envelope-o\"></i> Giden Mesajlar <span class=\"label label-info float-right\">");
#nullable restore
#line 21 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                                                                                                                                                                  Write(ViewBag.messageSendTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></a> </li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i> Önemli Mesajlar</a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i> Taslaklar <span class=""label label-danger float-right"">2</span></a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Çöp Kutusu</a></li>
                            </ul>
                            <h5>Kategoriler</h5>
                            <ul class=""category-list"" style=""padding: 0"">
                                <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> İş </a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Dökümanlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Sosyal</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Tanıtımlar</a></li>
                ");
                WriteLiteral(@"                <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Talepler</a></li>
                            </ul>
                            <div class=""clearfix""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 animated fadeInRight"">
                <div class=""mail-box-header"">
                    <div class=""float-right tooltip-demo"">
                        <a href=""mail_compose.html"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Reply""><i class=""fa fa-reply""></i> Reply</a>
                        <a href=""#"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Print email""><i class=""fa fa-print""></i> </a>
                        <a href=""mailbox.html"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to trash""><i class=""fa fa-trash-o""></i> </a>
                    </div>
                    <h2>");
                WriteLiteral("\n                        Mesajın İçeriği\r\n                    </h2>\r\n                    <div class=\"mail-tools tooltip-demo m-t-md\">\r\n\r\n\r\n                        <h3>\r\n                            <span class=\"font-normal\">Konu: </span>");
#nullable restore
#line 53 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                                                              Write(Model.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </h3>\r\n                        <h5>\r\n                            <span class=\"float-right font-normal\">");
#nullable restore
#line 56 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                                                             Write(Model.MessageDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span class=\"font-normal\">Gönderen: </span> ");
#nullable restore
#line 57 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                                                                   Write(ViewBag.vtc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </h5>\r\n                    </div>\r\n                </div>\r\n                <div class=\"mail-box\">\r\n\r\n\r\n                    <div class=\"mail-body\">\r\n                        <p>\r\n\r\n                           ");
#nullable restore
#line 67 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetail.cshtml"
                      Write(Model.MessageDetails);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>
                        
                    </div>
                    
                    <div class=""mail-body text-right tooltip-demo"">
                        <a class=""btn btn-sm btn-white"" href=""/Admin/AdminMessage/Inbox/""><i class=""fa fa-reply""></i> Geri</a>
                        <a class=""btn btn-sm btn-white"" href=""/Admin/AdminMessage/ComposeMessage/""><i class=""fa fa-arrow-right""></i> Cevapla</a>
                        <button");
                BeginWriteAttribute("title", " title=\"", 4432, "\"", 4440, 0);
                EndWriteAttribute();
                WriteLiteral(" data-placement=\"top\" data-toggle=\"tooltip\" type=\"button\" data-original-title=\"Print\" class=\"btn btn-sm btn-white\"><i class=\"fa fa-print\"></i> Yazdır</button>\r\n                        <button");
                BeginWriteAttribute("title", " title=\"", 4632, "\"", 4640, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-placement=""top"" data-toggle=""tooltip"" data-original-title=""Trash"" class=""btn btn-sm btn-white""><i class=""fa fa-trash-o""></i> Kaldır</button>
                    </div>
                    <div class=""clearfix""></div>


                </div>
            </div>
        </div>
    </div>
");
                DefineSection("scripts", async() => {
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
