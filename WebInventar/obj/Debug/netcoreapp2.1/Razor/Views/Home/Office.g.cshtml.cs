#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4fd425c4f093761ed07af4f41018479a49ec70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Office), @"mvc.1.0.view", @"/Views/Home/Office.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Office.cshtml", typeof(AspNetCore.Views_Home_Office))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4fd425c4f093761ed07af4f41018479a49ec70", @"/Views/Home/Office.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Office : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Office>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
  
    ViewBag.Title = "Office";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(114, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(294, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(361, 253, true);
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    Офис\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\" row\">\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 614, "\"", 660, 4);
            WriteAttributeValue("", 622, "Всего", 622, 5, true);
            WriteAttributeValue(" ", 627, "компьютеров", 628, 12, true);
            WriteAttributeValue(" ", 639, "-", 640, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
WriteAttributeValue(" ", 641, ViewBag.compcount, 642, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(661, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(788, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(805, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 951, "\"", 995, 4);
            WriteAttributeValue("", 959, "Всего", 959, 5, true);
            WriteAttributeValue(" ", 964, "ноутбуков", 965, 10, true);
            WriteAttributeValue(" ", 974, "-", 975, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
WriteAttributeValue(" ", 976, ViewBag.noutcount, 977, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(996, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1121, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1284, "\"", 1331, 4);
            WriteAttributeValue("", 1292, "Всего", 1292, 5, true);
            WriteAttributeValue(" ", 1297, "принтеров", 1298, 10, true);
            WriteAttributeValue(" ", 1307, "-", 1308, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
WriteAttributeValue(" ", 1309, ViewBag.printercount, 1310, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1332, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1456, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1476, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1622, "\"", 1675, 4);
            WriteAttributeValue("", 1630, "Всего", 1630, 5, true);
            WriteAttributeValue(" ", 1635, "комплектующих", 1636, 14, true);
            WriteAttributeValue(" ", 1649, "-", 1650, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
WriteAttributeValue(" ", 1651, ViewBag.componentcount, 1652, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1676, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1805, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1827, 438, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Список программного обеспечения (Офис)</h2>
                    </div>
                    <div class=""box-content"">
                        Всего записей - ");
            EndContext();
            BeginContext(2266, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                                   Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2279, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2336, 75, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                   Write(Html.ActionLink("Добавить", "Officeadd", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 452, true);
            WriteLiteral(@"
                        <br>
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Наименование</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 70 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(2957, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3044, 6, false);
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                                       Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3050, 326, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center""></td>
                                    </tr>
");
            EndContext();
#line 79 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Office.cshtml"
                                }

#line default
#line hidden
            BeginContext(3411, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Office>> Html { get; private set; }
    }
}
#pragma warning restore 1591
