#pragma checksum "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a37cb48e0bc27d1fb792ce14cf30ed7b83a07f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductsPage), @"mvc.1.0.view", @"/Views/Shared/ProductsPage.cshtml")]
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
#line 1 "C:\Users\Alvion\Desktop\SparesShop\Views\_ViewImports.cshtml"
using SparesShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alvion\Desktop\SparesShop\Views\_ViewImports.cshtml"
using SparesShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a37cb48e0bc27d1fb792ce14cf30ed7b83a07f", @"/Views/Shared/ProductsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80715a82fa35680df0b82021ab0bdaea9c025c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a37cb48e0bc27d1fb792ce14cf30ed7b83a07f3222", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width,initial-scale=1.0\">\r\n\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a37cb48e0bc27d1fb792ce14cf30ed7b83a07f4309", async() => {
                WriteLiteral("\r\n    <div class=\"col-lg-3\">\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 13 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
             if (string.IsNullOrEmpty(Model.TitleImagePath))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <img src=\"https://yeella.com/files/uploads/error_404.png\" class=\"card-img-top\" alt=\"...\">\r\n");
#nullable restore
#line 16 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <img");
                BeginWriteAttribute("src", " src=\"", 503, "\"", 538, 2);
                WriteAttributeValue("", 509, "/images/", 509, 8, true);
#nullable restore
#line 19 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
WriteAttributeValue("", 517, Model.TitleImagePath, 517, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n");
#nullable restore
#line 20 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card-body\">\r\n            <p class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
                             Write(Model.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
                             Write(Model.ArticleNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 24 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
                            Write(Model.Price.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            ");
#nullable restore
#line 26 "C:\Users\Alvion\Desktop\SparesShop\Views\Shared\ProductsPage.cshtml"
       Write(Html.ActionLink("Buy", "addToCart", "ShopCart", new { id = Model.Id }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
