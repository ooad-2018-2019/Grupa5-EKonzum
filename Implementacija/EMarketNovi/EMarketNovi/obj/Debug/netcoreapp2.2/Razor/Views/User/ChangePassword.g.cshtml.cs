#pragma checksum "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5932c448e7aefd8f32dac8c74c11a2aca88cbbb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangePassword), @"mvc.1.0.view", @"/Views/User/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ChangePassword.cshtml", typeof(AspNetCore.Views_User_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5932c448e7aefd8f32dac8c74c11a2aca88cbbb2", @"/Views/User/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc2148e302d1577d4be15ac66c13e6273d08845", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 2 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\ChangePassword.cshtml"
  
    ViewData["Title"] = "Promjena lozinke";

#line default
#line hidden
            BeginContext(54, 122, true);
            WriteLiteral("\r\n<div class=\"row border border-primary\" style=\"background-color: lightgray;width: 280;\">\r\n    <div class=\"col\">\r\n        ");
            EndContext();
            BeginContext(176, 677, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5932c448e7aefd8f32dac8c74c11a2aca88cbbb23942", async() => {
                BeginContext(182, 382, true);
                WriteLiteral(@"
            <input class=""form-control"" type=""text"" name=""etSigurnosnoPitanje"" placeholder=""Sigurnosno pitanje"" readonly =""true"">
            <div class=""form-group row"" style=""height: 38;""><label class=""col-sm-2 col-form-label"" for=""inputAnswer"">Odgovor:</label> <input class=""form-control"" type=""text"" name=""inputAnswer"" placeholder=""Ovdje upisite odgovor""></div>
            ");
                EndContext();
                BeginContext(565, 269, false);
#line 11 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\ChangePassword.cshtml"
       Write(Html.ActionLink("Potvrdi", "ChangePassword", "User", null, new { @class = "btn btn-primary btn-danger", style = "position: relative;background-color: #3DD713;left: 1100px; color: #3DD713; border-top-left-radius: 5px; border-bottom-left-radius: 5px;", type = "submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(834, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(853, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
