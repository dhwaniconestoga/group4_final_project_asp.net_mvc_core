#pragma checksum "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a70af3402f4b80aef81368f268569c8763dbbb38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\_ViewImports.cshtml"
using Group4_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\_ViewImports.cshtml"
using Group4_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70af3402f4b80aef81368f268569c8763dbbb38", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107a58be76bdaaae500ad708240518ff45cd9a87", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
  
    ViewData["Title"] = " | Product Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumb-area pt-35 pb-35 bg-gray-3"">
    <div class=""container"">
        <div class=""breadcrumb-content text-center"">
            <ul>
                <li>
                    <a href=""index.html"">Home</a>
                </li>
                <li class=""active"">Shop Details </li>
            </ul>
        </div>
    </div>
</div>
<div class=""shop-area pt-100 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""product-details dec-img-wrap"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a70af3402f4b80aef81368f268569c8763dbbb385738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 666, "~/images/products/", 666, 18, true);
#nullable restore
#line 25 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 684, Model.ImageName, 684, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                <div class=\"product-details-content ml-70\">\r\n                    <h2>");
#nullable restore
#line 30 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"product-details-price\">\r\n                        <span>");
#nullable restore
#line 32 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                         Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <div class=""pro-details-rating-wrap"">
                        <div class=""pro-details-rating"">
                            <i class=""fa fa-star-o yellow""></i>
                            <i class=""fa fa-star-o yellow""></i>
                            <i class=""fa fa-star-o yellow""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                    </div>
                    
                    <div class=""pro-details-list"">
                        <p>");
#nullable restore
#line 45 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                      Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""pro-details-size-color"">
                        <div class=""pro-details-color-wrap"">
                            <span>Color</span>
                            <div class=""pro-details-color-content"">
                                <ul>
                                    <li class=""blue""></li>
                                    <li class=""maroon active""></li>
                                    <li class=""gray""></li>
                                    <li class=""green""></li>
                                    <li class=""yellow""></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""pro-details-quality"">
                        <div class=""pro-details-cart btn-hover"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a70af3402f4b80aef81368f268569c8763dbbb3810109", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2702, "\"", 2726, 1);
#nullable restore
#line 64 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
WriteAttributeValue("", 2710, Model.ProductId, 2710, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                        class=\"btn btn-dark\">\r\n                                    Add To Cart\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"pro-details-meta\">\r\n                        <span><b>Brand :</b></span>\r\n                        <ul>\r\n                            <li><a href=\"#\">");
#nullable restore
#line 74 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                                       Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n\r\n                    </div>\r\n                    <div class=\"pro-details-meta\">\r\n                        <span><b>Category :</b></span>\r\n                        <ul>\r\n                            <li><a href=\"#\">");
#nullable restore
#line 81 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                                       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                        </ul>
                        
                    </div>
                    <div class=""pro-details-meta"">
                        
                        <span><b>Seller :</b></span>
                        <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 89 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                             foreach (var keyValuePair in Model.ProductBrands)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"class=\" list-group-item\"\">\r\n                                    <a href=\"#\">\r\n                                        ");
#nullable restore
#line 93 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                                   Write(keyValuePair.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 96 "D:\Canada\College\Winter 2023\PROG8770-23W-Sec2-Advanced Programming with .NET\Git\Group4_FinalProject\Views\Product\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""pro-details-social"">
                        <ul>
                            <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-dribbble""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
