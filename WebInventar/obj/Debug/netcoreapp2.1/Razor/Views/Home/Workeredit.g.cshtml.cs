#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d83cb13e722eb94c3f7f9533badfd2aa25267083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Workeredit), @"mvc.1.0.view", @"/Views/Home/Workeredit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Workeredit.cshtml", typeof(AspNetCore.Views_Home_Workeredit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d83cb13e722eb94c3f7f9533badfd2aa25267083", @"/Views/Home/Workeredit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Workeredit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Worker>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
  
    ViewBag.Title = "Worker";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(101, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(281, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(348, 259, true);
            WriteLiteral(@"
                </li>
                <li>
                    Сотрудники
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 607, "\"", 653, 4);
            WriteAttributeValue("", 615, "Всего", 615, 5, true);
            WriteAttributeValue(" ", 620, "компьютеров", 621, 12, true);
            WriteAttributeValue(" ", 632, "-", 633, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
WriteAttributeValue(" ", 634, ViewBag.compcount, 635, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(654, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(781, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(798, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 944, "\"", 988, 4);
            WriteAttributeValue("", 952, "Всего", 952, 5, true);
            WriteAttributeValue(" ", 957, "ноутбуков", 958, 10, true);
            WriteAttributeValue(" ", 967, "-", 968, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
WriteAttributeValue(" ", 969, ViewBag.noutcount, 970, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(989, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1114, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1277, "\"", 1324, 4);
            WriteAttributeValue("", 1285, "Всего", 1285, 5, true);
            WriteAttributeValue(" ", 1290, "принтеров", 1291, 10, true);
            WriteAttributeValue(" ", 1300, "-", 1301, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
WriteAttributeValue(" ", 1302, ViewBag.printercount, 1303, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1325, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1449, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1615, "\"", 1668, 4);
            WriteAttributeValue("", 1623, "Всего", 1623, 5, true);
            WriteAttributeValue(" ", 1628, "комплектующих", 1629, 14, true);
            WriteAttributeValue(" ", 1642, "-", 1643, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
WriteAttributeValue(" ", 1644, ViewBag.componentcount, 1645, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1669, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1798, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1820, 370, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Сотрудники</h2>
                    </div>
                    <div class=""box-content"">
");
            EndContext();
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
            BeginContext(2268, 145, true);
            WriteLiteral("                        <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                            ");
            EndContext();
            BeginContext(2414, 24, false);
#line 61 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(2438, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2469, 25, false);
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2494, 229, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td>\r\n                                    ФИО:\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2724, 27, false);
#line 68 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                               Write(Html.EditorFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 332, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Сотрудник является программистом:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(3084, 36, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                               Write(Html.CheckBoxFor(x => x.Programmist));

#line default
#line hidden
            EndContext();
            BeginContext(3120, 211, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                            <p><input type=\"submit\" value=\"Изменить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 81 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Workeredit.cshtml"
                        }

#line default
#line hidden
            BeginContext(3358, 121, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Worker> Html { get; private set; }
    }
}
#pragma warning restore 1591
