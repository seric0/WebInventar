#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6334d627db94aab2feabec1aba847dffd7430faa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Risograph), @"mvc.1.0.view", @"/Views/Home/Risograph.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Risograph.cshtml", typeof(AspNetCore.Views_Home_Risograph))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6334d627db94aab2feabec1aba847dffd7430faa", @"/Views/Home/Risograph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Risograph : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Risograph>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
  
    ViewBag.Title = "Computer";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(119, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(299, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(366, 257, true);
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
            BeginWriteAttribute("title", " title=\"", 623, "\"", 669, 4);
            WriteAttributeValue("", 631, "Всего", 631, 5, true);
            WriteAttributeValue(" ", 636, "компьютеров", 637, 12, true);
            WriteAttributeValue(" ", 648, "-", 649, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
WriteAttributeValue(" ", 650, ViewBag.compcount, 651, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(797, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(814, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 960, "\"", 1004, 4);
            WriteAttributeValue("", 968, "Всего", 968, 5, true);
            WriteAttributeValue(" ", 973, "ноутбуков", 974, 10, true);
            WriteAttributeValue(" ", 983, "-", 984, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
WriteAttributeValue(" ", 985, ViewBag.noutcount, 986, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1005, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1130, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1293, "\"", 1340, 4);
            WriteAttributeValue("", 1301, "Всего", 1301, 5, true);
            WriteAttributeValue(" ", 1306, "принтеров", 1307, 10, true);
            WriteAttributeValue(" ", 1316, "-", 1317, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
WriteAttributeValue(" ", 1318, ViewBag.printercount, 1319, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1341, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1465, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1631, "\"", 1684, 4);
            WriteAttributeValue("", 1639, "Всего", 1639, 5, true);
            WriteAttributeValue(" ", 1644, "комплектующих", 1645, 14, true);
            WriteAttributeValue(" ", 1658, "-", 1659, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
WriteAttributeValue(" ", 1660, ViewBag.componentcount, 1661, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1685, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1814, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 420, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Список ризографов</h2>
                    </div>
                    <div class=""box-content"">
                        Всего ризографов - ");
            EndContext();
            BeginContext(2257, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                      Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2270, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2327, 79, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                   Write(Html.ActionLink("Добавить", "Risograph_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 574, true);
            WriteLiteral(@"
                        <br>
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Наименование</th>
                                    <th>Формат печати</th>
                                    <th>Скорость печати</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 72 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(3074, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3161, 11, false);
#line 75 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                       Write(b.Riso_name);

#line default
#line hidden
            EndContext();
            BeginContext(3172, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3239, 11, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                                      Write(b.Riso_type);

#line default
#line hidden
            EndContext();
            BeginContext(3250, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3317, 14, false);
#line 77 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                                      Write(b.Riso_optical);

#line default
#line hidden
            EndContext();
            BeginContext(3331, 322, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center"">
                                            ");
            EndContext();
            BeginContext(3654, 103, false);
#line 82 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                       Write(Html.ActionLink("Редактировать", "Risograph_edit", new { ID = @b.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(3757, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 85 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Risograph.cshtml"
                                }

#line default
#line hidden
            BeginContext(3884, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Risograph>> Html { get; private set; }
    }
}
#pragma warning restore 1591
