#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30262e128aa88d4bed6f94aa10061d8e2616c83f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Component_type), @"mvc.1.0.view", @"/Views/Home/Component_type.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Component_type.cshtml", typeof(AspNetCore.Views_Home_Component_type))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30262e128aa88d4bed6f94aa10061d8e2616c83f", @"/Views/Home/Component_type.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Component_type : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Component_type>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
  
    ViewBag.Title = "Component_type";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(130, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(310, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(377, 267, true);
            WriteLiteral(@"
                </li>
                <li>
                    Комплектующие(Тип)
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 644, "\"", 690, 4);
            WriteAttributeValue("", 652, "Всего", 652, 5, true);
            WriteAttributeValue(" ", 657, "компьютеров", 658, 12, true);
            WriteAttributeValue(" ", 669, "-", 670, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
WriteAttributeValue(" ", 671, ViewBag.compcount, 672, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(818, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(835, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 981, "\"", 1025, 4);
            WriteAttributeValue("", 989, "Всего", 989, 5, true);
            WriteAttributeValue(" ", 994, "ноутбуков", 995, 10, true);
            WriteAttributeValue(" ", 1004, "-", 1005, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
WriteAttributeValue(" ", 1006, ViewBag.noutcount, 1007, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1151, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1314, "\"", 1361, 4);
            WriteAttributeValue("", 1322, "Всего", 1322, 5, true);
            WriteAttributeValue(" ", 1327, "принтеров", 1328, 10, true);
            WriteAttributeValue(" ", 1337, "-", 1338, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
WriteAttributeValue(" ", 1339, ViewBag.printercount, 1340, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1362, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1486, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1506, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1652, "\"", 1705, 4);
            WriteAttributeValue("", 1660, "Всего", 1660, 5, true);
            WriteAttributeValue(" ", 1665, "комплектующих", 1666, 14, true);
            WriteAttributeValue(" ", 1679, "-", 1680, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
WriteAttributeValue(" ", 1681, ViewBag.componentcount, 1682, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1706, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1835, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1857, 419, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Комплектующие (Тип)</h2>
                    </div>
                    <div class=""box-content"">
                        Всего записей - ");
            EndContext();
            BeginContext(2277, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                                   Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2290, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2347, 84, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                   Write(Html.ActionLink("Добавить", "Component_type_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2431, 452, true);
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
#line 70 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(2977, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3064, 6, false);
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                                       Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3070, 326, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center""></td>
                                    </tr>
");
            EndContext();
#line 79 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Component_type.cshtml"
                                }

#line default
#line hidden
            BeginContext(3431, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Component_type>> Html { get; private set; }
    }
}
#pragma warning restore 1591
