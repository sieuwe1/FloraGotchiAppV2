#pragma checksum "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b941dab81389d93f3ff00a3deb59401e5cfa78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\_ViewImports.cshtml"
using FloraGotchiAppV2;

#line default
#line hidden
#line 2 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\_ViewImports.cshtml"
using FloraGotchiAppV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b941dab81389d93f3ff00a3deb59401e5cfa78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a17855e85cc8e1420e41293ef21fa5884b72a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateTemp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateHumiity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Index.cshtml"
  
ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(39, 114, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <h2>Overview</h2>\r\n    <hr style=\"border-top: 1px solid #858585\" />\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(267, 472, true);
            WriteLiteral(@"    <div class=""row card_wrapper"">
        <div class=""col-xs-12  col-sm-12 col-md-5 card"">
            <div class="" col-md-4 card_data"">
                <ul>
                    <li><img src=""https://www.google.com/search?q=thermometer+icons&tbm=isch&source=iu&ictx=1&fir=C8Nlam0RBHQGzM%253A%252C4LjP6dpWIzzXOM%252C_&usg=AI4_-kQBjDzi13XSm-cF8lChpaE_N0lUDg&sa=X&ved=2ahUKEwj-sO672NzfAhWKmLQKHT71DVMQ9QEwAXoECAMQBA#imgrc=7d6wYeEtcczMXM:""></li>
                    <li>");
            EndContext();
            BeginContext(740, 16, false);
#line 21 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Index.cshtml"
                   Write(ViewData["Temp"]);

#line default
#line hidden
            EndContext();
            BeginContext(756, 48, true);
            WriteLiteral("</li>\r\n                </ul>\r\n\r\n                ");
            EndContext();
            BeginContext(804, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5e8dfb86794487590fc64178e38bc10", async() => {
                BeginContext(870, 201, true);
                WriteLiteral("\r\n\r\n                    <input type=\"number\" name=\"Temperatuur\" min=\"0\" max=\"100\" placeholder=\"Enter Temperature here\"/>\r\n                    <button type=\"submit\" value=\"Add Temp\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1078, 992, true);
            WriteLiteral(@"

            </div>
            <div class=""col-md-6 card_info"">
                <h2> Temperature</h2>
                <p> Lorem ipsum dolor sit, consectetuer adipiscing elit.</p>
            </div>
        </div>
        <div class=""col-xs-12  col-sm-12 col-md-5 card_person"">
            <h2> Hello, Username</h2>
            <p>
                Here's an overview of Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.
            </p>
        </div>
    </div>
    <div class=""row card_wrapper"">
        <div class=""col-xs-12 col-sm-12 col-md-5 card"">
            <div class="" col-md-4 card_data"">
                <ul>
                    <li><img src=""https://www.google.com/search?q=thermometer+icons&tbm=isch&source=iu&ictx=1&fir=C8Nlam0RBHQGzM%253A%252C4LjP6dpWIzzXOM%252C_&usg=AI4_-kQBjDzi13XSm-cF8lChpaE_N0lUDg&sa=X&ved=2ahUKEwj-sO672NzfAhWKmLQKHT71DVMQ9QEwAXoECAMQBA#imgrc=7d6wYeEtcczMXM:""></li>
                    <li>");
            EndContext();
            BeginContext(2071, 17, false);
#line 48 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Index.cshtml"
                   Write(ViewData["Score"]);

#line default
#line hidden
            EndContext();
            BeginContext(2088, 682, true);
            WriteLiteral(@"</li>
                </ul>
            </div>
            <div class=""col-md-6 card_info"">
                <h2> Score</h2>
                <p> Lorem ipsum dolor sit, consectetuer adipiscing elit.</p>
            </div>
        </div>
        <div class=""col-xs-12 col-sm-12 col-md-5 card"">
            <div class="" col-md-4 card_data"">


                <ul>
                    <li><img src=""https://www.google.com/search?q=thermometer+icons&tbm=isch&source=iu&ictx=1&fir=C8Nlam0RBHQGzM%253A%252C4LjP6dpWIzzXOM%252C_&usg=AI4_-kQBjDzi13XSm-cF8lChpaE_N0lUDg&sa=X&ved=2ahUKEwj-sO672NzfAhWKmLQKHT71DVMQ9QEwAXoECAMQBA#imgrc=7d6wYeEtcczMXM:""></li>
                    <li>");
            EndContext();
            BeginContext(2771, 17, false);
#line 62 "C:\Users\sieuw\Documents\GitHub\FloraGotchiAppV2\FloraGotchiAppV2\Views\Home\Index.cshtml"
                   Write(ViewData["HumLv"]);

#line default
#line hidden
            EndContext();
            BeginContext(2788, 48, true);
            WriteLiteral("</li>\r\n\r\n                </ul>\r\n                ");
            EndContext();
            BeginContext(2836, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d42badbe2846649a4490fc23e87647", async() => {
                BeginContext(2905, 142, true);
                WriteLiteral("\r\n\r\n                    <input type=\"text\" name=\"Humidity\" />\r\n                    <button type=\"submit\" value=\"Add Temp\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3054, 260, true);
            WriteLiteral(@"

            </div>
            <div class=""col-md-6 card_info"">
                <h2> Humidity</h2>
                <p> Lorem ipsum dolor sit, consectetuer adipiscing elit.</p>
            </div>
        </div>
    </div>





    <br />
</div>");
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
