#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e670f1fdf4816963d90d943a9fb14bd437cfc16e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e670f1fdf4816963d90d943a9fb14bd437cfc16e", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9bf7a65c8a1012b6b9d1a0563ad0cc3bac419e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Models.MyBasket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n\r\n    <div style=\"margin-left:250px; margin-right:250px\">\r\n\r\n");
#nullable restore
#line 6 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
         using (Html.BeginForm("Cart", "Cart", FormMethod.Post))
        {
          

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row col-12"">
            <div class=""col-6"">

                <h4 style=""float:left"" class=""modal-title"">DEBRA</h4>
                <br />
                <br />
                <div class=""row"" style=""margin-left:12px"">
                    <p style=""color:pink"">Cart</p>&nbsp;
                    <p>></p>&nbsp;
                    <p>Information</p> &nbsp;
                    <p>></p>&nbsp;
                    <p>Shipping</p>
                    <p>></p>&nbsp;
                    <p>Payment</p>
                </div>
                <div class=""row"">
                    <div>
                        <div class=""container"">
                            <br />
                            <br />
                            <h2>Contact information</h2>
                            <br />
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e670f1fdf4816963d90d943a9fb14bd437cfc16e4786", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""email"">Email <span class=""text-muted"">(Optional)</span></label>
                                    <input type=""email"" class=""form-control"" id=""ContactInfo"" name=""Email"" placeholder=""your@example.com"">
                                    <div class=""invalid-feedback"">
                                        Please enter a valid email address for shipping updates.
                                    </div>
                                </div>

");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""text"">Telephone <span class=""text-muted"">(Optional)</span></label>
                                    <input type=""text"" class=""form-control"" id=""ContactInfo"" name=""Telephone"">
                                </div>

");
                WriteLiteral(@"                                <div class=""custom-control custom-checkbox"">
                                    <input type=""checkbox"" class=""custom-control-input"" id=""same-address"">
                                    <label class=""custom-control-label"" for=""same-address"">Keep me  up to date on news and  exclusive  offers</label>
                                </div>

                                <br />
                                <br />
                                <h2>Shipping address</h2>
                                <br />
");
                WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-md-6 mb-3"">
                                        <label for=""firstName"">Firstname</label>
                                        <input type=""text"" class=""form-control"" id=""Firstname"" name=""Firstname"" placeholder=""First name (optional)"" required>
                                        <div class=""invalid-feedback"">
                                            Valid first name is required.
                                        </div>
                                    </div>
                                    <div class=""col-md-6 mb-3"">
                                        <label for=""lastName"">Lastname</label>
                                        <input type=""text"" class=""form-control"" id=""Lastname"" name=""Lastname"" placeholder=""Last name"" required>
                                        <div class=""invalid-feedback"">
                                            Valid last name is req");
                WriteLiteral("uired.\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""address"">Address</label>
                                    <input type=""text"" class=""form-control"" id=""Address"" name=""Address"" placeholder=""1234 Main St"" required>
                                    <div class=""invalid-feedback"">
                                        Please enter your shipping address.
                                    </div>
                                </div>
");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""apartment"">Apartment</label>
                                    <input type=""text"" class=""form-control"" id=""Apartment"" name=""ApartmentNumber"" placeholder=""Apartament"" required>
                                    <div class=""invalid-feedback"">
                                        Please enter your shipping address.
                                    </div>
                                </div>
");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""state"">City</label>
                                    <input type=""text"" class=""form-control"" id=""City"" name=""City"" placeholder=""city"" required>
                                </div>


                                <div class=""row"">
                                    <div class=""col-md-5 mb-3"">
                                        <label for=""country""></label>
                                        <input type=""text"" class=""form-control"" id=""Country"" name=""Country"" placeholder=""Country"" required>
                                        <div class=""invalid-feedback"">
                                            Please select a valid country.
                                        </div>
                                    </div>

                                    <div class=""col-md-3 mb-3"">
                                        <label for=""zip"">Zip</label>
                          ");
                WriteLiteral("              <input type=\"text\" class=\"form-control\" id=\"Postalcode\" value=\"45454\" name=\"Psc\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6164, "\"", 6178, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                        <div class=""invalid-feedback"">
                                            Zip code required.
                                        </div>
                                    </div>

                                </div>

                                <div class=""custom-control custom-checkbox"">
                                    <input type=""checkbox"" class=""custom-control-input"" id=""same-address"">
                                    <label class=""custom-control-label"" for=""same-address"">Shipping address is the same as my billing address</label>
                                </div>

                                <br />
                                <br />
                                <div style=""float:right"">

                                    <button class=""btn btn-danger"" type=""submit"" id=""btnMyModalSecond"">Continue to checkout</button>

                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"col-6 jumbotron\">\r\n                <br />\r\n                <br />\r\n\r\n");
#nullable restore
#line 144 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                  
                    int totalPriceFinal = 0;
                    int tFin = 0;
                    int counter = 0;
                    foreach (var item in Model.ProductList)
                    {
                        int totalPrice = int.Parse(Model.Quantity[counter].ToString()) * int.Parse(item.Price.ToString());
                        totalPriceFinal += totalPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row col-12\">\r\n                            <div class=\"col-2\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 7943, "\"", 7964, 1);
#nullable restore
#line 154 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 7949, item.PhotoPath, 7949, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" />\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <p>");
#nullable restore
#line 157 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                              Write(item.NameOfProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-4\">\r\n                                <td>$");
#nullable restore
#line 160 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                                Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 163 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                        counter++;
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                <br />\r\n                <hr />\r\n                <br />\r\n");
            WriteLiteral("                    <div class=\"row col-12\">\r\n                        <div class=\"col-4\">\r\n                            Subtotal\r\n                        </div>\r\n                        <div>\r\n                            $");
#nullable restore
#line 179 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                        Write(totalPriceFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row col-12"">
                        <div class=""col-4"">
                            Shipping
                        </div>
                        <div>
                            Calculated at next step
                        </div>
                    </div>
");
            WriteLiteral(@"                    <br />
                    <hr />
                    <br />
                    <div class=""row col-12"">
                        <div class=""col-8"">
                            <h3>Total</h3>

                        </div>
                        <div>
                            <h6>USD &nbsp; $");
#nullable restore
#line 201 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
                                       Write(totalPriceFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 209 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Cart\Cart.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#appHeader\").attr(\"hidden\", true);\r\n        $(\"#appFooter\").attr(\"hidden\", true);\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Models.MyBasket> Html { get; private set; }
    }
}
#pragma warning restore 1591