#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7071cdbb796aace72b9e92ece8552c762754c791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Organization), @"mvc.1.0.view", @"/Views/Home/Organization.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Organization.cshtml", typeof(AspNetCore.Views_Home_Organization))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7071cdbb796aace72b9e92ece8552c762754c791", @"/Views/Home/Organization.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Organization : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Organization>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
  
    ViewBag.Title = "Organization";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(126, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(306, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(373, 267, true);
            WriteLiteral(@"
                </li>
                <li>
                    Данные организации
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
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
WriteAttributeValue(" ", 667, ViewBag.compcount, 668, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(687, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(814, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
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
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
WriteAttributeValue(" ", 1002, ViewBag.noutcount, 1003, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1022, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1147, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
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
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
WriteAttributeValue(" ", 1335, ViewBag.printercount, 1336, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1358, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1482, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
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
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
WriteAttributeValue(" ", 1677, ViewBag.componentcount, 1678, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1831, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 378, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Данные организации</h2>
                    </div>
                    <div class=""box-content"">
");
            EndContext();
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                         using (Html.BeginForm("Computers", "Home", FormMethod.Get))
                        {

#line default
#line hidden
            BeginContext(2344, 60, true);
            WriteLiteral("                            <input type=\"text\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2404, "\"", 2427, 1);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
WriteAttributeValue("", 2412, ViewBag.search, 2412, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2428, 205, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"поиск\" />\r\n                            <br>\r\n                            <input type=\"submit\" value=\"Поиск\" class=\"btn btn-default\" />\r\n                            <br>\r\n");
            EndContext();
#line 64 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                        }

#line default
#line hidden
            BeginContext(2660, 912, true);
            WriteLiteral(@"                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Наименование</th>
                                    <th>Адрес</th>
                                    <th>ФИО руководителя</th>
                                    <th>Должность руководителя</th>
                                    <th>ФИО заместителя</th>
                                    <th>Должность заместителя</th>
                                    <th>ФИО программиста</th>
                                    <th>Должность</th>
                                    <th>E-mail адрес</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 81 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(3666, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3753, 10, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                       Write(b.Name_org);

#line default
#line hidden
            EndContext();
            BeginContext(3763, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3830, 11, false);
#line 85 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Adres_org);

#line default
#line hidden
            EndContext();
            BeginContext(3841, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3908, 11, false);
#line 86 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Fio_rukov);

#line default
#line hidden
            EndContext();
            BeginContext(3919, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3986, 12, false);
#line 87 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Dolg_rukov);

#line default
#line hidden
            EndContext();
            BeginContext(3998, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4065, 9, false);
#line 88 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Fio_zam);

#line default
#line hidden
            EndContext();
            BeginContext(4074, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4141, 10, false);
#line 89 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Dolg_zam);

#line default
#line hidden
            EndContext();
            BeginContext(4151, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4218, 11, false);
#line 90 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Fio_admin);

#line default
#line hidden
            EndContext();
            BeginContext(4229, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4296, 12, false);
#line 91 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Dolg_admin);

#line default
#line hidden
            EndContext();
            BeginContext(4308, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(4375, 7, false);
#line 92 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                                      Write(b.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4382, 322, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center"">
                                            ");
            EndContext();
            BeginContext(4705, 106, false);
#line 97 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                       Write(Html.ActionLink("Редактировать", "Organization_edit", new { ID = @b.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(4811, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 100 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Organization.cshtml"
                                }

#line default
#line hidden
            BeginContext(4938, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Organization>> Html { get; private set; }
    }
}
#pragma warning restore 1591