#pragma checksum "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c286bf7c154276506e5062c18973dfd65834961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\_ViewImports.cshtml"
using EMarketNovi;

#line default
#line hidden
#line 2 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\_ViewImports.cshtml"
using EMarketNovi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c286bf7c154276506e5062c18973dfd65834961", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc2148e302d1577d4be15ac66c13e6273d08845", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("  background-color: lightgray;\r\n"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Prijava";

#line default
#line hidden
            BeginContext(45, 107, true);
            WriteLiteral("\r\n<div class=\"row border border-primary\" style=\"  background-color: lightgray;\r\n\">\r\n    <div class=\"col\">\r\n");
            EndContext();
#line 9 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
         using (Html.BeginForm("Login", "Home"))
        {

#line default
#line hidden
            BeginContext(213, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(221, 1010, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c286bf7c154276506e5062c18973dfd658349614548", async() => {
                BeginContext(268, 180, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <h4 class=\"col-sm-10\" style=\"  background-color: gray;\r\n\">\r\n                    e-Market\r\n                </h4>\r\n\r\n                ");
                EndContext();
                BeginContext(449, 72, false);
#line 19 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
           Write(Html.ActionLink("Kreiraj racun", "Index", "Registration", null, new { }));

#line default
#line hidden
                EndContext();
                BeginContext(521, 361, true);
                WriteLiteral(@"

            </div>
            <hr />
            <div class=""illustration""></div>
            <div class=""form-group""><input class=""form-control"" type=""text"" name=""etUsername"" placeholder=""Korisnicko ime""></div>
            <div class=""form-group""><input class=""form-control"" type=""password"" name=""etPassword"" placeholder=""Lozinka""></div>
            ");
                EndContext();
                BeginContext(883, 224, false);
#line 26 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
       Write(Html.ActionLink("Prijavi se", "Index", "Order", null, new {style = "position: relative;background-color: #3DD713;left: 1100px; color: #000000; border-top-left-radius: 5px; border-bottom-left-radius: 5px;", type = "submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(1107, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1122, 90, false);
#line 27 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
       Write(Html.ActionLink("Zaboravili ste šifru?", "Index", "User", null, new { @class = "forgot" }));

#line default
#line hidden
                EndContext();
                BeginContext(1212, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Home\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(1244, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
