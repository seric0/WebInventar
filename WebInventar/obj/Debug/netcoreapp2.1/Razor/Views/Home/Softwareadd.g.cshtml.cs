#pragma checksum "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09679c000648924559ebb8d09fa31ca160a76ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Softwareadd), @"mvc.1.0.view", @"/Views/Home/Softwareadd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Softwareadd.cshtml", typeof(AspNetCore.Views_Home_Softwareadd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09679c000648924559ebb8d09fa31ca160a76ab2", @"/Views/Home/Softwareadd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df416f3b63712f36406227c28b9602596cfb0944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Softwareadd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebInventar.Models.Programm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap-datetimepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
  
    ViewBag.Title = "Programm";
    Layout = "_Layout_inv";

#line default
#line hidden
            BeginContext(105, 155, true);
            WriteLiteral("<div id=\"content\" class=\"col-lg-10 col-sm-10\">\r\n    <!-- content starts -->\r\n    <div>\r\n        <ul class=\"breadcrumb\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(261, 67, false);
#line 11 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
           Write(Html.ActionLink("Главная", "Desktop", new { @class = "ajax-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(328, 389, true);
            WriteLiteral(@"
            </li>
            <li>
                Программы
            </li>
        </ul>
    </div>

    <div class=""row"">
        <div class=""box col-md-12"">
            <div class=""box-inner"">
                <div class=""box-header well"" data-original-title="""">
                    <h2> Программы</h2>
                </div>
                <div class=""box-content"">
");
            EndContext();
#line 26 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                     using (Html.BeginForm("Softwareadd", "Home", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(825, 145, true);
            WriteLiteral("                        <table class=\"table table-striped table-bordered bootstrap-datatable datatable responsive\">\r\n                            ");
            EndContext();
            BeginContext(971, 24, false);
#line 29 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(995, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1026, 29, false);
#line 30 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                       Write(Html.HiddenFor(m => m.ProgID));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 246, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td>\r\n                                    Операционная система:\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1302, 60, false);
#line 36 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Os_id, ViewBag.Os as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 322, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Офисный пакет программ:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(1685, 69, false);
#line 44 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Office_id, ViewBag.Offices as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 322, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Антивирусная программа:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(2077, 72, false);
#line 52 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Antivir_id, ViewBag.Antivirus as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 321, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Графическая программа:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(2471, 70, false);
#line 60 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Grapfic_id, ViewBag.Grafics as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(2541, 307, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Браузер:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(2849, 71, false);
#line 68 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Browser_id, ViewBag.Browsers as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(2920, 330, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Программа для создания архивов:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(3251, 75, false);
#line 76 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Arhivator_id, ViewBag.Arhivators as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 323, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Бухгалтерская программа:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(3650, 75, false);
#line 84 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Buxgalter_id, ViewBag.Buxgalters as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(3725, 311, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Портал Egov:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4037, 64, false);
#line 92 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Egov, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4101, 334, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Амбулаторно-поликлиническая помощь:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4436, 63, false);
#line 100 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.App, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4499, 349, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Информационная система Лекарственного обеспечения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(4849, 64, false);
#line 108 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Islo, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(4913, 315, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    АИС Поликлиника:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5229, 63, false);
#line 116 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Aic, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5292, 332, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Регистр прикрепленного населения:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(5625, 63, false);
#line 124 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Rpn, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(5688, 340, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Электронный регистр стационарных больных:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6029, 64, false);
#line 132 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Ersb, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6093, 319, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Бюро госпитализации:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6413, 62, false);
#line 140 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Bg, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6475, 307, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ИС ДКПН:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6783, 64, false);
#line 148 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Dkpn, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(6847, 328, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Система управления ресурсами:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7176, 63, false);
#line 156 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Sur, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(7239, 348, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Регистр беременных и Женщин фертильного возраста:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7588, 62, false);
#line 164 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Rb, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(7650, 309, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ИС Диабет:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(7960, 66, false);
#line 172 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Diabet, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(8026, 308, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ИС Почка:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(8335, 66, false);
#line 180 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Pochka, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(8401, 346, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Комплексная медицинская информационная система:
                                </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(8748, 64, false);
#line 188 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                               Write(Html.DropDownListFor(m => m.Kmis, ViewBag.Changes as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(8812, 235, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>                            \r\n                        </table>\r\n                        <p><input type=\"submit\" value=\"Добавить\" class=\"btn btn-success\" /></p>\r\n");
            EndContext();
#line 193 "C:\Users\415\source\repos\WebInventar\WebInventar\Views\Home\Softwareadd.cshtml"
                    }

#line default
#line hidden
            BeginContext(9070, 103, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- content ends -->\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(9190, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9196, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faf63182246c45a7b9b75323a1b0b3e9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9247, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9253, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46efa3c40e134075ae94367fe735d6a2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9313, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9319, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf42a6f133c4b3cbc9f0792b0ab1c08", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9391, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9397, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f181e0b479463cbcfadcaab4d52b94", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9461, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9467, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c22e5b3f7124bc7969186a5e818deb7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9546, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebInventar.Models.Programm> Html { get; private set; }
    }
}
#pragma warning restore 1591