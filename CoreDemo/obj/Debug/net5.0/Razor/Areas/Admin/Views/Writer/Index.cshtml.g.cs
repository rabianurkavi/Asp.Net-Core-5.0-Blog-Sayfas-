#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845b49ee2f043f02c474f3a736b10302c4defdb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845b49ee2f043f02c474f3a736b10302c4defdb3", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar Sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-secondary"">Yazar Güncelle</button>
<br />
<br />
<div id=""writerlist"">
    Buraya yazarlar gelecek
</div>
<br />
<div id=""writerget"">

</div>
<br />
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID değerini girin:"" class=""form-control"" />
</div>
<br />
<div>
    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar Adını Giriniz"" />
    <br />
    <input type=""text"" class=""form-control"" id=""txtwriterabout"" placeholder=""Yazar Hakkındayı Giriniz"" />
    <br />
    <input type=""text"" c");
            WriteLiteral(@"lass=""form-control"" id=""txtwriterimage"" placeholder=""Yazarın Görselini Giriniz"" />
    <br />
    <input type=""text"" class=""form-control"" id=""txtwritermail"" placeholder=""Yazarın Mailini Giriniz"" />
    <br />
    <input type=""text"" class=""form-control"" id=""txtwriterpasswrod"" placeholder=""Yazarın Şifresini Giriniz"" />
    <br />
</div>
<div>
    <input type=""text"" class=""form-control"" id=""txtid"" placeholder=""Silenecek yazar Idsini girin"" />
</div>
<div>
    <input type=""text"" id=""txtid1"" class=""form-control"" placeholder=""Güncellenecek Id"" />
    <input type=""text"" id=""txtid2"" class=""form-control"" placeholder=""Güncellenecek İsim"" />
    <input type=""text"" id=""txtid3"" class=""form-control"" placeholder=""Güncellenecek Hakkında"" />
    <input type=""text"" id=""txtid4"" class=""form-control"" placeholder=""Güncellenecek İmage"" />
    <input type=""text"" id=""txtid5"" class=""form-control"" placeholder=""Güncellenecek Mail"" />
    <input type=""text"" id=""txtid6"" class=""form-control"" placeholder=""Güncellenecek Passw");
            WriteLiteral("ord\" />\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#btngetlist').click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    //yazarların tabloda görüntülenmesi
                    console.log(w);
                    let tableHtml = ""<table class=table table-bordered> <tr><th>Yazar ID </th> <th> Yazar Adı </th><th> Yazar Maili </th><th> Yazar Durumu </th> </tr>"";
                    $.each(w, (index, value) => {
                        tableHtml += `<tr><td>${value.WriterId}</td> <td>${value.WriterName}</td><td>${value.WriterMail}</td><td>${value.WriterStatus}</td> </tr>`
                    });
                    tableHtml += ""</table>"";
                    $(""#writerlist"").html(tableHtml);
                }
            });");
                WriteLiteral(@"
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class=table table-bordered> <tr><th>Yazar ID</th> <th>Yazar Adı</th><th>Yazar Maili</th><th>Yazar Durumu</th></tr> <tr><td>${w.WriterId}</td><td>${w.WriterName}</td><td>${w.WriterMail}</td><td>${w.WriterStatus}</td></tr></table>`;
                    $(""#writerget"").html(getvalue);//yazdırma işlemi yukarıdaki dive
                }
            });
        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                WriterName: $(""#txtwritername"").val(),
             ");
                WriteLiteral(@"   WriterAbout: $(""#txtwriterabout"").val(),
                WriterImage: $(""#txtwriterimage"").val(),
                WriterMail: $(""#txtwritermail"").val(),
                WriterPassword: $(""#txtwriterpasswrod"").val(),


            };
            $.ajax({
                type: ""Post"",
                url: ""/Admin/Writer/AddWriter"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar ekleme işlemi başarılı bir şekilde gerçekleşti."");
                }
            });
        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();
            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silme işlemi başarılı bir şekilde gerçekleşti."");
                }
            });
        });

");
                WriteLiteral(@"        $(""#btnupdatewriter"").click(function () {
            let writer = {
                WriterId: $(""#txtid1"").val(),
                WriterName: $(""#txtid2"").val(),
                WriterAbout: $(""#txtid3"").val(),
                WriterImage: $(""#txtid4"").val(),
                WriterMail: $(""#txtid5"").val(),
                WriterPassword: $(""#txtid6"").val(),

            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (func) {
                    alert(""Güncelleme yapıldı."");
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
