#pragma checksum "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618837255aefc1eceae634fcc55c2c7946ce7328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Post.cshtml", typeof(AspNetCore.Views_Shared__Post))]
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
#line 1 "C:\Users\Gizelle\Desktop\Cellogram\Views\_ViewImports.cshtml"
using Cellogram;

#line default
#line hidden
#line 2 "C:\Users\Gizelle\Desktop\Cellogram\Views\_ViewImports.cshtml"
using Cellogram.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618837255aefc1eceae634fcc55c2c7946ce7328", @"/Views/Shared/_Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f7ee31f45e2bbdaf86fda1d3df486fe5d127ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cellogram.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(40, 394, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "618837255aefc1eceae634fcc55c2c7946ce73284503", async() => {
                BeginContext(46, 288, true);
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
  <link href=""https://fonts.googleapis.com/css?family=Droid+Sans:400,700"" rel=""stylesheet"">
  ");
                EndContext();
                BeginContext(334, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "618837255aefc1eceae634fcc55c2c7946ce73285184", async() => {
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
                EndContext();
                BeginContext(397, 30, true);
                WriteLiteral("\r\n  <title>Instagram</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(434, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(436, 939, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "618837255aefc1eceae634fcc55c2c7946ce73287431", async() => {
                BeginContext(442, 468, true);
                WriteLiteral(@"
  <div class=""instagram-card"">
    <div class=""instagram-card-header"">
      <img src=""https://scontent-jnb1-1.xx.fbcdn.net/v/t1.6435-1/p200x200/67740894_2353677471419768_1908112282936672256_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=7206a8&_nc_ohc=9Asn5NoHW5wAX8i63dQ&_nc_ht=scontent-jnb1-1.xx&tp=6&oh=5532842367177dbb2a681338aa693da3&oe=60A1B467"" class=""instagram-card-user-image""/>
      <a class=""instagram-card-user-name"" href=""https://www.instagram.com/followmeto/"">");
                EndContext();
                BeginContext(911, 10, false);
#line 16 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
                                                                                  Write(Model.User);

#line default
#line hidden
                EndContext();
                BeginContext(921, 45, true);
                WriteLiteral("</a>\r\n      <div class=\"instagram-card-time\">");
                EndContext();
                BeginContext(967, 10, false);
#line 17 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
                                  Write(Model.Time);

#line default
#line hidden
                EndContext();
                BeginContext(977, 92, true);
                WriteLiteral("</div>\r\n    </div>\r\n  \r\n    <div class=\"intagram-card-image\">\r\n      <img class=\"post-image\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1069, "\"", 1087, 1);
#line 21 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
WriteAttributeValue("", 1075, Model.Image, 1075, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1088, 85, true);
                WriteLiteral("/>\r\n    </div>\r\n  \r\n    <div class=\"instagram-card-content\">\r\n      <p class=\"likes\">");
                EndContext();
                BeginContext(1174, 11, false);
#line 25 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
                  Write(Model.Likes);

#line default
#line hidden
                EndContext();
                BeginContext(1185, 105, true);
                WriteLiteral(" Likes</p>\r\n      <p><a class=\"instagram-card-content-user\" href=\"https://www.instagram.com/followmeto/\">");
                EndContext();
                BeginContext(1291, 10, false);
#line 26 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
                                                                                        Write(Model.User);

#line default
#line hidden
                EndContext();
                BeginContext(1301, 5, true);
                WriteLiteral("</a> ");
                EndContext();
                BeginContext(1307, 10, false);
#line 26 "C:\Users\Gizelle\Desktop\Cellogram\Views\Shared\_Post.cshtml"
                                                                                                        Write(Model.Body);

#line default
#line hidden
                EndContext();
                BeginContext(1317, 51, true);
                WriteLiteral("</a></p>\r\n     \r\n    </div>\r\n    \r\n  \r\n\r\n  </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1375, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cellogram.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591