#pragma checksum "C:\Users\Marcell\Documents\Cellogram\Views\Shared\_Username.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afe9bf8e67d1a0cc3c2b5ec18ed66e270622dba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Username), @"mvc.1.0.view", @"/Views/Shared/_Username.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Username.cshtml", typeof(AspNetCore.Views_Shared__Username))]
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
#line 1 "C:\Users\Marcell\Documents\Cellogram\Views\_ViewImports.cshtml"
using Cellogram;

#line default
#line hidden
#line 2 "C:\Users\Marcell\Documents\Cellogram\Views\_ViewImports.cshtml"
using Cellogram.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afe9bf8e67d1a0cc3c2b5ec18ed66e270622dba", @"/Views/Shared/_Username.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f7ee31f45e2bbdaf86fda1d3df486fe5d127ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Username : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cellogram.Models.Story>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 3 "C:\Users\Marcell\Documents\Cellogram\Views\Shared\_Username.cshtml"
  foreach (var item in Model)
 {

#line default
#line hidden
            BeginContext(83, 321, true);
            WriteLiteral(@"    <div class=""stories__item stories__item--active"" onclick=""openModal();currentSlide(1)"">
      <button>
        <div class=""stories__item-picture"">
          <img src=""https://randomuser.me/api/portraits/women/90.jpg"" alt=""gail_pena's profile picture"">
        </div>
        <span class=""stories__item-username"">");
            EndContext();
            BeginContext(405, 9, false);
#line 10 "C:\Users\Marcell\Documents\Cellogram\Views\Shared\_Username.cshtml"
                                        Write(item.User);

#line default
#line hidden
            EndContext();
            BeginContext(414, 36, true);
            WriteLiteral("</span>\r\n      </button>\r\n  </div>\r\n");
            EndContext();
#line 13 "C:\Users\Marcell\Documents\Cellogram\Views\Shared\_Username.cshtml"
 }

#line default
#line hidden
            BeginContext(454, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cellogram.Models.Story>> Html { get; private set; }
    }
}
#pragma warning restore 1591
