#pragma checksum "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c210d9e8bffffcc0da0fee810c8aa6e040dfe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mozika.Web.Pages.Templates.Pages_Templates_Form), @"mvc.1.0.view", @"/Pages/Templates/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c210d9e8bffffcc0da0fee810c8aa6e040dfe1", @"/Pages/Templates/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dbfd86f2964fd3a725c79fe70dba4759f6eedb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Templates_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("uk-child-width-1-2@s uk-grid-small p-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/andy/Projects/Repositories/Mozika/Mozika/Mozika.Web/Pages/Templates/Form.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex"">
    <nav id=""breadcrumbs"" class=""mb-3"">
        <ul>
            <li><a href=""#""> <i class=""uil-home-alt""></i> </a></li>
            <li><a href=""#""> Setting </a></li>
            <li>Account Setting</li>
        </ul>
    </nav>
</div>



<div uk-grid>
    <div class=""uk-width-1-4@m uk-flex-last@m"">

        <nav class=""responsive-tab style-3 setting-menu card""");
            BeginWriteAttribute("uk-sticky", "\n             uk-sticky=\"", 534, "\"", 637, 8);
            WriteAttributeValue("", 559, "top:30", 559, 6, true);
            WriteAttributeValue(" ", 565, ";", 566, 2, true);
            WriteAttributeValue(" ", 567, "offset:100;", 568, 12, true);
            WriteAttributeValue(" ", 579, "media:", 580, 7, true);
            WriteLiteral("@");
            WriteAttributeValue("", 588, "m", 588, 1, true);
            WriteAttributeValue(" ", 589, ";bottom:true;", 590, 14, true);
            WriteAttributeValue(" ", 603, "animation:", 604, 11, true);
            WriteAttributeValue(" ", 614, "uk-animation-slide-top", 615, 23, true);
            EndWriteAttribute();
            WriteLiteral(@">

            <ul>
                <li class=""uk-active""><a href=""#""> <i class=""uil-cog""></i> General </a></li>
                <li><a href=""#""> <i class=""uil-user""></i> Profile </a></li>
                <li><a href=""#""> <i class=""uil-usd-circle""></i> Monetization</a></li>
                <li><a href=""#""> <i class=""uil-unlock-alt""></i> Password </a></li>
                <li><a href=""#""> <i class=""uil-dollar-alt""></i> Earning</a></li>
                <li><a href=""#""> <i class=""uil-scenery""></i> Avatar & Cover</a></li>
                <li><a href=""#""> <i class=""uil-shield-check""></i> Security</a></li>
                <li><a href=""#""> <i class=""uil-bolt""></i> Membarship</a></li>
                <li><a href=""#""> <i class=""uil-history""></i> Manage Sessions</a></li>
                <li><a href=""#""> <i class=""uil-trash-alt""></i> Delete account</a></li>
            </ul>
        </nav>

    </div>

    <div class=""uk-width-2-3@m"">

        <div class=""card rounded"">
            <div class=""p-3"">
                <h5 ");
            WriteLiteral("class=\"mb-0\"> Contact info </h5>\n            </div>\n            <hr class=\"m-0\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c210d9e8bffffcc0da0fee810c8aa6e040dfe16083", async() => {
                WriteLiteral(@"
                <div>
                    <h5 class=""uk-text-bold mb-2""> First Name </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""Your name"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Seccond Name </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""Your seccond"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Your email address </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""eliedaniels@gmail.com"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Phone </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""+1 555 623 568 "">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("uk-grid", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""uk-flex uk-flex-right p-4"">
                <button class=""btn  btn-light mr-2"">Cancle</button>
                <button class=""btn btn-default"">Save Changes</button>
            </div>
        </div>

        <div class=""card rounded mt-4"">
            <div class=""p-3"">
                <h5 class=""mb-0""> Billing address </h4>
            </div>
            <hr class=""m-0"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c210d9e8bffffcc0da0fee810c8aa6e040dfe18955", async() => {
                WriteLiteral(@"
                <div>
                    <h5 class=""uk-text-bold mb-2""> Number </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""23, Block C2 "">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Street </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""Street Number"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> City </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""City Name"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Postal Code </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""Postal Code"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> State </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""State"">
                </div>
                <div>
                    <h5 class=""uk-text-bold");
                WriteLiteral(@" mb-2""> Country </h5>
                    <input type=""text"" class=""uk-input"" placeholder=""Your Country"">
                </div>
                <div>
                    <h5 class=""uk-text-bold mb-2""> Gender </h5>
                    <select class=""uk-select"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c210d9e8bffffcc0da0fee810c8aa6e040dfe110605", async() => {
                    WriteLiteral("Male");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c210d9e8bffffcc0da0fee810c8aa6e040dfe111626", async() => {
                    WriteLiteral("Female");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </select>\n                </div>\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("uk-grid", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"uk-flex uk-flex-right p-4\">\n                <button class=\"btn  btn-light mr-2\">Cancle</button>\n                <button class=\"btn btn-default\">Save Changes</button>\n            </div>\n        </div>\n\n    </div>\n\n\n</div>");
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
