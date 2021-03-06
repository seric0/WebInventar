#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de0b2ac7382dfe0412f7507338eeafb24ee25dfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Diagnosticedit), @"mvc.1.0.view", @"/Views/Home/Diagnosticedit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Diagnosticedit.cshtml", typeof(AspNetCore.Views_Home_Diagnosticedit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0b2ac7382dfe0412f7507338eeafb24ee25dfc", @"/Views/Home/Diagnosticedit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Diagnosticedit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Diagnostic_c>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
  
    ViewBag.Title = "Diagnostic";
    Layout = "_Layout_diag";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(129, 1141, true);
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
            BeginContext(1273, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(1429, 67, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 224, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                Диагностика\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\" row\">\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1720, "\"", 1766, 4);
            WriteAttributeValue("", 1728, "Всего", 1728, 5, true);
            WriteAttributeValue(" ", 1733, "компьютеров", 1734, 12, true);
            WriteAttributeValue(" ", 1745, "-", 1746, 2, true);
#line 48 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
WriteAttributeValue(" ", 1747, ViewBag.compcount, 1748, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1767, 118, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего компьютеров</div>\r\n                <div>");
            EndContext();
            BeginContext(1886, 17, false);
#line 51 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2033, "\"", 2077, 4);
            WriteAttributeValue("", 2041, "Всего", 2041, 5, true);
            WriteAttributeValue(" ", 2046, "ноутбуков", 2047, 10, true);
            WriteAttributeValue(" ", 2056, "-", 2057, 2, true);
#line 56 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
WriteAttributeValue(" ", 2058, ViewBag.noutcount, 2059, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2078, 116, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего ноутбуков</div>\r\n                <div>");
            EndContext();
            BeginContext(2195, 17, false);
#line 59 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(2212, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2342, "\"", 2389, 4);
            WriteAttributeValue("", 2350, "Всего", 2350, 5, true);
            WriteAttributeValue(" ", 2355, "принтеров", 2356, 10, true);
            WriteAttributeValue(" ", 2365, "-", 2366, 2, true);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
WriteAttributeValue(" ", 2367, ViewBag.printercount, 2368, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2390, 115, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                <div>Всего принтеров</div>\r\n                <div>");
            EndContext();
            BeginContext(2506, 20, false);
#line 67 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(2526, 261, true);
            WriteLiteral(@"</div>
            </a>
        </div>

        <div class=""col-md-3 col-sm-3 col-xs-6"">
            <a data-toggle=""tooltip"" title=""12 new messages."" class=""well top-block"" href=""#"">

                <div>Всего комплектующих</div>
                <div>");
            EndContext();
            BeginContext(2788, 22, false);
#line 75 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(2810, 331, true);
            WriteLiteral(@"</div>
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Диагностика</h2>
                </div>
                <div class=""box-content"">
");
            EndContext();
#line 86 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
            BeginContext(3211, 145, true);
            WriteLiteral("                        <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                            ");
            EndContext();
            BeginContext(3357, 24, false);
#line 89 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(3381, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3412, 25, false);
#line 90 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3437, 250, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td>\r\n                                    Наименование организации:\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3688, 74, false);
#line 96 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Name_org, ViewBag.Organizations as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3762, 315, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Тип диагностики:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4078, 69, false);
#line 104 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Name_d, ViewBag.Name_d_spr as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4147, 314, true);
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
            BeginContext(4462, 66, false);
#line 112 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Type_d, ViewBag.Devices as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4528, 307, true);
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
            BeginContext(4836, 66, false);
#line 120 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Cab_d, ViewBag.Cabinets as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4902, 319, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Причина диагностики:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5222, 73, false);
#line 128 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Reason_p, ViewBag.Reason_p_spr as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5295, 321, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Результат диагностики:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5617, 73, false);
#line 136 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Reason_r, ViewBag.Reason_r_spr as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5690, 322, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Заключение диагностики:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6013, 35, false);
#line 144 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.EditorFor(x => x.Conclusion_r));

#line default
#line hidden
            EndContext();
            BeginContext(6048, 316, true);
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
            BeginContext(6365, 70, false);
#line 152 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Engineer_r, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6435, 330, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ФИО руководителя подразделения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6766, 70, false);
#line 160 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.DropDownListFor(m => m.Director_r, ViewBag.Workers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6836, 316, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Дата диагностики:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7153, 29, false);
#line 168 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                               Write(Html.EditorFor(x => x.Data_r));

#line default
#line hidden
            EndContext();
            BeginContext(7182, 207, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                        <p><input type=\"submit\" value=\"Изменить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 173 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnosticedit.cshtml"
                    }

#line default
#line hidden
            BeginContext(7412, 101, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Diagnostic_c> Html { get; private set; }
    }
}
#pragma warning restore 1591
