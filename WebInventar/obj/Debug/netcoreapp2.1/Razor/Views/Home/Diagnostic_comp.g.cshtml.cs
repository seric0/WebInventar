#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbacb4390d9d75c1363115d5d41d3422d7c864db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Diagnostic_comp), @"mvc.1.0.view", @"/Views/Home/Diagnostic_comp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Diagnostic_comp.cshtml", typeof(AspNetCore.Views_Home_Diagnostic_comp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbacb4390d9d75c1363115d5d41d3422d7c864db", @"/Views/Home/Diagnostic_comp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Diagnostic_comp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Diagnostic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
  
    ViewBag.Title = "Diagnostic";
    Layout = "_Layout_diag";

#line default
#line hidden
            BeginContext(153, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(309, 67, false);
#line 12 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(376, 469, true);
            WriteLiteral(@"
            </li>
            <li>
                <a href=""#"">Диагностика</a>
            </li>
        </ul>
    </div>

    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Диагностика</h2>
                </div>
                <div class=""box-content"">                                        
                    ");
            EndContext();
            BeginContext(846, 79, false);
#line 27 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
               Write(Html.ActionLink("Добавить", "Diagnosticadd", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(925, 28, true);
            WriteLiteral("\r\n                    <br>\r\n");
            EndContext();
#line 29 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                     using (Html.BeginForm("Diagnostic_comp", "Home", FormMethod.Get))
                    {

#line default
#line hidden
            BeginContext(1064, 56, true);
            WriteLiteral("                        <input type=\"text\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1120, "\"", 1143, 1);
#line 31 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
WriteAttributeValue("", 1128, ViewBag.search, 1128, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1144, 193, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"поиск\" />\r\n                        <br>\r\n                        <input type=\"submit\" value=\"Поиск\" class=\"btn btn-default\" />\r\n                        <br>\r\n");
            EndContext();
#line 35 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                    }

#line default
#line hidden
            BeginContext(1360, 655, true);
            WriteLiteral(@"                    <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                        <thead>
                            <tr>
                                <th>Название организации</th>
                                <th>Кабинет</th>
                                <th>Диагностические мероприятия</th>                                
                                <th>Заключение</th>
                                <th>ФИО техника</th>
                                <th>Действия</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 48 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                             foreach (var b in Model)
                            {

#line default
#line hidden
            BeginContext(2101, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2180, 23, false);
#line 51 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                   Write(b.Organization.Name_org);

#line default
#line hidden
            EndContext();
            BeginContext(2203, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(2266, 17, false);
#line 52 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                                  Write(b.Name_d_spr.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2283, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(2346, 14, false);
#line 53 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                                  Write(b.Cabinet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2360, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(2423, 19, false);
#line 54 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                                  Write(b.Reason_p_spr.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2442, 98, true);
            WriteLiteral("</td>                                    \r\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(2541, 13, false);
#line 55 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                                  Write(b.Worker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2554, 337, true);
            WriteLiteral(@"</td>
                                    <td class=""center"">
                                        <span class=""label-success label label-default"">1</span>
                                    </td>
                                    <td class=""center"">                                      
                                     ");
            EndContext();
            BeginContext(2892, 116, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                                Write(Html.ActionLink("Редактировать", "Diagnosticedit", new { ID = @b.Diagnostic_c.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(3008, 43, true);
            WriteLiteral("  \r\n                                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Diagnostic_comp.cshtml"
                            }

#line default
#line hidden
            BeginContext(3082, 167, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Diagnostic>> Html { get; private set; }
    }
}
#pragma warning restore 1591