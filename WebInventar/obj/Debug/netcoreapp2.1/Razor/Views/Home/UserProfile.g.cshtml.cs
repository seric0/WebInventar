#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8fe86d4be37a9a0d76dca5c50d7e6302adea59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfile), @"mvc.1.0.view", @"/Views/Home/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserProfile.cshtml", typeof(AspNetCore.Views_Home_UserProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8fe86d4be37a9a0d76dca5c50d7e6302adea59", @"/Views/Home/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
  
    ViewBag.Title = "User";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(106, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(262, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(329, 225, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                Пользователи\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\" row\">\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 554, "\"", 600, 4);
            WriteAttributeValue("", 562, "Всего", 562, 5, true);
            WriteAttributeValue(" ", 567, "компьютеров", 568, 12, true);
            WriteAttributeValue(" ", 579, "-", 580, 2, true);
#line 20 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
WriteAttributeValue(" ", 581, ViewBag.compcount, 582, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(601, 118, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего компьютеров</div>\r\n                <div>");
            EndContext();
            BeginContext(720, 13, false);
#line 23 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(733, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 863, "\"", 907, 4);
            WriteAttributeValue("", 871, "Всего", 871, 5, true);
            WriteAttributeValue(" ", 876, "ноутбуков", 877, 10, true);
            WriteAttributeValue(" ", 886, "-", 887, 2, true);
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
WriteAttributeValue(" ", 888, ViewBag.noutcount, 889, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(908, 116, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Computers\">\r\n\r\n                <div>Всего ноутбуков</div>\r\n                <div>");
            EndContext();
            BeginContext(1025, 17, false);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                Write(ViewBag.noutcount);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1172, "\"", 1219, 4);
            WriteAttributeValue("", 1180, "Всего", 1180, 5, true);
            WriteAttributeValue(" ", 1185, "принтеров", 1186, 10, true);
            WriteAttributeValue(" ", 1195, "-", 1196, 2, true);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
WriteAttributeValue(" ", 1197, ViewBag.printercount, 1198, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1220, 115, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Printers\">\r\n\r\n                <div>Всего принтеров</div>\r\n                <div>");
            EndContext();
            BeginContext(1336, 20, false);
#line 39 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                Write(ViewBag.printercount);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 130, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"col-md-3 col-sm-3 col-xs-6\">\r\n            <a data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1486, "\"", 1539, 4);
            WriteAttributeValue("", 1494, "Всего", 1494, 5, true);
            WriteAttributeValue(" ", 1499, "комплектующих", 1500, 14, true);
            WriteAttributeValue(" ", 1513, "-", 1514, 2, true);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
WriteAttributeValue(" ", 1515, ViewBag.componentcount, 1516, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1540, 120, true);
            WriteLiteral(" class=\"well top-block\" href=\"/Home/Component\">\r\n\r\n                <div>Всего комплектующих</div>\r\n                <div>");
            EndContext();
            BeginContext(1661, 22, false);
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                Write(ViewBag.componentcount);

#line default
#line hidden
            EndContext();
            BeginContext(1683, 372, true);
            WriteLiteral(@"</div>
            </a>
        </div>
    </div>
    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Пользователи</h2>
                </div>
                <div class=""box-content"">                    
                    ");
            EndContext();
            BeginContext(2056, 87, false);
#line 58 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
               Write(Html.ActionLink("Добавить пользователя", "User_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 28, true);
            WriteLiteral("\r\n                    <br>\r\n");
            EndContext();
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                     using (Html.BeginForm("Users", "Home", FormMethod.Get))
                    {

#line default
#line hidden
            BeginContext(2272, 56, true);
            WriteLiteral("                        <input type=\"text\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2328, "\"", 2351, 1);
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
WriteAttributeValue("", 2336, ViewBag.search, 2336, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2352, 193, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"поиск\" />\r\n                        <br>\r\n                        <input type=\"submit\" value=\"Поиск\" class=\"btn btn-default\" />\r\n                        <br>\r\n");
            EndContext();
#line 66 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                    }

#line default
#line hidden
            BeginContext(2568, 569, true);
            WriteLiteral(@"                    <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                        <thead>
                            <tr>
                                <th>Логин</th>
                                <th>ФИО</th>
                                <th>Должность</th>
                                <th>Дата создания</th>                                  
                                <th>Действия</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 78 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                             foreach (var b in Model)
                            {

#line default
#line hidden
            BeginContext(3223, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(3302, 11, false);
#line 81 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                                   Write(b.LoginUser);

#line default
#line hidden
            EndContext();
            BeginContext(3313, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3376, 5, false);
#line 82 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                                                  Write(b.Fio);

#line default
#line hidden
            EndContext();
            BeginContext(3381, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3444, 10, false);
#line 83 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                                                  Write(b.Dolgnost);

#line default
#line hidden
            EndContext();
            BeginContext(3454, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3517, 6, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                                                  Write(b.Data);

#line default
#line hidden
            EndContext();
            BeginContext(3523, 280, true);
            WriteLiteral(@"</td>                                    
                                    <td class=""center"">                                        
                                    </td>
                                    <td class=""center"">
                                        ");
            EndContext();
            BeginContext(3804, 106, false);
#line 88 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                                   Write(Html.ActionLink("Восстановление пароля", "User_edit", new { ID = @b.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(3910, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 91 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\UserProfile.cshtml"
                            }

#line default
#line hidden
            BeginContext(4025, 167, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- content ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
