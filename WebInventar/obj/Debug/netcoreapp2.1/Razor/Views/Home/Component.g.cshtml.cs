#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad9a3c29319fd0b499ed946ca965be5256f9c41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Component), @"mvc.1.0.view", @"/Views/Home/Component.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Component.cshtml", typeof(AspNetCore.Views_Home_Component))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad9a3c29319fd0b499ed946ca965be5256f9c41", @"/Views/Home/Component.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Component : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Componentwithelement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
  
    ViewBag.Title = "Component";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(131, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(311, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(378, 262, true);
            WriteLiteral(@"
                </li>
                <li>
                    Комплектующие
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 640, "\"", 686, 4);
            WriteAttributeValue("", 648, "Всего", 648, 5, true);
            WriteAttributeValue(" ", 653, "компьютеров", 654, 12, true);
            WriteAttributeValue(" ", 665, "-", 666, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
WriteAttributeValue(" ", 667, ViewBag.compcount, 668, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(687, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(814, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(831, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 977, "\"", 1021, 4);
            WriteAttributeValue("", 985, "Всего", 985, 5, true);
            WriteAttributeValue(" ", 990, "ноутбуков", 991, 10, true);
            WriteAttributeValue(" ", 1000, "-", 1001, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
WriteAttributeValue(" ", 1002, ViewBag.noutcount, 1003, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1022, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1147, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1310, "\"", 1357, 4);
            WriteAttributeValue("", 1318, "Всего", 1318, 5, true);
            WriteAttributeValue(" ", 1323, "принтеров", 1324, 10, true);
            WriteAttributeValue(" ", 1333, "-", 1334, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
WriteAttributeValue(" ", 1335, ViewBag.printercount, 1336, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1358, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1482, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1502, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1648, "\"", 1701, 4);
            WriteAttributeValue("", 1656, "Всего", 1656, 5, true);
            WriteAttributeValue(" ", 1661, "комплектующих", 1662, 14, true);
            WriteAttributeValue(" ", 1675, "-", 1676, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
WriteAttributeValue(" ", 1677, ViewBag.componentcount, 1678, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1831, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 419, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Комплектующие</h2>
                    </div>
                    <div class=""box-content"">
                        Всего Комплектующих - ");
            EndContext();
            BeginContext(2273, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                         Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2286, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2343, 79, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                   Write(Html.ActionLink("Добавить", "Component_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 32, true);
            WriteLiteral("\r\n                        <br>\r\n");
            EndContext();
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                         using (Html.BeginForm("Component", "Home", FormMethod.Get))
                        {

#line default
#line hidden
            BeginContext(2567, 60, true);
            WriteLiteral("                            <input type=\"text\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2627, "\"", 2650, 1);
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
WriteAttributeValue("", 2635, ViewBag.search, 2635, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2651, 205, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"поиск\" />\r\n                            <br>\r\n                            <input type=\"submit\" value=\"Поиск\" class=\"btn btn-default\" />\r\n                            <br>\r\n");
            EndContext();
#line 68 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                        }

#line default
#line hidden
            BeginContext(2883, 638, true);
            WriteLiteral(@"                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Наименование</th>
                                    <th>Кабинет</th>
                                    <th>Количество</th>
                                    <th>Расход</th>
                                    <th>Остаток</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 81 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(3615, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3702, 21, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                       Write(b.Component.Hard_name);

#line default
#line hidden
            EndContext();
            BeginContext(3723, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3790, 14, false);
#line 85 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                                      Write(b.Cabinet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3804, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3871, 15, false);
#line 86 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                                      Write(b.Component.Col);

#line default
#line hidden
            EndContext();
            BeginContext(3886, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3953, 19, false);
#line 87 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                                      Write(b.Component.Expense);

#line default
#line hidden
            EndContext();
            BeginContext(3972, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4039, 19, false);
#line 88 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                                      Write(b.Component.Residue);

#line default
#line hidden
            EndContext();
            BeginContext(4058, 324, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">123</span>
                                        </td>
                                        <td class=""center"">
                                            ");
            EndContext();
            BeginContext(4383, 123, false);
#line 93 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                       Write(Html.ActionLink("Редактировать", "Component_edit", new { ID = @b.Component.ComponentiId }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(4506, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 96 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component.cshtml"
                                }

#line default
#line hidden
            BeginContext(4633, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Componentwithelement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
