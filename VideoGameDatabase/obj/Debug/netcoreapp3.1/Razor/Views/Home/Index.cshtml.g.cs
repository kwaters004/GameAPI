#pragma checksum "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce8730c52341863ca811d284a49b510e2a7c6a0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce8730c52341863ca811d284a49b510e2a7c6a0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9219e8e29a393deade478c06fe04f8a2fa001dd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APIListGames>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div style=\"visibility: hidden\">");
#nullable restore
#line 11 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
                            Write(ViewBag.counter = 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\r\n\r\n<div style=\"display: grid; grid-template-columns: 1fr 1fr 1fr\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
     foreach (GameFromList game in Model.results)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n\r\n            <div>");
#nullable restore
#line 20 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
            Write(game.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div>Id: ");
#nullable restore
#line 22 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
                Write(game.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 560, "\"", 588, 1);
#nullable restore
#line 24 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
WriteAttributeValue("", 566, game.background_image, 566, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            <div>Rating: ");
#nullable restore
#line 26 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
                    Write(game.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div>Number: ");
#nullable restore
#line 28 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
                    Write(ViewBag.counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
            WriteLiteral("        <div style=\"visibility: hidden\">");
#nullable restore
#line 33 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
                                    Write(ViewBag.counter += 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 34 "C:\Users\kwaters\dev\VideoGameDatabase\VideoGameDatabase\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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