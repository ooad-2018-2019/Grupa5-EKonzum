#pragma checksum "C:\Users\Mubina\Source\Repos\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Manager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55db0bba56e6bc28ac4992ef73cb07e5a2f73f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Index), @"mvc.1.0.view", @"/Views/Manager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/Index.cshtml", typeof(AspNetCore.Views_Manager_Index))]
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
#line 1 "C:\Users\Mubina\Source\Repos\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\_ViewImports.cshtml"
using EMarketNovi;

#line default
#line hidden
#line 2 "C:\Users\Mubina\Source\Repos\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\_ViewImports.cshtml"
using EMarketNovi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55db0bba56e6bc28ac4992ef73cb07e5a2f73f3a", @"/Views/Manager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc2148e302d1577d4be15ac66c13e6273d08845", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Mubina\Source\Repos\Grupa5-EKonzum\Implementacija\EMarketNovi\EMarketNovi\Views\Manager\Index.cshtml"
  
    ViewData["Title"] = "Pregled prodaje";

#line default
#line hidden
            BeginContext(53, 122, true);
            WriteLiteral("\r\n<div class=\"row border border-primary\" style=\"background-color: lightgray;width: 300;\">\r\n    <div class=\"col\">\r\n        ");
            EndContext();
            BeginContext(175, 1460, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55db0bba56e6bc28ac4992ef73cb07e5a2f73f3a3862", async() => {
                BeginContext(181, 1447, true);
                WriteLiteral(@"
            <div class=""form-group"" style=""height: 30;""><input class=""form-control col-sm-4"" type=""text"" id=""outputUsername"" readonly=""true"" /></div>
            <div class=""form-group row"" style=""height: 40;"">
                <div class=""col-sm-4 text-left"">
                    <div class=""dropdown"">
                        <button class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"" type=""button"">Odaberite kategoriju</button>
                        <div class=""dropdown-menu"" role=""menu""><a class=""dropdown-item"" role=""presentation"" href=""#"">First Item</a><a class=""dropdown-item"" role=""presentation"" href=""#"">Second Item</a><a class=""dropdown-item"" role=""presentation"" href=""#"">Third Item</a></div>
                    </div>
                </div><a href=""#"">Pregled prodaje</a>
            </div>
            <div class=""form-group"">
                <ul class=""list-group"">
                    <li class=""list-group-item""><span>Proizvod1</span></li>
                  ");
                WriteLiteral(@"  <li class=""list-group-item""><span>Proizvod2</span></li>
                    <li class=""list-group-item""><span>Proizvod3</span></li>
                </ul>
            </div>
            <div class=""form-group row"" style=""height: 40;"">
                <div class=""col-sm-2 text-left""><a href=""#"">Odustani</a></div><button class=""btn btn-primary btn-success"" type=""button"">Potvrdi</button>
            </div>
        ");
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
            BeginContext(1635, 24, true);
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
