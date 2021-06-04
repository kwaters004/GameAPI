#pragma checksum "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e2fbca1496ad93760be8b38cad8d0cfa0c54a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewReleases), @"mvc.1.0.view", @"/Views/Home/NewReleases.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\_ViewImports.cshtml"
using VideoGameDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\_ViewImports.cshtml"
using VideoGameDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73e2fbca1496ad93760be8b38cad8d0cfa0c54a5", @"/Views/Home/NewReleases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9219e8e29a393deade478c06fe04f8a2fa001dd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewReleases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APIListGames>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Images/Untitled.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 100%; max-width: 100%; grid-row: 1/4; grid-column: 2/3; justify-self: center; align-self: center; margin: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
  
    ViewData["Title"] = "NewReleases";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    a > div {\r\n        color: black;\r\n    }\r\n</style>\r\n\r\n<h1>New Games from the Last 7 Days</h1>\r\n\r\n<div style=\"display: grid; grid-template-columns: 1fr 1fr; grid-gap: 10px\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
     foreach (GameFromList game in Model.results)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 356, 2);
            WriteAttributeValue("", 333, "/home/gamepage/", 333, 15, true);
#nullable restore
#line 18 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
WriteAttributeValue("", 348, game.id, 348, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: grid; grid-template-columns: 1fr 2fr; background-color: lightgrey; padding: 10px\">\r\n            <div style=\"font-weight: bold; font: small-caps\">");
#nullable restore
#line 19 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
                                                        Write(game.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>Rating:</b><br /> ");
#nullable restore
#line 20 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
                                 Write(game.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
             if (game.background_image == "" || game.background_image == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73e2fbca1496ad93760be8b38cad8d0cfa0c54a56159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
            }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 948, "\"", 976, 1);
#nullable restore
#line 28 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
WriteAttributeValue("", 954, game.background_image, 954, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 100%; max-width: 100%; grid-row: 1/4; grid-column: 2/3; justify-self: center; align-self: center; margin: 10px\" />\r\n");
#nullable restore
#line 29 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div><b>Released:</b><br /> ");
#nullable restore
#line 32 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
                                   Write(game.released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n        </a>\r\n");
#nullable restore
#line 35 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\NewReleases.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APIListGames> Html { get; private set; }
    }
}
#pragma warning restore 1591