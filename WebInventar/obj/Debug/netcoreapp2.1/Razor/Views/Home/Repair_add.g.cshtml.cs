#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4349e61a89a1df365032d70512777de313959b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Repair_add), @"mvc.1.0.view", @"/Views/Home/Repair_add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Repair_add.cshtml", typeof(AspNetCore.Views_Home_Repair_add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4349e61a89a1df365032d70512777de313959b4", @"/Views/Home/Repair_add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Repair_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Repair>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
  
    ViewBag.Title = "Repair";
    Layout = "_Layout_diag";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(119, 1260, true);
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
                WriteLiteral(" </script>\r\n    <script>\r\n        $(function () {\r\n            $(\"#Data_detect\").datepicker();\r\n        });\r\n    </script>\r\n    <script>\r\n        $(function () {\r\n            $(\"#Data_repair\").datepicker();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1382, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(1538, 67, false);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 237, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                Добавление комплектующих\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\" row\">\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1842, "\"", 1888, 4);
            WriteAttributeValue("", 1850, "Всего", 1850, 5, true);
            WriteAttributeValue(" ", 1855, "компьютеров", 1856, 12, true);
            WriteAttributeValue(" ", 1867, "-", 1868, 2, true);
#line 53 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
WriteAttributeValue(" ", 1869, ViewBag.compcount, 1870, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1889, 118, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего компьютеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2008, 17, false);
#line 56 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2155, "\"", 2199, 4);
            WriteAttributeValue("", 2163, "Всего", 2163, 5, true);
            WriteAttributeValue(" ", 2168, "ноутбуков", 2169, 10, true);
            WriteAttributeValue(" ", 2178, "-", 2179, 2, true);
#line 61 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
WriteAttributeValue(" ", 2180, ViewBag.noutcount, 2181, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2200, 116, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего ноутбуков</div>\r\n                <div>");
            EndContext();
            BeginContext(2317, 17, false);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(2334, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2464, "\"", 2511, 4);
            WriteAttributeValue("", 2472, "Всего", 2472, 5, true);
            WriteAttributeValue(" ", 2477, "принтеров", 2478, 10, true);
            WriteAttributeValue(" ", 2487, "-", 2488, 2, true);
#line 69 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
WriteAttributeValue(" ", 2489, ViewBag.printercount, 2490, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2512, 115, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                <div>Всего принтеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2628, 20, false);
#line 72 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(2648, 261, true);
            WriteLiteral(@"</div>
            </a>
        </div>

        <div class=""col-md-3 col-sm-3 col-xs-6"">
            <a data-toggle=""tooltip"" title=""12 new messages."" class=""well top-block"" href=""#"">

                <div>Всего комплектующих</div>
                <div>");
            EndContext();
            BeginContext(2910, 22, false);
#line 80 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(2932, 344, true);
            WriteLiteral(@"</div>
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Добавление комплектующих</h2>
                </div>
                <div class=""box-content"">
");
            EndContext();
#line 91 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
            BeginContext(3346, 137, true);
            WriteLiteral("                    <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                        ");
            EndContext();
            BeginContext(3484, 24, false);
#line 94 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(3508, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3535, 25, false);
#line 95 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3560, 208, true);
            WriteLiteral("\r\n                        <tr>\r\n                            <td>\r\n                                Кабинет\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3769, 64, false);
#line 101 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.DropDownListFor(m => m.Cab, ViewBag.Cabinets as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3833, 282, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Тип устройства:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4116, 66, false);
#line 109 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.DropDownListFor(m => m.Device, ViewBag.Devices as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4182, 291, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Наименование устройства:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4474, 34, false);
#line 117 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.EditorFor(m => m.Name_repair));

#line default
#line hidden
            EndContext();
            BeginContext(4508, 283, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Причина поломки:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(4792, 29, false);
#line 125 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.EditorFor(m => m.Damage));

#line default
#line hidden
            EndContext();
            BeginContext(4821, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Описание ремонта:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(5106, 33, false);
#line 133 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.EditorFor(m => m.Repair_def));

#line default
#line hidden
            EndContext();
            BeginContext(5139, 285, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Результат ремонта:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(5425, 65, false);
#line 141 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.DropDownListFor(m => m.Result, ViewBag.Result as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5490, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Описание дефекта:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(5775, 29, false);
#line 149 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.EditorFor(m => m.Ground));

#line default
#line hidden
            EndContext();
            BeginContext(5804, 284, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ФИО программиста:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6089, 63, false);
#line 157 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.DropDownListFor(m => m.FIO, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6152, 280, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Дата поломки:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6433, 35, false);
#line 165 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.TextBoxFor(m => m.Data_detect));

#line default
#line hidden
            EndContext();
            BeginContext(6468, 280, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Дата ремонта:
                            </td>
                            <td>
                                ");
            EndContext();
            BeginContext(6749, 35, false);
#line 173 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                           Write(Html.TextBoxFor(m => m.Data_repair));

#line default
#line hidden
            EndContext();
            BeginContext(6784, 195, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n                        <p><input type=\"submit\" value=\"Добавить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 178 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Repair_add.cshtml"
                    }

#line default
#line hidden
            BeginContext(7002, 101, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Repair> Html { get; private set; }
    }
}
#pragma warning restore 1591
