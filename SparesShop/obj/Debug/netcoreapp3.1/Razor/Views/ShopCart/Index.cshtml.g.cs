#pragma checksum "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964ef44631d02fad352642b59fe995a37109c746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964ef44631d02fad352642b59fe995a37109c746", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80715a82fa35680df0b82021ab0bdaea9c025c29", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SparesShop.Models.ViewModels.ShopCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
  
    string strTitle = "ShopCart";
    ViewBag.Title = strTitle;
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "964ef44631d02fad352642b59fe995a37109c7464016", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<title>");
#nullable restore
#line 10 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
  Write(strTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 12 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
     foreach (var item in Model.ShopCart.ShopCartItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" alert alert-danger\" mt-3\">\r\n        <b>Product:</b>");
#nullable restore
#line 15 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
                  Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Product:</b>");
#nullable restore
#line 16 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
                  Write(item.Product.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Product:</b>");
#nullable restore
#line 17 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
                  Write(item.Product.ArticleNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Price: </b>");
#nullable restore
#line 18 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
                 Write(item.Product.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
#nullable restore
#line 19 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    ");
#nullable restore
#line 21 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
Write(Html.ActionLink("Go to checkout", "Checkout", "Orders", new { orderList = Model.ShopCart.ShopCartItems.Select(x => x.Product.Id) },
                        Model.ShopCart.ShopCartItems.Any() ? new { @class = "btn btn-outline-info" } : new { @class = "btn btn-secondary disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <p></p>\r\n    ");
#nullable restore
#line 25 "C:\Users\Alvion\Desktop\SparesShop\Views\ShopCart\Index.cshtml"
Write(Html.ActionLink("Continue shopping", "Index", "Home", new { },
                        Model.ShopCart.ShopCartItems.Any() ? new { @class = "btn btn-outline-info" } : new { @class = "btn btn-secondary enabled" }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparesShop.Models.ViewModels.ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
