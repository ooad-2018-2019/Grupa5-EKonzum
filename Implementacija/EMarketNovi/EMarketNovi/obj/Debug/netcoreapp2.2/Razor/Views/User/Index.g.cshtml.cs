#pragma checksum "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c3ff64cc466020097d9bca5fe89bbad2501f689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c3ff64cc466020097d9bca5fe89bbad2501f689", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc2148e302d1577d4be15ac66c13e6273d08845", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Pregled Računa";

#line default
#line hidden
            BeginContext(52, 122, true);
            WriteLiteral("\r\n<div class=\"row border border-primary\" style=\"background-color: lightgray;width: 280;\">\r\n    <div class=\"col\">\r\n        ");
            EndContext();
            BeginContext(174, 1436, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c3ff64cc466020097d9bca5fe89bbad2501f6893869", async() => {
                BeginContext(180, 1059, true);
                WriteLiteral(@"
            <div style=""height: 30;""><input class=""form-control col-sm-4"" type=""text"" id=""outputUsername"" readonly=""true"" /></div>
            <div class=""form-group row"" style=""height: 40;""><label class=""col-sm-3 col-form-label"" for=""outputName"">Ime:</label><input class=""form-control col-sm-5"" type=""text"" id=""outputName"" readonly=""true"" /></div>
            <div class=""form-group row"" style=""height: 40;""><label class=""col-sm-3 col-form-label"" for=""outputSurname"">Prezime:</label><input class=""form-control col-sm-5"" type=""text"" id=""outputSurname"" readonly=""true"" /></div>
            <div class=""form-group row"" style=""height: 40;""><label class=""col-sm-3 col-form-label"" for=""outputAdress"">Adresa dostave:</label><input class=""form-control col-sm-5"" type=""text"" id=""outputAdress"" readonly=""true"" /></div>
            <div class=""form-group row"" style=""height: 40;""><label class=""col-sm-3 col-form-label"" for=""outputNumber"">Broj bodova:</label><input class=""form-control col-sm-5"" type=""text"" id=""outputNumber"" rea");
                WriteLiteral("donly=\"true\" /></div>\r\n            ");
                EndContext();
                BeginContext(1240, 270, false);
#line 14 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\Index.cshtml"
       Write(Html.ActionLink("Nazad na pocetnu", "Index", "Order", null, new { @class = "btn btn-primary btn-danger", style = "position: relative;background-color: #3DD713;left: 1100px; color: #3DD713; border-top-left-radius: 5px; border-bottom-left-radius: 5px;", type = "submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(1510, 16, true);
                WriteLiteral("\r\n\r\n            ");
                EndContext();
                BeginContext(1527, 66, false);
#line 16 "C:\Users\Nadja\Desktop\projekat_ooad\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\User\Index.cshtml"
       Write(Html.ActionLink("Promijeni sifru", "Index", "User", null, new { }));

#line default
#line hidden
                EndContext();
                BeginContext(1593, 10, true);
                WriteLiteral("\r\n        ");
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
            BeginContext(1610, 24, true);
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
