#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b4d50279377f1d4794c5455a73116edd248cf75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Risograph_view), @"mvc.1.0.view", @"/Views/Home/Risograph_view.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Risograph_view.cshtml", typeof(AspNetCore.Views_Home_Risograph_view))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b4d50279377f1d4794c5455a73116edd248cf75", @"/Views/Home/Risograph_view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Risograph_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Risograph>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
  
    ViewBag.Title = "Risograph";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(107, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(287, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(354, 257, true);
            WriteLiteral(@"
                </li>
                <li>
                    Ризограф
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 611, "\"", 657, 4);
            WriteAttributeValue("", 619, "Всего", 619, 5, true);
            WriteAttributeValue(" ", 624, "компьютеров", 625, 12, true);
            WriteAttributeValue(" ", 636, "-", 637, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
WriteAttributeValue(" ", 638, ViewBag.compcount, 639, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(658, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(785, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(802, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 948, "\"", 992, 4);
            WriteAttributeValue("", 956, "Всего", 956, 5, true);
            WriteAttributeValue(" ", 961, "ноутбуков", 962, 10, true);
            WriteAttributeValue(" ", 971, "-", 972, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
WriteAttributeValue(" ", 973, ViewBag.noutcount, 974, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(993, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1118, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1281, "\"", 1328, 4);
            WriteAttributeValue("", 1289, "Всего", 1289, 5, true);
            WriteAttributeValue(" ", 1294, "принтеров", 1295, 10, true);
            WriteAttributeValue(" ", 1304, "-", 1305, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
WriteAttributeValue(" ", 1306, ViewBag.printercount, 1307, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1329, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1453, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1619, "\"", 1672, 4);
            WriteAttributeValue("", 1627, "Всего", 1627, 5, true);
            WriteAttributeValue(" ", 1632, "комплектующих", 1633, 14, true);
            WriteAttributeValue(" ", 1646, "-", 1647, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
WriteAttributeValue(" ", 1648, ViewBag.componentcount, 1649, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1673, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1802, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 726, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Ризограф</h2>
                    </div>
                    <div class=""box-content"">
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <tr>
                                <td>
                                    Инвентарный номер:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(2551, 14, false);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_inv);

#line default
#line hidden
            EndContext();
            BeginContext(2565, 312, true);
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
            BeginContext(2878, 15, false);
#line 72 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_name);

#line default
#line hidden
            EndContext();
            BeginContext(2893, 313, true);
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
            BeginContext(3207, 15, false);
#line 80 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_type);

#line default
#line hidden
            EndContext();
            BeginContext(3222, 329, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Формат бумаги для печати (мм):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(3552, 17, false);
#line 88 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_format);

#line default
#line hidden
            EndContext();
            BeginContext(3569, 328, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Разрешение сканирования, dpi:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(3898, 18, false);
#line 96 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_optical);

#line default
#line hidden
            EndContext();
            BeginContext(3916, 330, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Скорость печати, листов/минута:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4247, 16, false);
#line 104 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_speed);

#line default
#line hidden
            EndContext();
            BeginContext(4263, 322, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Интерфейс пользователя:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4586, 20, false);
#line 112 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_interface);

#line default
#line hidden
            EndContext();
            BeginContext(4606, 319, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Краска (количество):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4926, 18, false);
#line 120 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_ink_col);

#line default
#line hidden
            EndContext();
            BeginContext(4944, 312, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Краска (тип):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5257, 19, false);
#line 128 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_ink_type);

#line default
#line hidden
            EndContext();
            BeginContext(5276, 319, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Мастер-пленка (тип):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5596, 22, false);
#line 136 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_master_type);

#line default
#line hidden
            EndContext();
            BeginContext(5618, 314, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Электропитание:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5933, 18, false);
#line 144 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Power_supply);

#line default
#line hidden
            EndContext();
            BeginContext(5951, 309, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Масса, кг:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6261, 17, false);
#line 152 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Riso_weight);

#line default
#line hidden
            EndContext();
            BeginContext(6278, 307, true);
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
            BeginContext(6586, 9, false);
#line 160 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Cab);

#line default
#line hidden
            EndContext();
            BeginContext(6595, 323, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ФИО ответственного лица:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6919, 15, false);
#line 168 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Fio_admin);

#line default
#line hidden
            EndContext();
            BeginContext(6934, 315, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Дата заполнения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7250, 10, false);
#line 176 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph_view.cshtml"
                               Write(Model.Data);

#line default
#line hidden
            EndContext();
            BeginContext(7260, 231, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Risograph> Html { get; private set; }
    }
}
#pragma warning restore 1591
