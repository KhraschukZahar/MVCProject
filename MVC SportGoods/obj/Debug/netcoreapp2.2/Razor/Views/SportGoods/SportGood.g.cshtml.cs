#pragma checksum "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506f39137fb7a27b36e36f5e47b07724c1c7791d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SportGoods_SportGood), @"mvc.1.0.view", @"/Views/SportGoods/SportGood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SportGoods/SportGood.cshtml", typeof(AspNetCore.Views_SportGoods_SportGood))]
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
#line 1 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods;

#line default
#line hidden
#line 2 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods.Models;

#line default
#line hidden
#line 3 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506f39137fb7a27b36e36f5e47b07724c1c7791d", @"/Views/SportGoods/SportGood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147c78a9f6b037d4d0516932f71e0eba95d3f544", @"/Views/_ViewImports.cshtml")]
    public class Views_SportGoods_SportGood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/None_flowers.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 83, true);
            WriteLiteral("<div class=\"container post-block\">\r\n    <article>\r\n        <h2 class=\"text-center\">");
            EndContext();
            BeginContext(84, 10, false);
#line 3 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
                           Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(94, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 4 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
         if (Model.img == null)
        {

#line default
#line hidden
            BeginContext(145, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(157, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "506f39137fb7a27b36e36f5e47b07724c1c7791d5057", async() => {
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
            EndContext();
            BeginContext(210, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(248, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(260, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "506f39137fb7a27b36e36f5e47b07724c1c7791d6592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 289, "~/img/", 289, 6, true);
#line 10 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
AddHtmlAttributeValue("", 295, Model.img, 295, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(307, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
        }

#line default
#line hidden
            BeginContext(320, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(332, 17, false);
#line 12 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
      Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(349, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(367, 11, false);
#line 13 "C:\Users\dell\Desktop\SportGoods\MVCProject\MVC SportGoods\Views\SportGoods\SportGood.cshtml"
      Write(Model.price);

#line default
#line hidden
            EndContext();
            BeginContext(378, 28, true);
            WriteLiteral("</p>\r\n    </article>\r\n</div>");
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
