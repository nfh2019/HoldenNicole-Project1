#pragma checksum "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137da189712583cb4cab0ea3c2c9bc6d481325dc"
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
#line 1 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\_ViewImports.cshtml"
using StoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\_ViewImports.cshtml"
using StoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137da189712583cb4cab0ea3c2c9bc6d481325dc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7146a653f0ad02d0064ea04143de79a34f3bce69", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreWeb2.Models.Customer>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137da189712583cb4cab0ea3c2c9bc6d481325dc3504", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome To Sports Authenticated</h1>
        <p>Check out what we have in our stores today!</p>
        <p>You never know what you will be able to find.</p>
        <p>How would you like to view Sports Authenticated Today?</p>
    </div>

    <section id=""sign-in"">
        <div class=""row"">
            <div class=""column"">
                <fieldset>
");
#nullable restore
#line 19 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                     using (Html.BeginForm("Create", "Customers", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <legend>Sign Up</legend>\r\n                        <p>\r\n                            <label placeholder=\"Desired User Name\">User Name: </label>\r\n                            ");
#nullable restore
#line 24 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <label placeholder=\"Email\">Email: </label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <input type=\"submit\" value=\"Register\" class=\"btn btn-primary\" />\r\n\r\n                        </p>\r\n");
#nullable restore
#line 36 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </fieldset>\r\n            </div>\r\n            <div class=\"column\">\r\n                <fieldset>\r\n");
#nullable restore
#line 41 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                     using (Html.BeginForm("SignInCustomer", "Customers", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <legend>Sign In</legend>\r\n                        <p>\r\n                            <label placeholder=\"User Name\">User Name: </label>\r\n                            ");
#nullable restore
#line 46 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <label placeholder=\"Email\">Email: </label>\r\n                            ");
#nullable restore
#line 51 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 52 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <input type=\"submit\" value=\"Log In\" class=\"btn btn-primary\" />\r\n                        </p>\r\n");
#nullable restore
#line 57 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </fieldset>\r\n            </div>\r\n            <div class=\"column\">\r\n                <fieldset>\r\n");
#nullable restore
#line 62 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                     using (Html.BeginForm("SignInManager", "Manager", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <legend>Manager Sign In</legend>\r\n                        <p>\r\n                            <label placeholder=\"User Name\">User Name: </label>\r\n                            ");
#nullable restore
#line 67 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 68 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <label placeholder=\"Email\">Email: </label>\r\n                            ");
#nullable restore
#line 72 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 73 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            <input type=\"submit\" value=\"Log In\" class=\"btn btn-primary\" />\r\n                        </p>\r\n");
#nullable restore
#line 78 "C:\Users\nfh22\OneDrive\Desktop\Training\HoldenNicole-Project0\HoldenNicole-Project0\StoreApp\StoreWeb\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </fieldset>\r\n            </div>\r\n        </div>\r\n    </section>    \r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreWeb2.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
