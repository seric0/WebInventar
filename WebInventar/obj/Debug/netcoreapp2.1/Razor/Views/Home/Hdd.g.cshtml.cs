#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15fe177f29403ab8cb2aaa9fe2a47d42ba6e92f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hdd), @"mvc.1.0.view", @"/Views/Home/Hdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Hdd.cshtml", typeof(AspNetCore.Views_Home_Hdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15fe177f29403ab8cb2aaa9fe2a47d42ba6e92f", @"/Views/Home/Hdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Hdd_ob>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
  
    ViewBag.Title = "HDD";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(111, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(291, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(358, 261, true);
            WriteLiteral(@"
                </li>
                <li>
                    Жесткий диск
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 619, "\"", 665, 4);
            WriteAttributeValue("", 627, "Всего", 627, 5, true);
            WriteAttributeValue(" ", 632, "компьютеров", 633, 12, true);
            WriteAttributeValue(" ", 644, "-", 645, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
WriteAttributeValue(" ", 646, ViewBag.compcount, 647, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(666, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(793, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(810, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 956, "\"", 1000, 4);
            WriteAttributeValue("", 964, "Всего", 964, 5, true);
            WriteAttributeValue(" ", 969, "ноутбуков", 970, 10, true);
            WriteAttributeValue(" ", 979, "-", 980, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
WriteAttributeValue(" ", 981, ViewBag.noutcount, 982, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1001, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1126, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1289, "\"", 1336, 4);
            WriteAttributeValue("", 1297, "Всего", 1297, 5, true);
            WriteAttributeValue(" ", 1302, "принтеров", 1303, 10, true);
            WriteAttributeValue(" ", 1312, "-", 1313, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
WriteAttributeValue(" ", 1314, ViewBag.printercount, 1315, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1337, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1461, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1481, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1627, "\"", 1680, 4);
            WriteAttributeValue("", 1635, "Всего", 1635, 5, true);
            WriteAttributeValue(" ", 1640, "комплектующих", 1641, 14, true);
            WriteAttributeValue(" ", 1654, "-", 1655, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
WriteAttributeValue(" ", 1656, ViewBag.componentcount, 1657, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1681, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1810, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 420, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Жесткий диск (Объем)</h2>
                    </div>
                    <div class=""box-content"">
                        Всего записей - ");
            EndContext();
            BeginContext(2253, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                                   Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2266, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2323, 72, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                   Write(Html.ActionLink("Добавить", "HDDadd", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 452, true);
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
#line 70 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(2941, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3028, 6, false);
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                                       Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3034, 326, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center""></td>
                                    </tr>
");
            EndContext();
#line 79 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Hdd.cshtml"
                                }

#line default
#line hidden
            BeginContext(3395, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Hdd_ob>> Html { get; private set; }
    }
}
#pragma warning restore 1591
