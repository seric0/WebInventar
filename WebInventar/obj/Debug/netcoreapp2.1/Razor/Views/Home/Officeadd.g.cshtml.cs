#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42c3fd43acf251fdafa09acbbdf43d599f39c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Officeadd), @"mvc.1.0.view", @"/Views/Home/Officeadd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Officeadd.cshtml", typeof(AspNetCore.Views_Home_Officeadd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42c3fd43acf251fdafa09acbbdf43d599f39c0f", @"/Views/Home/Officeadd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Officeadd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Office>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
  
    ViewBag.Title = "Office";
    Layout = "_Layout_spr";

#line default
#line hidden
            BeginContext(101, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(281, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(348, 253, true);
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    Офис\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\" row\">\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 601, "\"", 647, 4);
            WriteAttributeValue("", 609, "Всего", 609, 5, true);
            WriteAttributeValue(" ", 614, "компьютеров", 615, 12, true);
            WriteAttributeValue(" ", 626, "-", 627, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
WriteAttributeValue(" ", 628, ViewBag.compcount, 629, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(648, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(775, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(792, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 938, "\"", 982, 4);
            WriteAttributeValue("", 946, "Всего", 946, 5, true);
            WriteAttributeValue(" ", 951, "ноутбуков", 952, 10, true);
            WriteAttributeValue(" ", 961, "-", 962, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
WriteAttributeValue(" ", 963, ViewBag.noutcount, 964, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(983, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1108, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1125, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1271, "\"", 1318, 4);
            WriteAttributeValue("", 1279, "Всего", 1279, 5, true);
            WriteAttributeValue(" ", 1284, "принтеров", 1285, 10, true);
            WriteAttributeValue(" ", 1294, "-", 1295, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
WriteAttributeValue(" ", 1296, ViewBag.printercount, 1297, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1319, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1443, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1609, "\"", 1662, 4);
            WriteAttributeValue("", 1617, "Всего", 1617, 5, true);
            WriteAttributeValue(" ", 1622, "комплектующих", 1623, 14, true);
            WriteAttributeValue(" ", 1636, "-", 1637, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
WriteAttributeValue(" ", 1638, ViewBag.componentcount, 1639, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1663, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1792, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 390, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Программное обеспечение (Офис)</h2>
                    </div>
                    <div class=""box-content"">
");
            EndContext();
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
            BeginContext(2282, 153, true);
            WriteLiteral("                            <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                                ");
            EndContext();
            BeginContext(2436, 24, false);
#line 61 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(2460, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2495, 25, false);
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 253, true);
            WriteLiteral("\r\n                                <tr>\r\n                                    <td>\r\n                                        ФИО:\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2774, 27, false);
#line 68 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                                   Write(Html.EditorFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 222, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                            <p><input type=\"submit\" value=\"Добаить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Officeadd.cshtml"
                        }

#line default
#line hidden
            BeginContext(3050, 121, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Office> Html { get; private set; }
    }
}
#pragma warning restore 1591