#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729c19eb075c313b91096369970c93d281b882d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Networks), @"mvc.1.0.view", @"/Views/Home/Networks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Networks.cshtml", typeof(AspNetCore.Views_Home_Networks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729c19eb075c313b91096369970c93d281b882d4", @"/Views/Home/Networks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Networks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Nets>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
  
    ViewBag.Title = "Network";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(113, 179, true);
            WriteLiteral("    <div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n        <!-- content starts -->\r\n        <div>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(293, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
               Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(360, 269, true);
            WriteLiteral(@"
                </li>
                <li>
                    Сетевое оборудование
                </li>
            </ul>
        </div>
        <div class="" row"">
            <div class=""col-md-3 col-sm-3 col-xs-6"">
                <a data-toggle=""tooltip""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 629, "\"", 675, 4);
            WriteAttributeValue("", 637, "Всего", 637, 5, true);
            WriteAttributeValue(" ", 642, "компьютеров", 643, 12, true);
            WriteAttributeValue(" ", 654, "-", 655, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
WriteAttributeValue(" ", 656, ViewBag.compcount, 657, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(676, 126, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего компьютеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(803, 17, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                    Write(ViewBag.compcount);

#line default
#line hidden
            EndContext();
            BeginContext(820, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 966, "\"", 1010, 4);
            WriteAttributeValue("", 974, "Всего", 974, 5, true);
            WriteAttributeValue(" ", 979, "ноутбуков", 980, 10, true);
            WriteAttributeValue(" ", 989, "-", 990, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
WriteAttributeValue(" ", 991, ViewBag.noutcount, 992, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1011, 124, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                    <div>Всего ноутбуков</div>\r\n                    <div>");
            EndContext();
            BeginContext(1136, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                    Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1299, "\"", 1346, 4);
            WriteAttributeValue("", 1307, "Всего", 1307, 5, true);
            WriteAttributeValue(" ", 1312, "принтеров", 1313, 10, true);
            WriteAttributeValue(" ", 1322, "-", 1323, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
WriteAttributeValue(" ", 1324, ViewBag.printercount, 1325, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1347, 123, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                    <div>Всего принтеров</div>\r\n                    <div>");
            EndContext();
            BeginContext(1471, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                    Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 146, true);
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n                <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1637, "\"", 1690, 4);
            WriteAttributeValue("", 1645, "Всего", 1645, 5, true);
            WriteAttributeValue(" ", 1650, "комплектующих", 1651, 14, true);
            WriteAttributeValue(" ", 1664, "-", 1665, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
WriteAttributeValue(" ", 1666, ViewBag.componentcount, 1667, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1691, 128, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                    <div>Всего комплектующих</div>\r\n                    <div>");
            EndContext();
            BeginContext(1820, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                    Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 433, true);
            WriteLiteral(@"</div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""box col-md-12"">
                <div class=""box-inner"">
                    <div class=""box-header well"" data-original-title="""">
                        <h2> Список сетевого оборудования</h2>
                    </div>
                    <div class=""box-content"">
                        Всего оборудования - ");
            EndContext();
            BeginContext(2276, 13, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                        Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(2289, 56, true);
            WriteLiteral("\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(2346, 77, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                   Write(Html.ActionLink("Добавить", "Networksadd", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 628, true);
            WriteLiteral(@"
                        <br>
                        <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                            <thead>
                                <tr>
                                    <th>Подразделение</th>
                                    <th>ФИО администратора</th>
                                    <th>Должность</th>
                                    <th>Кабинет</th>
                                    <th>Действия</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 73 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                 foreach (var b in Model)
                                {

#line default
#line hidden
            BeginContext(3145, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3232, 12, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                       Write(b.Otdel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3244, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3311, 13, false);
#line 77 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                                      Write(b.Worker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3324, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3391, 14, false);
#line 78 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                                      Write(b.Network.Dolg);

#line default
#line hidden
            EndContext();
            BeginContext(3405, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3472, 14, false);
#line 79 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                                      Write(b.Cabinet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3486, 322, true);
            WriteLiteral(@"</td>
                                        <td class=""center"">
                                            <span class=""label-success label label-default"">1</span>
                                        </td>
                                        <td class=""center"">
                                            ");
            EndContext();
            BeginContext(3809, 111, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                       Write(Html.ActionLink("Просмотр", "Networksview", new { ID = @b.Network.SetiId }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(3920, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(3967, 113, false);
#line 85 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                       Write(Html.ActionLink("Редактировать", "Networksedit", new { ID = @b.Network.SetiId }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(4080, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 88 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Networks.cshtml"
                                }

#line default
#line hidden
            BeginContext(4207, 193, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Nets>> Html { get; private set; }
    }
}
#pragma warning restore 1591