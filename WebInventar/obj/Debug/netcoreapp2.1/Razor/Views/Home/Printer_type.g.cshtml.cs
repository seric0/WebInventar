#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1b14856e49af83ea4014eef2ebbc16df64f1c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Printer_type), @"mvc.1.0.view", @"/Views/Home/Printer_type.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Printer_type.cshtml", typeof(AspNetCore.Views_Home_Printer_type))]
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
#line 1 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\_ViewImports.cshtml"
using WebInventar;

#line default
#line hidden
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\_ViewImports.cshtml"
using WebInventar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1b14856e49af83ea4014eef2ebbc16df64f1c3", @"/Views/Home/Printer_type.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Printer_type : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Printer_cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
  
    ViewBag.Title = "Printer_cart";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(126, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(306, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(373, 257, true);
            WriteLiteral(@"
                </li>
                <li>
                    Принтеры
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 630, "\"", 676, 4);
            WriteAttributeValue("", 638, "Всего", 638, 5, true);
            WriteAttributeValue(" ", 643, "компьютеров", 644, 12, true);
            WriteAttributeValue(" ", 655, "-", 656, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
WriteAttributeValue(" ", 657, ViewBag.compcount, 658, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(677, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(804, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(821, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 967, "\"", 1011, 4);
            WriteAttributeValue("", 975, "Всего", 975, 5, true);
            WriteAttributeValue(" ", 980, "ноутбуков", 981, 10, true);
            WriteAttributeValue(" ", 990, "-", 991, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
WriteAttributeValue(" ", 992, ViewBag.noutcount, 993, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1012, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1137, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1300, "\"", 1347, 4);
            WriteAttributeValue("", 1308, "Всего", 1308, 5, true);
            WriteAttributeValue(" ", 1313, "принтеров", 1314, 10, true);
            WriteAttributeValue(" ", 1323, "-", 1324, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
WriteAttributeValue(" ", 1325, ViewBag.printercount, 1326, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1472, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1638, "\"", 1691, 4);
            WriteAttributeValue("", 1646, "Всего", 1646, 5, true);
            WriteAttributeValue(" ", 1651, "комплектующих", 1652, 14, true);
            WriteAttributeValue(" ", 1665, "-", 1666, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
WriteAttributeValue(" ", 1667, ViewBag.componentcount, 1668, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1692, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1821, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1843, 424, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Принтеры (Тип картриджа)</h2>
                    </div>
                    <div class=""box-content"">
                        Всего записей - ");
            EndContext();
            BeginContext(2268, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                                   Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2281, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2338, 82, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                   Write(Html.ActionLink("Добавить", "Printer_type_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 452, true);
            WriteLiteral(@"
                        <br>
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Наименование</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 70 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(2966, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3053, 6, false);
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                                       Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3059, 326, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center""></td>
                                    </tr>
");
            EndContext();
#line 79 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Printer_type.cshtml"
                                }

#line default
#line hidden
            BeginContext(3420, 193, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Printer_cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
