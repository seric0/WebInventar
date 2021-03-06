#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033ac37bfbf0f7f6a4734c0132c22a5e3a853c54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Backup), @"mvc.1.0.view", @"/Views/Home/Backup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Backup.cshtml", typeof(AspNetCore.Views_Home_Backup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033ac37bfbf0f7f6a4734c0132c22a5e3a853c54", @"/Views/Home/Backup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Backup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebInventar.Models.Backups>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
  
    ViewBag.Title = "Backup";
    Layout = "_Layout_diag";

#line default
#line hidden
            BeginContext(116, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(272, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(339, 483, true);
            WriteLiteral(@"
            </li>
            <li>
                <a href=""#"">Резервное копирование и восстановление</a>
            </li>
        </ul>
    </div>

    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Резервное копирование и восстановление</h2>
                </div>
                <div class=""box-content"">
                    ");
            EndContext();
            BeginContext(823, 76, false);
#line 26 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
               Write(Html.ActionLink("Добавить", "Backup_add", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(899, 28, true);
            WriteLiteral("\r\n                    <br>\r\n");
            EndContext();
#line 28 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                     using (Html.BeginForm("Backup", "Home", FormMethod.Get))
                    {

#line default
#line hidden
            BeginContext(1029, 56, true);
            WriteLiteral("                        <input type=\"text\" name=\"search\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1085, "\"", 1108, 1);
#line 30 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
WriteAttributeValue("", 1093, ViewBag.search, 1093, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1109, 193, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"поиск\" />\r\n                        <br>\r\n                        <input type=\"submit\" value=\"Поиск\" class=\"btn btn-default\" />\r\n                        <br>\r\n");
            EndContext();
#line 34 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                    }

#line default
#line hidden
            BeginContext(1325, 768, true);
            WriteLiteral(@"                    <table class=""table table-striped table-bordered bootstrap-datatable datatable responsive"">
                        <thead>
                            <tr>
                                <th>Кабинет</th>
                                <th>Тип (Копирование/Восстановление)</th>
                                <th>Объект копирования/восстановления</th>                                
                                <th>Результат копирования/восстановления</th>
                                <th>Сотрудник выполнявший копирование/восстановление</th>                                
                                <th>Действия</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 47 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                             foreach (var b in Model)
                            {

#line default
#line hidden
            BeginContext(2179, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2250, 14, false);
#line 50 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                               Write(b.Cabinet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2323, 13, false);
#line 51 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                                              Write(b.Type_g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2395, 15, false);
#line 52 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                                              Write(b.Vid_copy.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2410, 90, true);
            WriteLiteral("</td>                                \r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2501, 15, false);
#line 53 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                                              Write(b.Result_g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2575, 13, false);
#line 54 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                                              Write(b.Worker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 349, true);
            WriteLiteral(@"</td>                                
                                <td class=""center"">
                                    <span class=""label-success label label-default"">1</span>
                                </td>
                                <td class=""center"">                                    
                            </tr>
");
            EndContext();
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Backup.cshtml"
                            }

#line default
#line hidden
            BeginContext(2968, 167, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebInventar.Models.Backups>> Html { get; private set; }
    }
}
#pragma warning restore 1591
