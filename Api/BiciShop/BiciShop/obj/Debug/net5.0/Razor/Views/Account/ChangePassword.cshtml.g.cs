#pragma checksum "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469dccf9e0ebafa658f0f032e7a9c816af7529f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
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
#line 1 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\_ViewImports.cshtml"
using BiciShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\_ViewImports.cshtml"
using BiciShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469dccf9e0ebafa658f0f032e7a9c816af7529f5", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"642cb351d30adeffea9a48deeac6b5c80d08a7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BiciShop.Models.ViewModels.ChangePasswordViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger alertStyle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("alert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/ChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Change password for User, ");
#nullable restore
#line 5 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469dccf9e0ebafa658f0f032e7a9c816af7529f55326", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"mb-3 row\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
       Write(Html.LabelFor(x => x.OldPassword, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 12 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
           Write(Html.PasswordFor(x => x.OldPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469dccf9e0ebafa658f0f032e7a9c816af7529f56304", async() => {
                    WriteLiteral("\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 14 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"mb-3 row\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
       Write(Html.LabelFor(x => x.Password, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
           Write(Html.PasswordFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469dccf9e0ebafa658f0f032e7a9c816af7529f58860", async() => {
                    WriteLiteral("\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 25 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"mb-3 row\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
       Write(Html.LabelFor(x => x.Confirm, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
           Write(Html.PasswordFor(x => x.Confirm, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469dccf9e0ebafa658f0f032e7a9c816af7529f511411", async() => {
                    WriteLiteral("\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 36 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Confirm);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1528, "\"", 1553, 1);
#nullable restore
#line 41 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 1536, Model.ActionName, 1536, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ActionName\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1605, "\"", 1634, 1);
#nullable restore
#line 42 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 1613, Model.ControllerName, 1613, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ControllerName\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1690, "\"", 1711, 1);
#nullable restore
#line 43 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 1698, Model.UserId, 1698, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"userId\" />\r\n        <input type=\"submit\" value=\"Change\" class=\"btn btn-success\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 6 "C:\Users\Tat1a\source\repos\BiciShop\BiciShop\Views\Account\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BiciShop.Models.ViewModels.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
