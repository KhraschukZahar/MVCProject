#pragma checksum "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3409cb6aaa7cd9577c2a6e31d9b961df61351dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_ListUsers), @"mvc.1.0.view", @"/Views/Administrator/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/ListUsers.cshtml", typeof(AspNetCore.Views_Administrator_ListUsers))]
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
#line 1 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods;

#line default
#line hidden
#line 2 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods.Models;

#line default
#line hidden
#line 3 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\_ViewImports.cshtml"
using MVC_SportGoods.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3409cb6aaa7cd9577c2a6e31d9b961df61351dd", @"/Views/Administrator/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b2302d4c7fddba7d678dda78bd2d08fe1ae563", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edituser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
  
    ViewBag.Title = "All Users";

#line default
#line hidden
            BeginContext(72, 24, true);
            WriteLiteral("\r\n<h1>All Users</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(118, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(122, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3409cb6aaa7cd9577c2a6e31d9b961df61351dd7429", async() => {
                BeginContext(228, 28, true);
                WriteLiteral("\r\n        Add new user\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"

    foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(304, 98, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                User Id : ");
            EndContext();
            BeginContext(403, 7, false);
#line 20 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
                     Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(410, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(509, 13, false);
#line 23 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
                                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(522, 82, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(604, 881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3409cb6aaa7cd9577c2a6e31d9b961df61351dd10525", async() => {
                BeginContext(672, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(694, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3409cb6aaa7cd9577c2a6e31d9b961df61351dd10929", async() => {
                    BeginContext(822, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
                         WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(830, 29, true);
                WriteLiteral("\r\n\r\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 859, "\"", 890, 2);
                WriteAttributeValue("", 864, "confirmDeleteSpan_", 864, 18, true);
#line 30 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
WriteAttributeValue("", 882, user.Id, 882, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(891, 237, true);
                WriteLiteral(" style=\"display:none\">\r\n                        <span>Are you sure you want to delete?</span>\r\n                        <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n                        <a href=\"#\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 1128, "\"", 1198, 4);
                WriteAttributeValue("", 1166, "confirmDelete(\'", 1166, 15, true);
#line 34 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
WriteAttributeValue("", 1181, user.Id, 1181, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1189, "\',", 1189, 2, true);
                WriteAttributeValue(" ", 1191, "false)", 1192, 7, true);
                EndWriteAttribute();
                BeginContext(1199, 65, true);
                WriteLiteral(">No</a>\r\n                    </span>\r\n\r\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1264, "\"", 1288, 2);
                WriteAttributeValue("", 1269, "deleteSpan_", 1269, 11, true);
#line 37 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
WriteAttributeValue("", 1280, user.Id, 1280, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1289, 61, true);
                WriteLiteral(">\r\n                        <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 1350, "\"", 1419, 4);
                WriteAttributeValue("", 1388, "confirmDelete(\'", 1388, 15, true);
#line 39 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
WriteAttributeValue("", 1403, user.Id, 1403, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1411, "\',", 1411, 2, true);
                WriteAttributeValue(" ", 1413, "true)", 1414, 6, true);
                EndWriteAttribute();
                BeginContext(1420, 58, true);
                WriteLiteral(">Delete</a>\r\n                    </span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
                                                              WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1485, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 44 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1542, 265, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            No users created yet
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">
                Use the button below to create a user
            </h5>
            ");
            EndContext();
            BeginContext(1807, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3409cb6aaa7cd9577c2a6e31d9b961df61351dd19640", async() => {
                BeginContext(1916, 44, true);
                WriteLiteral("\r\n                Add new user\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1964, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 62 "C:\Users\Kirito\Desktop\MVC SportGoods\MVC SportGoods\MVC SportGoods\Views\Administrator\ListUsers.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591