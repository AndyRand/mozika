#pragma checksum "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eedc3c116347635d0ff057fc682383e4e588129d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mozika.Web.Pages.Templates.Pages_Templates_Grid), @"mvc.1.0.view", @"/Pages/Templates/Grid.cshtml")]
namespace Mozika.Web.Pages.Templates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/_ViewImports.cshtml"
using Mozika.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eedc3c116347635d0ff057fc682383e4e588129d", @"/Pages/Templates/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbfd86f2964fd3a725c79fe70dba4759f6eedb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Templates_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatars/avatar-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar  rounded-circle avatar-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatars/avatar-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatars/avatar-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/avatars/avatar-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 4 "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/Grid.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex"">
    <nav id=""breadcrumbs"" class=""mb-3"">
        <ul>
            <li><a href=""#""> <i class=""uil-home-alt""></i> </a></li>
            <li><a href=""#""> Instucture </a></li>
            <li>Veiw Instuctures</li>
        </ul>
    </nav>
</div>

<div class=""section-header mb-lg-2 border-0 uk-flex-middle"">
    <div class=""section-header-left"">
        <h2 class=""uk-heading-line text-left""><span> Instuctures </span></h2>
    </div>
    <div class=""section-header-right"">

        <a href=""#"" uk-tooltip=""title: Veiw as list; pos: top-right""");
            BeginWriteAttribute("title", " title=\"", 708, "\"", 716, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">\n            <i class=\"icon-feather-list\"></i>\n        </a>\n        <div class=\"display-as\">\n            <a href=\"#\" class=\"active\"\n               uk-tooltip=\"title: Veiw as Grid; pos: top-right\"");
            BeginWriteAttribute("title", " title=\"", 935, "\"", 943, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-expanded=""false"">
                <i class=""icon-feather-grid""></i>
            </a>
        </div>

        <a href=""#"" class=""btn btn-default uk-visible@s""> <i class=""uil-plus""></i> Add instuctures</a>

    </div>
</div>



<div class=""uk-child-width-1-4@m uk-child-width-1-2@s"" uk-grid
     uk-scrollspy=""cls: uk-animation-slide-bottom-small; target: > div ; delay: 200"">
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d6978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Stella Johnson </h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@john.sullivan</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 13 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d9472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Alex Dolgove</h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@Alex.Dolgove</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 21 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d11962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\">Adrian Mohani</h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@Adrian.Mohani</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 25 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d14454", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Stella Johnson</h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@john.Johnson</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 8 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d16946", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Richard Ali </h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@Richard.Ali</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 13 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d19436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Stella Johnson </h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@john.sullivan</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 13 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d21931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\"> Alex Dolgove</h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@Alex.Dolgove</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 21 Courses </a>

            </div>

        </div>
    </div>
    <div>

        <div class=""card animate-this"">
            <div class=""card-body text-center"">
                <div class=""avatar-parent-child"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eedc3c116347635d0ff057fc682383e4e588129d24422", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <span class=\"avatar-child avatar-badge bg-success\"></span>\n                </div>\n                <h5 class=\"h6 mt-4 mb-0\">Adrian Mohani</h5>\n                <a href=\"#\" class=\"d-block text-sm text-muted mb-3\">");
            WriteLiteral(@"@Adrian.Mohani</a>

                <div class=""d-flex justify-content-between px-4"">
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Edit"">
                        <i class=""uil-edit-alt""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Send Message"">
                        <i class=""uil-envelope""></i>
                    </a>
                    <a href=""#"" class=""btn btn-icon btn-hover btn-circle"" uk-tooltip=""Delete"">
                        <i class=""uil-trash-alt""></i>
                    </a>
                </div>
            </div>
            <div class=""card-footer text-center py-2"">

                <a href=""#"" class=""text-muted uk-text-small""> 25 Courses </a>

            </div>

        </div>
    </div>
</div>


<ul class=""uk-pagination my-5 uk-flex-center"" uk-margin>
    <li class=""uk-active""><span>1</span></li>
    <li><a href=""#"">2</a></li>
    <li><a href=""#"">3</a></li>
    <li class=""uk");
            WriteLiteral("-disabled\"><span>...</span></li>\n    <li><a href=\"#\"><span uk-pagination-next></span></a></li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591