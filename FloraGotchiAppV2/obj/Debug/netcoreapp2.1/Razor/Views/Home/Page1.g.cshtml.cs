#pragma checksum "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93fbc9a1d8a33e67ab25c632986fee6f9077c860"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page1), @"mvc.1.0.view", @"/Views/Home/Page1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Page1.cshtml", typeof(AspNetCore.Views_Home_Page1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93fbc9a1d8a33e67ab25c632986fee6f9077c860", @"/Views/Home/Page1.cshtml")]
    public class Views_Home_Page1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 34, true);
            WriteLiteral("\r\n<h2>FloraGotchi POF</h2>\r\n\r\n<li>");
            EndContext();
            BeginContext(78, 21, false);
#line 8 "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml"
Write(ViewData["GameScore"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 11, true);
            WriteLiteral("</li>\r\n<li>");
            EndContext();
            BeginContext(111, 17, false);
#line 9 "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml"
Write(ViewData["HumLv"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 11, true);
            WriteLiteral("</li>\r\n<li>");
            EndContext();
            BeginContext(140, 16, false);
#line 10 "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml"
Write(ViewData["Temp"]);

#line default
#line hidden
            EndContext();
            BeginContext(156, 43, true);
            WriteLiteral("</li>\r\n\r\n<button type=\"button\" value=\"Back\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 199, "\"", 253, 3);
            WriteAttributeValue("", 209, "location.href=\'", 209, 15, true);
#line 12 "C:\Users\sieuw\source\repos\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Page1.cshtml"
WriteAttributeValue("", 224, Url.Action("Index", "Home"), 224, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 252, "\'", 252, 1, true);
            EndWriteAttribute();
            BeginContext(254, 13, true);
            WriteLiteral(" />\r\n\r\n<br />");
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
