#pragma checksum "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/ListDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fd1464558c8a2f9fb484a119f745ec48210834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mozika.Web.Pages.Templates.Pages_Templates_ListDetail), @"mvc.1.0.view", @"/Pages/Templates/ListDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fd1464558c8a2f9fb484a119f745ec48210834", @"/Pages/Templates/ListDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbfd86f2964fd3a725c79fe70dba4759f6eedb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Templates_ListDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/course/2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("  rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/course/5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/course/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/course/3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/ListDetail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex"">
    <nav id=""breadcrumbs"" class=""mb-3"">
        <ul>
            <li><a href=""#""> <i class=""uil-home-alt""></i> </a></li>
            <li><a href=""#""> Categories </a></li>
            <li> Web Development</li>
        </ul>
    </nav>
</div>


<div uk-grid>
    <div class=""uk-width-1-3@m"">

        <nav class=""responsive-tab style-3 setting-menu card""");
            BeginWriteAttribute("uk-sticky", "\n             uk-sticky=\"", 522, "\"", 625, 8);
            WriteAttributeValue("", 547, "top:30", 547, 6, true);
            WriteAttributeValue(" ", 553, ";", 554, 2, true);
            WriteAttributeValue(" ", 555, "offset:100;", 556, 12, true);
            WriteAttributeValue(" ", 567, "media:", 568, 7, true);
            WriteLiteral("@");
            WriteAttributeValue("", 576, "m", 576, 1, true);
            WriteAttributeValue(" ", 577, ";bottom:true;", 578, 14, true);
            WriteAttributeValue(" ", 591, "animation:", 592, 11, true);
            WriteAttributeValue(" ", 602, "uk-animation-slide-top", 603, 23, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <h5 class=""mb-0 p-3 uk-visible@m""> Catagries </h5>
            <hr class=""m-0 uk-visible@m"">
            <ul>
                <li class=""uk-active"">
                    <a href=""#"">
                        <i class=""uil-brush-alt ""></i> Web Development
                        <span class=""badge badge-light ml-2 badge-sm""> 21</span>
                    </a>
                </li>
                <li>
                    <a href=""#""> <i class=""uil-android-alt""></i> Mobile App <span class=""badge badge-light ml-2 badge-sm""> 12</span></a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-bag-alt""></i> Business
                        <span class=""badge badge-light ml-2 badge-sm"">8</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-window""></i> IT Software
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
          ");
            WriteLiteral(@"          </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-palette""></i> Desings
                        <span class=""badge badge-light ml-2 badge-sm""> 14</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-megaphone""></i> Marketing
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-life-ring""></i> Life Style
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class="" uil-camera""></i> Photography
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
      ");
            WriteLiteral(@"          <li>
                    <a href=""#"">
                        <i class=""uil-medkit""></i> Health Fitness
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-music""></i> Music <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-shopping-cart-alt""></i> Ecommerce
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""uil-utensils-alt ""></i> Food cooking
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
                <li>
                    <a href=""#"">
       ");
            WriteLiteral(@"                 <i class=""uil-lightbulb-alt""></i> Teaching academy
                        <span class=""badge badge-light ml-2 badge-sm""> 12</span>
                    </a>
                </li>
            </ul>
        </nav>

    </div>

    <div class=""uk-width-2-3@m"">

        <div class=""card rounded"">
            <div class=""p-3 d-flex align-items-center justify-content-between"">
                <h5 class=""mb-0""> Web Development </h5> <span> 16 Courses </span>
            </div>
            <hr class=""m-0"">

            <div class=""uk-grid-small p-4"" uk-grid>
                <div class=""uk-width-1-3@m"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02fd1464558c8a2f9fb484a119f745ec4821083410321", async() => {
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
            WriteLiteral(@"
                </div>
                <div class=""uk-width-expand"">
                    <h5 class=""mb-2""> Learn Anglular Fonduments </h5>
                    <p class=""uk-text-small mb-2"">
                        Created by <a href=""#""> Jonathan Madano </a>
                    </p>
                    <p class=""mb-0 uk-text-small mt-3"">
                        <span class=""mr-3 bg-light p-2 mt-1""> 16 Enerolled</span><span>
                            Last updated
                            10/2019
                        </span>
                    </p>
                </div>
            </div>

            <hr class=""m-0"">

            <div class=""uk-grid-small p-4"" uk-grid>
                <div class=""uk-width-1-3@m"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02fd1464558c8a2f9fb484a119f745ec4821083412271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""uk-width-expand"">
                    <h5 class=""mb-2""> Ultimate Web Developer Course </h5>
                    <p class=""uk-text-small mb-2"">
                        Created by <a href=""#""> Jonathan Madano </a>
                    </p>
                    <p class=""mb-0 uk-text-small mt-3"">
                        <span class=""mr-3 bg-light p-2 mt-1""> 16 Enerolled</span><span>
                            Last updated
                            10/2019
                        </span>
                    </p>
                </div>
            </div>

            <hr class=""m-0"">

            <div class=""uk-grid-small p-4"" uk-grid>
                <div class=""uk-width-1-3@m"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02fd1464558c8a2f9fb484a119f745ec4821083414225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""uk-width-expand"">
                    <h5 class=""mb-2""> Ultimate Web Developer Course </h5>
                    <p class=""uk-text-small mb-2"">
                        Created by <a href=""#""> Jonathan Madano </a>
                    </p>
                    <p class=""mb-0 uk-text-small mt-3"">
                        <span class=""mr-3 bg-light p-2 mt-1""> 16 Enerolled</span><span>
                            Last updated
                            10/2019
                        </span>
                    </p>
                </div>
            </div>

            <hr class=""m-0"">

            <div class=""uk-grid-small p-4"" uk-grid>
                <div class=""uk-width-1-3@m"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02fd1464558c8a2f9fb484a119f745ec4821083416179", async() => {
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
            WriteLiteral(@"
                </div>
                <div class=""uk-width-expand"">
                    <h5 class=""mb-2""> Learn Anglular Fonduments </h5>
                    <p class=""uk-text-small mb-2"">
                        Created by <a href=""#""> Jonathan Madano </a>
                    </p>
                    <p class=""mb-0 uk-text-small mt-3"">
                        <span class=""mr-3 bg-light p-2 mt-1""> 16 Enerolled</span><span>
                            Last updated
                            10/2019
                        </span>
                    </p>
                </div>
            </div>

            <hr class=""m-0"">

            <div class=""uk-grid-small p-4"" uk-grid>
                <div class=""uk-width-1-3@m"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02fd1464558c8a2f9fb484a119f745ec4821083418129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""uk-width-expand"">
                    <h5 class=""mb-2""> The Complete JavaScript </h5>
                    <p class=""uk-text-small mb-2"">
                        Created by <a href=""#""> Jonathan Madano </a>
                    </p>
                    <p class=""mb-0 uk-text-small mt-3"">
                        <span class=""mr-3 bg-light p-2 mt-1""> 16 Enerolled</span><span>
                            Last updated
                            10/2019
                        </span>
                    </p>
                </div>
            </div>

        </div>



        <ul class=""uk-pagination mt-5 uk-flex-center"" uk-margin>
            <li class=""uk-active""><span>1</span></li>
            <li><a href=""#"">2</a></li>
            <li><a href=""#"">3</a></li>
            <li class=""uk-disabled""><span>...</span></li>
            <li><a href=""#""><span uk-pagination-next></span></a></li>
        </ul>



    </div>


</div>");
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
