#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb9f0c93289942b2234c966ae54e53b3b91491e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
#line 1 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\_ViewImports.cshtml"
using Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb9f0c93289942b2234c966ae54e53b3b91491e", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9bf7a65c8a1012b6b9d1a0563ad0cc3bac419e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Data.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
      
        if (TempData["TotalCountOfProducError"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                Pozor!  Max po??et je prekro??en..  zkuste pros??m vybrat max ");
#nullable restore
#line 8 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                                                                      Write(TempData["TotalCountOfProducError"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  kusu.\r\n            </div>\r\n");
#nullable restore
#line 10 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row flex-row-reverse\">\r\n        <div class=\"col-md-12 col-lg-6 col-12\">\r\n\r\n\r\n            <div class=\"featured-image\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 518, "\"", 526, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"ProductPhoto\">\r\n                    <img width=\"500\" id=\"ProductPhotoImg\" class=\"product-zoom product_variant_image\" data-image-id=\"\" alt=\"1. New and sale badge product\"");
            BeginWriteAttribute("src", " src=\"", 701, "\"", 723, 1);
#nullable restore
#line 19 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 707, Model.PhotoPath, 707, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>


        </div>


        <div class=""card col-md-12 col-lg-6 col-12"">

            <input type=""hidden"" name=""form_type"" value=""product""><input type=""hidden"" name=""utf8"" value=""???"">
            <div id=""product-content"" class=""product-detail-content"">
                <br />
                <h2>");
#nullable restore
#line 32 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
               Write(Model.NameOfProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <br />\r\n");
#nullable restore
#line 35 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                 for (int i = 0; i < Model.Rate; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "deb9f0c93289942b2234c966ae54e53b3b91491e6882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n\r\n            <p class=\"product-price product-price--big mb-10\">\r\n                <h2 style=\"color:pink\">$");
#nullable restore
#line 44 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </p>\r\n\r\n");
            WriteLiteral("            <div class=\"product-info-block mb-30\">\r\n                <div class=\"single-info\">\r\n                    <span class=\"title\">Vendor:&nbsp; <span style=\"color:pink\">");
#nullable restore
#line 50 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                                                                          Write(Model.Vendor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                </div>\r\n                <div class=\"single-info\">\r\n                    <span class=\"title\">SKU:</span>\r\n                    <span class=\"value\" style=\"color:pink\">");
#nullable restore
#line 54 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                                                      Write(Model.Dph);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div><div class=""single-info"">
                    <span class=""title"">Availability:</span>

                    <span class=""value stock-red"" style=""color:pink"">In Stock</span>

                </div>
            </div>
            <br />
            <br />
            <br />
");
            WriteLiteral("            <div class=\"product-short-desc mb-25\">\r\n                <p>");
#nullable restore
#line 67 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <br />\r\n\r\n\r\n            <style>\r\n                .product-variant-option .selector-wrapper {\r\n                    display: none;\r\n                }\r\n            </style>\r\n            <div class=\"quantity\">\r\n\r\n");
#nullable restore
#line 80 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                 using (Html.BeginForm("CheckCountOfProduct", "Shop", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <input type=\"text\" class=\"form-control\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2837, "\"", 2854, 1);
#nullable restore
#line 83 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 2845, Model.Id, 2845, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
                        <span class=""quantity-title mr-20 product-quantity-action quantity-selector"" style=""margin-left:18px"">Qty: &nbsp;</span>
                        <div class=""pro-qty mr-15 mb-lg-20 mb-md-20 mb-sm-20 product-quantity-action quantity-selector"">
                            <input type=""number"" min=""1"" name=""quantity"" class=""form-control"" required>

                        </div>
                        &nbsp;
                        <button type=""submit"" class=""btn btn-outline-danger"">Add to cart</button>
                    </div>
");
#nullable restore
#line 92 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




                <br />
                <div class=""social-share-buttons mt-20"">

                    <div class=""row"" style=""margin-left:18px"">
                        <p style=""color:gray;text-align:center"">SHARE THIS POST</p>

                    </div>
                    <br />
                    <div class=""row"" style=""margin-left:18px"">
                        <a href=""https://twitter.com/?lang=ru"" class=""fa fa-twitter""></a>
                        <a href=""#"" class=""fa fa-facebook""></a>
                        <a href=""#"" class=""fa fa-google""></a>
                        <a href=""#"" class=""fa fa-pinterest""></a>
                    </div>

                </div>
                <br />
                <br />
                <div class=""custom-payment-options"">
                    <div class=""social-share-buttons"">
                        <h5> Guaranteed Checkout:</h5>
                    </div><div class=""methods-of-payment"">

                        <img src=""//cdn.shop");
            WriteLiteral(@"ify.com/shopifycloud/shopify/assets/payment_icons/amazon-92e856f82cae5a564cd0f70457f11af4d58fa037cf6e5ab7adf76f6fd3b9cafe.svg"" height=""35"" alt=""amazon payments"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/visa-319d545c6fd255c9aad5eeaad21fd6f7f7b4fdbdb1a35ce83b89cca12a187f00.svg"" height=""35"" alt=""visa"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/master-173035bc8124581983d4efa50cf8626e8553c2b311353fbf67485f9c1a2b88d1.svg"" height=""35"" alt=""master"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/paypal-49e4c1e03244b6d2de0d270ca0d22dd15da6e92cc7266e93eb43762df5aa355d.svg"" height=""35"" alt=""paypal"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/discover-8265cfcac046637b87df7718c1436f6a1e054de3fbbb73c2ae82db1332879ba5.svg"" height=""35"" alt=""discover"">
                        <img src=""//cdn.shopify.com/shopifycloud/shop");
            WriteLiteral(@"ify/assets/payment_icons/american_express-2264c9b8b57b23b0b0831827e90cd7bcda2836adc42a912ebedf545dead35b20.svg"" height=""35"" alt=""american express"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/apple_pay-f6db0077dc7c325b436ecbdcf254239100b35b70b1663bc7523d7c424901fa09.svg"" height=""35"" alt=""apple pay"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/shopify_pay-100fde795157a3d1c18042346cf8dbd1fcf4c4f53c20064e13ea2799eb726655.svg"" height=""35"" alt=""shopify pay"">
                        <img src=""//cdn.shopify.com/shopifycloud/shopify/assets/payment_icons/google_pay-c66a29c63facf2053bf69352982c958e9675cabea4f2f7ccec08d169d1856b31.svg"" height=""35"" alt=""google pay"">
                    </div>


                    <style>
                        .methods-of-payment img {
                            padding: 0.2em;
                        }

                        .lt-ie9 .methods-of-payment, .ie8 .methods-of-p");
            WriteLiteral(@"ayment, .oldie .methods-of-payment {
                            display: none;
                        }
                    </style>
                </div>


            </div>


        </div>
    </div>

    <br />
    <br />






    <div class=""container"">
        <div id=""tabs"">
            <ul>
                <li><a href=""#tabs-1"">Description</a></li>
                <li><a href=""#tabs-2"">Reviews</a></li>
                <li><a href=""#tabs-3"">Comments</a></li>
                <li><a href=""#tabs-4"">Shipping Policy</a></li>
            </ul>
            <div id=""tabs-1"">
                <p>Proin elit arcu, rutrum commodo, vehicula tempus, commodo a, risus. Curabitur nec arcu. Donec sollicitudin mi sit amet mauris. Nam elementum quam ullamcorper ante. Etiam aliquet massa et lorem. Mauris dapibus lacus auctor risus. Aenean tempor ullamcorper leo. Vivamus sed magna quis ligula eleifend adipiscing. Duis orci. Aliquam sodales tortor vitae ipsum. Aliquam nulla. Duis aliquam mol");
            WriteLiteral(@"estie erat. Ut et mauris vel pede varius sollicitudin. Sed ut dolor nec orci tincidunt interdum. Phasellus ipsum. Nunc tristique tempus lectus.</p>
            </div>
            <div id=""tabs-2"">
                <p>Morbi tincidunt, dui sit amet facilisis feugiat, odio metus gravida ante, ut pharetra massa metus id nunc. Duis scelerisque molestie turpis. Sed fringilla, massa eget luctus malesuada, metus eros molestie lectus, ut tempus eros massa ut dolor. Aenean aliquet fringilla sem. Suspendisse sed ligula in ligula suscipit aliquam. Praesent in eros vestibulum mi adipiscing adipiscing. Morbi facilisis. Curabitur ornare consequat nunc. Aenean vel metus. Ut posuere viverra nulla. Aliquam erat volutpat. Pellentesque convallis. Maecenas feugiat, tellus pellentesque pretium posuere, felis lorem euismod felis, eu ornare leo nisi vel felis. Mauris consectetur tortor et purus.</p>
            </div>
            <div id=""tabs-3"">
                <p>Mauris eleifend est et turpis. Duis id erat. Suspendisse poten");
            WriteLiteral(@"ti. Aliquam vulputate, pede vel vehicula accumsan, mi neque rutrum erat, eu congue orci lorem eget lorem. Vestibulum non ante. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce sodales. Quisque eu urna vel enim commodo pellentesque. Praesent eu risus hendrerit ligula tempus pretium. Curabitur lorem enim, pretium nec, feugiat nec, luctus a, lacus.</p>
                <p>Duis cursus. Maecenas ligula eros, blandit nec, pharetra at, semper at, magna. Nullam ac lacus. Nulla facilisi. Praesent viverra justo vitae neque. Praesent blandit adipiscing velit. Suspendisse potenti. Donec mattis, pede vel pharetra blandit, magna ligula faucibus eros, id euismod lacus dolor eget odio. Nam scelerisque. Donec non libero sed nulla mattis commodo. Ut sagittis. Donec nisi lectus, feugiat porttitor, tempor ac, tempor vitae, pede. Aenean vehicula velit eu tellus interdum rutrum. Maecenas commodo. Pellentesque nec elit. Fusce in lacus. Vivamus a libero vitae lectus hendrerit hendreri");
            WriteLiteral(@"t.</p>
            </div>
            <div id=""tabs-4"">
                <p>Mauris eleifend est et turpis. Duis id erat. Suspendisse potenti. Aliquam vulputate, pede vel vehicula accumsan, mi neque rutrum erat, eu congue orci lorem eget lorem. Vestibulum non ante. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce sodales. Quisque eu urna vel enim commodo pellentesque. Praesent eu risus hendrerit ligula tempus pretium. Curabitur lorem enim, pretium nec, feugiat nec, luctus a, lacus.</p>
                <p>Duis cursus. Maecenas ligula eros, blandit nec, pharetra at, semper at, magna. Nullam ac lacus. Nulla facilisi. Praesent viverra justo vitae neque. Praesent blandit adipiscing velit. Suspendisse potenti. Donec mattis, pede vel pharetra blandit, magna ligula faucibus eros, id euismod lacus dolor eget odio. Nam scelerisque. Donec non libero sed nulla mattis commodo. Ut sagittis. Donec nisi lectus, feugiat porttitor, tempor ac, tempor vitae, pede. Aenean vehicul");
            WriteLiteral(@"a velit eu tellus interdum rutrum. Maecenas commodo. Pellentesque nec elit. Fusce in lacus. Vivamus a libero vitae lectus hendrerit hendrerit.</p>
            </div>
        </div>
    </div>
    <br />
    <br />

    <script>
        $(function () {
            $(""#tabs"").tabs();
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Data.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
