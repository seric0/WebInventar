#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d8a4177f71a1aeffc6531906337aa516d91124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Serveradd), @"mvc.1.0.view", @"/Views/Home/Serveradd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Serveradd.cshtml", typeof(AspNetCore.Views_Home_Serveradd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d8a4177f71a1aeffc6531906337aa516d91124", @"/Views/Home/Serveradd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Serveradd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Server>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
  
    ViewBag.Title = "Server";
    Layout = "_Layout_inv";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(118, 1141, true);
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
                WriteLiteral(" </script>\r\n    <script>\r\n        $(function () {\r\n            $(\"#Data\").datepicker();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1262, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(1418, 67, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 219, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                Сервер\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\" row\">\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1704, "\"", 1750, 4);
            WriteAttributeValue("", 1712, "Всего", 1712, 5, true);
            WriteAttributeValue(" ", 1717, "компьютеров", 1718, 12, true);
            WriteAttributeValue(" ", 1729, "-", 1730, 2, true);
#line 48 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
WriteAttributeValue(" ", 1731, ViewBag.compcount, 1732, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 118, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего компьютеров</div>\r\n                <div>");
            EndContext();
            BeginContext(1870, 17, false);
#line 51 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2017, "\"", 2061, 4);
            WriteAttributeValue("", 2025, "Всего", 2025, 5, true);
            WriteAttributeValue(" ", 2030, "ноутбуков", 2031, 10, true);
            WriteAttributeValue(" ", 2040, "-", 2041, 2, true);
#line 56 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
WriteAttributeValue(" ", 2042, ViewBag.noutcount, 2043, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2062, 116, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего ноутбуков</div>\r\n                <div>");
            EndContext();
            BeginContext(2179, 17, false);
#line 59 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(2196, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2326, "\"", 2373, 4);
            WriteAttributeValue("", 2334, "Всего", 2334, 5, true);
            WriteAttributeValue(" ", 2339, "принтеров", 2340, 10, true);
            WriteAttributeValue(" ", 2349, "-", 2350, 2, true);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
WriteAttributeValue(" ", 2351, ViewBag.printercount, 2352, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2374, 115, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                <div>Всего принтеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2490, 20, false);
#line 67 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(2510, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2640, "\"", 2693, 4);
            WriteAttributeValue("", 2648, "Всего", 2648, 5, true);
            WriteAttributeValue(" ", 2653, "комплектующих", 2654, 14, true);
            WriteAttributeValue(" ", 2667, "-", 2668, 2, true);
#line 72 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
WriteAttributeValue(" ", 2669, ViewBag.componentcount, 2670, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2694, 120, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                <div>Всего комплектующих</div>\r\n                <div>");
            EndContext();
            BeginContext(2815, 22, false);
#line 75 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(2837, 326, true);
            WriteLiteral(@"</div>
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Сервер</h2>
                </div>
                <div class=""box-content"">
");
            EndContext();
#line 86 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
            BeginContext(3233, 137, true);
            WriteLiteral("                    <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                        ");
            EndContext();
            BeginContext(3371, 24, false);
#line 89 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(3395, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3422, 31, false);
#line 90 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                   Write(Html.HiddenFor(m => m.ServerID));

#line default
#line hidden
            EndContext();
            BeginContext(3453, 221, true);
            WriteLiteral("\r\n                        <tr>\r\n                            <td>\r\n                                Наименование сервера\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3675, 75, false);
#line 96 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Name_server, ViewBag.Server_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3750, 277, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Отделение:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4028, 70, false);
#line 104 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Departament, ViewBag.Otdels as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4098, 285, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Серверная комната:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4384, 71, false);
#line 112 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Room_id, ViewBag.Server_room as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4455, 286, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ФИО администратора:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4742, 69, false);
#line 120 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.FIO_admin, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4811, 275, true);
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
            BeginContext(5087, 28, false);
#line 128 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5115, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ФИО ответ.лица:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(5398, 69, false);
#line 136 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.FIO_otvet, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5467, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Серийный номер:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(5750, 32, false);
#line 144 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Server_sn));

#line default
#line hidden
            EndContext();
            BeginContext(5782, 285, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Инвентарный номер:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6068, 33, false);
#line 152 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Server_inv));

#line default
#line hidden
            EndContext();
            BeginContext(6101, 290, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Количество процессоров:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6392, 30, false);
#line 160 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Cpu_col));

#line default
#line hidden
            EndContext();
            BeginContext(6422, 285, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Количество дисков:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6708, 30, false);
#line 168 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Hdd_col));

#line default
#line hidden
            EndContext();
            BeginContext(6738, 280, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип стримера:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(7019, 74, false);
#line 176 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Strimer, ViewBag.Server_strimer as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(7093, 273, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Видео:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(7367, 70, false);
#line 184 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Video, ViewBag.Server_video as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(7437, 291, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Количество сетевых карт:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(7729, 76, false);
#line 192 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Ethernet, ViewBag.Server_ethernet as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(7805, 289, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Скорость сетевых карт:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(8095, 34, false);
#line 200 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Ethernet_sp));

#line default
#line hidden
            EndContext();
            BeginContext(8129, 292, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Монитор (серийный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(8422, 32, false);
#line 208 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Mon_bl_sn));

#line default
#line hidden
            EndContext();
            BeginContext(8454, 295, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Монитор (инвентарный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(8750, 33, false);
#line 216 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Mon_bl_inv));

#line default
#line hidden
            EndContext();
            BeginContext(8783, 292, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Принтер (серийный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(9076, 33, false);
#line 224 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Printer_sn));

#line default
#line hidden
            EndContext();
            BeginContext(9109, 295, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Принтер (инвентарный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(9405, 34, false);
#line 232 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Printer_inv));

#line default
#line hidden
            EndContext();
            BeginContext(9439, 315, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Иточник бесперебойного питания (серийный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(9755, 29, false);
#line 240 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Ibp_sn));

#line default
#line hidden
            EndContext();
            BeginContext(9784, 318, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Иточник бесперебойного питания (инвентарный номер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(10103, 30, false);
#line 248 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.EditorFor(m => m.Ibp_inv));

#line default
#line hidden
            EndContext();
            BeginContext(10133, 280, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ФИО мат.лица:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(10414, 67, false);
#line 256 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Fio_mat, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(10481, 294, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ФИО руководителя отделения:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(10776, 69, false);
#line 264 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Rukov_dep, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(10845, 289, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Дата поставки сервера:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(11135, 28, false);
#line 272 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.TextBoxFor(m => m.Data));

#line default
#line hidden
            EndContext();
            BeginContext(11163, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Модель сервера:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(11446, 73, false);
#line 280 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Model_id, ViewBag.Server_model as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(11519, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип процессора:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(11802, 74, false);
#line 288 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Cpu_type_id, ViewBag.Server_cpu as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(11876, 286, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Частота процессора:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(12163, 69, false);
#line 296 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Cpu_ch_id, ViewBag.Proc_ch as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(12232, 285, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип жеского диска:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(12518, 79, false);
#line 304 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Hdd_type_id, ViewBag.Server_hdd_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(12597, 287, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Объем жеского диска:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(12885, 68, false);
#line 312 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Hdd_ob_id, ViewBag.Hdd_ob as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(12953, 287, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Наличие DVD-привода:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(13241, 69, false);
#line 320 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Dvd_id, ViewBag.Server_dvd as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(13310, 283, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип DVD-привода:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(13594, 79, false);
#line 328 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Dvd_type_id, ViewBag.Server_dvd_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(13673, 295, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Скорость чтения DVD-привода:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(13969, 75, false);
#line 336 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Dvd_sp_id, ViewBag.Server_dvd_sp as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(14044, 292, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Объем оперативной памяти:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(14337, 65, false);
#line 344 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Ram_id, ViewBag.Ram_ob as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(14402, 288, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Наличие звукой карты:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(14691, 73, false);
#line 352 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Sound_id, ViewBag.Server_sound as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(14764, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип видеокарты:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(15047, 83, false);
#line 360 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Video_type_id, ViewBag.Server_video_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(15130, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Монитор (модель):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(15415, 81, false);
#line 368 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Monitor_model_id, ViewBag.Monitor_name as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(15496, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Монитор (размер):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(15781, 73, false);
#line 376 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Mtype_id, ViewBag.Monitor_size as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(15854, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Принтер (модель):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(16139, 81, false);
#line 384 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Printer_model_id, ViewBag.Printer_name as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(16220, 307, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Иточник бесперебойного питания (модель):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(16528, 69, false);
#line 392 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Ibp_model_id, ViewBag.Ibps as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(16597, 296, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Клавиатура (тип подключения):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(16894, 74, false);
#line 400 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Keyboard_id, ViewBag.Input_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(16968, 290, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Мышь (тип подключения):
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(17259, 71, false);
#line 408 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                           Write(Html.DropDownListFor(m => m.Mouse_id, ViewBag.Input_type as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(17330, 194, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n                        <p><input type=\"submit\" value=\"Добаить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 413 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Serveradd.cshtml"
                    }

#line default
#line hidden
            BeginContext(17547, 101, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Server> Html { get; private set; }
    }
}
#pragma warning restore 1591
