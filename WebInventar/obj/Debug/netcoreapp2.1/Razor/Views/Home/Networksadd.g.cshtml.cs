#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748d87ca2c1b08d45a6183b7ab04cb0cc984b6ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Networksadd), @"mvc.1.0.view", @"/Views/Home/Networksadd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Networksadd.cshtml", typeof(AspNetCore.Views_Home_Networksadd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748d87ca2c1b08d45a6183b7ab04cb0cc984b6ef", @"/Views/Home/Networksadd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Networksadd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Network>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
  
    ViewBag.Title = "Component";
    Layout = "_Layout_inv";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(122, 1265, true);
                WriteLiteral(@"
    <script>
        /* Локализация datepicker */
        $.datepicker.regional['ru'] = {
            closeText: 'Закрыть',
            prevText: 'Предыдущий',
            nextText: 'Следующий',
            currentText: 'Сегодня',
            monthNames: ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь', 'Декабрь'],
            monthNamesShort: ['Янв', 'Фев', 'Мар', 'Апр', 'Май', 'Июн', 'Июл', 'Авг', 'Сен', 'Окт', 'Ноя', 'Дек'],
            dayNames: ['воскресенье', 'понедельник', 'вторник', 'среда', 'четверг', 'пятница', 'суббота'],
            dayNamesShort: ['вск', 'пнд', 'втр', 'срд', 'чтв', 'птн', 'сбт'],
            dayNamesMin: ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'],
            weekHeader: 'Не',
            dateFormat: 'dd.mm.yy',
            firstDay: 1,
            isRTL: false,
            showMonthAfterYear: false,
            yearSuffix: ''
        };
        $.datepicker.setDefaults($.datepicker.regional['ru']);
   ");
                WriteLiteral(" </script>\r\n    <script>\r\n        $(function () {\r\n            $(\"#Data\").datepicker();\r\n        });              \r\n    </script>\r\n    <script>\r\n        $(function () {\r\n            $(\"#Data2\").datepicker();\r\n            });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1390, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(1546, 67, false);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 233, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                Сетевое оборудование\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\" row\">\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1846, "\"", 1892, 4);
            WriteAttributeValue("", 1854, "Всего", 1854, 5, true);
            WriteAttributeValue(" ", 1859, "компьютеров", 1860, 12, true);
            WriteAttributeValue(" ", 1871, "-", 1872, 2, true);
#line 53 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
WriteAttributeValue(" ", 1873, ViewBag.compcount, 1874, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1893, 118, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего компьютеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2012, 17, false);
#line 56 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2159, "\"", 2203, 4);
            WriteAttributeValue("", 2167, "Всего", 2167, 5, true);
            WriteAttributeValue(" ", 2172, "ноутбуков", 2173, 10, true);
            WriteAttributeValue(" ", 2182, "-", 2183, 2, true);
#line 61 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
WriteAttributeValue(" ", 2184, ViewBag.noutcount, 2185, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2204, 116, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего ноутбуков</div>\r\n                <div>");
            EndContext();
            BeginContext(2321, 17, false);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(2338, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2468, "\"", 2515, 4);
            WriteAttributeValue("", 2476, "Всего", 2476, 5, true);
            WriteAttributeValue(" ", 2481, "принтеров", 2482, 10, true);
            WriteAttributeValue(" ", 2491, "-", 2492, 2, true);
#line 69 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
WriteAttributeValue(" ", 2493, ViewBag.printercount, 2494, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2516, 115, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                <div>Всего принтеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2632, 20, false);
#line 72 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(2652, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2782, "\"", 2835, 4);
            WriteAttributeValue("", 2790, "Всего", 2790, 5, true);
            WriteAttributeValue(" ", 2795, "комплектующих", 2796, 14, true);
            WriteAttributeValue(" ", 2809, "-", 2810, 2, true);
#line 77 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
WriteAttributeValue(" ", 2811, ViewBag.componentcount, 2812, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2836, 120, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                <div>Всего комплектующих</div>\r\n                <div>");
            EndContext();
            BeginContext(2957, 22, false);
#line 80 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(2979, 340, true);
            WriteLiteral(@"</div>
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Сетевое оборудование</h2>
                </div>
                <div class=""box-content"">
");
            EndContext();
#line 91 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                     using (Html.BeginForm("Networksadd", "Home", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(3427, 145, true);
            WriteLiteral("                        <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                            ");
            EndContext();
            BeginContext(3573, 24, false);
#line 94 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(3597, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3628, 29, false);
#line 95 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                       Write(Html.HiddenFor(m => m.SetiId));

#line default
#line hidden
            EndContext();
            BeginContext(3657, 250, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td>\r\n                                    Структурное подразделение\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3908, 66, false);
#line 101 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Str_pod, ViewBag.Otdels as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3974, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4013, 77, false);
#line 102 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Str_pod, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4090, 303, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ФИО:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4394, 63, false);
#line 110 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Fio, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4457, 309, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Должность:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4767, 60, false);
#line 118 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(m => m.Dolg, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4827, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4866, 38, false);
#line 119 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Dolg));

#line default
#line hidden
            EndContext();
            BeginContext(4904, 307, true);
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
            BeginContext(5212, 68, false);
#line 127 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Cabinet, ViewBag.Cabinets as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5280, 307, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Телефон:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5588, 61, false);
#line 135 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(m => m.Phone, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5649, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5688, 39, false);
#line 136 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5727, 314, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Дата установки:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6042, 28, false);
#line 144 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.TextBoxFor(m => m.Data));

#line default
#line hidden
            EndContext();
            BeginContext(6070, 337, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Сетевое оборудование (Серийный номер):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6408, 64, false);
#line 152 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(m => m.Activ_sn, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6472, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6511, 42, false);
#line 153 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Activ_sn));

#line default
#line hidden
            EndContext();
            BeginContext(6553, 340, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Сетевое оборудование (Инвентарный номер):
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6894, 65, false);
#line 161 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(m => m.Activ_inv, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6959, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6998, 43, false);
#line 162 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Activ_inv));

#line default
#line hidden
            EndContext();
            BeginContext(7041, 308, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Описание:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7350, 62, false);
#line 170 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(x => x.Notice, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7412, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(7451, 40, false);
#line 171 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Notice));

#line default
#line hidden
            EndContext();
            BeginContext(7491, 308, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ip адрес:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7800, 58, false);
#line 179 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.EditorFor(m => m.Ip, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7858, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(7897, 36, false);
#line 180 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.ValidationMessageFor(x => x.Ip));

#line default
#line hidden
            EndContext();
            BeginContext(7933, 319, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Площадка размещения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(8253, 70, false);
#line 188 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Platform, ViewBag.Platforms as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(8323, 326, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Руководитель подразделения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(8650, 70, false);
#line 196 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Rukov_podr, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(8720, 332, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Руководитель хозяйственной части:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(9053, 68, false);
#line 204 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Rukov_xc, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(9121, 316, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Паспорт заполнил:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(9438, 67, false);
#line 212 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Pasport, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(9505, 315, true);
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
            BeginContext(9821, 29, false);
#line 220 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.TextBoxFor(m => m.Data2));

#line default
#line hidden
            EndContext();
            BeginContext(9850, 325, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Наименование оборудования:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(10176, 78, false);
#line 228 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Net_nId, ViewBag.Network_hard_names as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(10254, 316, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Тип оборудования:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(10571, 78, false);
#line 236 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Net_tId, ViewBag.Network_hard_types as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(10649, 317, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Количество портов:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(10967, 78, false);
#line 244 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Net_pId, ViewBag.Network_hard_ports as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(11045, 207, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                        <p><input type=\"submit\" value=\"Добавить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 249 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networksadd.cshtml"
                    }

#line default
#line hidden
            BeginContext(11275, 101, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Network> Html { get; private set; }
    }
}
#pragma warning restore 1591
