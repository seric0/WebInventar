#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d4df8db1ff389ea00d5702a84ccb48bcbdaf80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Proectors), @"mvc.1.0.view", @"/Views/Home/Proectors.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Proectors.cshtml", typeof(AspNetCore.Views_Home_Proectors))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d4df8db1ff389ea00d5702a84ccb48bcbdaf80", @"/Views/Home/Proectors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Proectors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Proector>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
  
    ViewBag.Title = "Proector";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(118, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(298, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(365, 258, true);
            WriteLiteral(@"
                </li>
                <li>
                    Проекторы
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 623, "\"", 667, 4);
            WriteAttributeValue("", 631, "Всего", 631, 5, true);
            WriteAttributeValue(" ", 636, "ноутбуков", 637, 10, true);
            WriteAttributeValue(" ", 646, "-", 647, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
WriteAttributeValue(" ", 648, ViewBag.noutcount, 649, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(668, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(795, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(812, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 958, "\"", 1005, 4);
            WriteAttributeValue("", 966, "Всего", 966, 5, true);
            WriteAttributeValue(" ", 971, "принтеров", 972, 10, true);
            WriteAttributeValue(" ", 981, "-", 982, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
WriteAttributeValue(" ", 983, ViewBag.printercount, 984, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1006, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1130, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1293, "\"", 1346, 4);
            WriteAttributeValue("", 1301, "Всего", 1301, 5, true);
            WriteAttributeValue(" ", 1306, "комплектующих", 1307, 14, true);
            WriteAttributeValue(" ", 1320, "-", 1321, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
WriteAttributeValue(" ", 1322, ViewBag.componentcount, 1323, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1347, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1472, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 285, true);
            WriteLiteral(@"</div>
                </a>
            </div>

            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip"" title=""12 new messages."" class=""well top-block"" href=""#"">

                    <div>Всего комплектующих</div>
                    <div>");
            EndContext();
            BeginContext(1778, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 420, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Список проекторов</h2>
                    </div>
                    <div class=""box-content"">
                        Всего проекторов - ");
            EndContext();
            BeginContext(2221, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                      Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2234, 638, true);
            WriteLiteral(@"
                        <br>
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Инвентарный номер</th>
                                    <th>Кабинет</th>
                                    <th>Наименование</th>
                                    <th>Интерфейс подключения</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 71 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(2966, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3053, 14, false);
#line 74 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                       Write(b.Proector_inv);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3134, 5, false);
#line 75 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                                      Write(b.Cab);

#line default
#line hidden
            EndContext();
            BeginContext(3139, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3206, 15, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                                      Write(b.Proector_name);

#line default
#line hidden
            EndContext();
            BeginContext(3221, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3288, 18, false);
#line 77 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                                      Write(b.Proector_connect);

#line default
#line hidden
            EndContext();
            BeginContext(3306, 326, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center""></td>
                                    </tr>
");
            EndContext();
#line 83 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Proectors.cshtml"
                                }

#line default
#line hidden
            BeginContext(3667, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Proector>> Html { get; private set; }
    }
}
#pragma warning restore 1591
