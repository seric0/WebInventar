#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c39c975f62ac3efac1d1d174cd85b3ddf0742f8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ibp_edit), @"mvc.1.0.view", @"/Views/Home/Ibp_edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Ibp_edit.cshtml", typeof(AspNetCore.Views_Home_Ibp_edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39c975f62ac3efac1d1d174cd85b3ddf0742f8a", @"/Views/Home/Ibp_edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ibp_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Ibp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
  
    ViewBag.Title = "Ibp";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(95, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(275, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(342, 297, true);
            WriteLiteral(@"
                </li>
                <li>
                    <a href=""#"">Источники бесперебойного питания</a>
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 639, "\"", 685, 4);
            WriteAttributeValue("", 647, "Всего", 647, 5, true);
            WriteAttributeValue(" ", 652, "компьютеров", 653, 12, true);
            WriteAttributeValue(" ", 664, "-", 665, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
WriteAttributeValue(" ", 666, ViewBag.compcount, 667, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(813, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(830, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 976, "\"", 1020, 4);
            WriteAttributeValue("", 984, "Всего", 984, 5, true);
            WriteAttributeValue(" ", 989, "ноутбуков", 990, 10, true);
            WriteAttributeValue(" ", 999, "-", 1000, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
WriteAttributeValue(" ", 1001, ViewBag.noutcount, 1002, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1146, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1309, "\"", 1356, 4);
            WriteAttributeValue("", 1317, "Всего", 1317, 5, true);
            WriteAttributeValue(" ", 1322, "принтеров", 1323, 10, true);
            WriteAttributeValue(" ", 1332, "-", 1333, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
WriteAttributeValue(" ", 1334, ViewBag.printercount, 1335, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1357, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1481, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1647, "\"", 1700, 4);
            WriteAttributeValue("", 1655, "Всего", 1655, 5, true);
            WriteAttributeValue(" ", 1660, "комплектующих", 1661, 14, true);
            WriteAttributeValue(" ", 1674, "-", 1675, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
WriteAttributeValue(" ", 1676, ViewBag.componentcount, 1677, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1830, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1852, 392, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Источники бесперебойного питания</h2>
                    </div>
                    <div class=""box-content"">
");
            EndContext();
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
            BeginContext(2322, 153, true);
            WriteLiteral("                            <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                                ");
            EndContext();
            BeginContext(2476, 24, false);
#line 61 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(2500, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2535, 25, false);
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 266, true);
            WriteLiteral(@"
                                <tr>
                                    <td>
                                        Инвентарный номер
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(2827, 31, false);
#line 68 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                                   Write(Html.TextBoxFor(x => x.Ibp_inv));

#line default
#line hidden
            EndContext();
            BeginContext(2858, 344, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Наименование:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(3203, 32, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                                   Write(Html.TextBoxFor(x => x.Ibp_name));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 340, true);
            WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Мощность:
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(3576, 33, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                                   Write(Html.TextBoxFor(x => x.Ibp_power));

#line default
#line hidden
            EndContext();
            BeginContext(3609, 339, true);
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
            BeginContext(3949, 27, false);
#line 92 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                                   Write(Html.TextBoxFor(x => x.Cab));

#line default
#line hidden
            EndContext();
            BeginContext(3976, 223, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                            <p><input type=\"submit\" value=\"Изменить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 97 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Ibp_edit.cshtml"
                        }

#line default
#line hidden
            BeginContext(4226, 121, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Ibp> Html { get; private set; }
    }
}
#pragma warning restore 1591
