#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fada0eeac2d0206e9700699bee74d1774be18315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PrinterView), @"mvc.1.0.view", @"/Views/Home/PrinterView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PrinterView.cshtml", typeof(AspNetCore.Views_Home_PrinterView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fada0eeac2d0206e9700699bee74d1774be18315", @"/Views/Home/PrinterView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PrinterView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Printerwithcart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
  
    ViewBag.Title = "Printer";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(124, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(304, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(371, 257, true);
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
            BeginWriteAttribute("title", " title=\"", 628, "\"", 674, 4);
            WriteAttributeValue("", 636, "Всего", 636, 5, true);
            WriteAttributeValue(" ", 641, "компьютеров", 642, 12, true);
            WriteAttributeValue(" ", 653, "-", 654, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
WriteAttributeValue(" ", 655, ViewBag.compcount, 656, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(675, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(802, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(819, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 965, "\"", 1009, 4);
            WriteAttributeValue("", 973, "Всего", 973, 5, true);
            WriteAttributeValue(" ", 978, "ноутбуков", 979, 10, true);
            WriteAttributeValue(" ", 988, "-", 989, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
WriteAttributeValue(" ", 990, ViewBag.noutcount, 991, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1010, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1135, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1298, "\"", 1345, 4);
            WriteAttributeValue("", 1306, "Всего", 1306, 5, true);
            WriteAttributeValue(" ", 1311, "принтеров", 1312, 10, true);
            WriteAttributeValue(" ", 1321, "-", 1322, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
WriteAttributeValue(" ", 1323, ViewBag.printercount, 1324, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1346, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1470, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1490, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1636, "\"", 1689, 4);
            WriteAttributeValue("", 1644, "Всего", 1644, 5, true);
            WriteAttributeValue(" ", 1649, "комплектующих", 1650, 14, true);
            WriteAttributeValue(" ", 1663, "-", 1664, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
WriteAttributeValue(" ", 1665, ViewBag.componentcount, 1666, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1690, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1819, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 368, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Принтеры</h2>
                    </div>
                    <div class=""box-content"">
");
            EndContext();
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                         foreach (var Model in Model)
                        {

#line default
#line hidden
            BeginContext(2291, 396, true);
            WriteLiteral(@"                            <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                                <tr>
                                    <td>
                                        Инвентарный номер (принтер):
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(2688, 23, false);
#line 66 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer.Sys_inv_p);

#line default
#line hidden
            EndContext();
            BeginContext(2711, 356, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Серийный номер (принтер):
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(3068, 22, false);
#line 74 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer.Sys_sn_p);

#line default
#line hidden
            EndContext();
            BeginContext(3090, 339, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Кабинет:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(3430, 19, false);
#line 82 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer.Cab_p);

#line default
#line hidden
            EndContext();
            BeginContext(3449, 344, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Наименование:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(3794, 23, false);
#line 90 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer_name.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3817, 344, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Тип принтера:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4162, 23, false);
#line 98 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer_type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4185, 349, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Технология печати:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4535, 28, false);
#line 106 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer_texnology.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4563, 345, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Формат печати:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(4909, 25, false);
#line 114 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer_format.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4934, 345, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Тип картриджа:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(5280, 23, false);
#line 122 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                                   Write(Model.Printer_cart.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5303, 122, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n");
            EndContext();
#line 126 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\PrinterView.cshtml"
                        }

#line default
#line hidden
            BeginContext(5452, 121, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Printerwithcart>> Html { get; private set; }
    }
}
#pragma warning restore 1591