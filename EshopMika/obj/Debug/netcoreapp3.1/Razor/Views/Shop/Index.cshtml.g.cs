#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff063eca390de71fa7a9ec5ad7eb957f300875d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff063eca390de71fa7a9ec5ad7eb957f300875d", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9bf7a65c8a1012b6b9d1a0563ad0cc3bac419e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.Data.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/products_4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-bottom:10px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ff063eca390de71fa7a9ec5ad7eb957f300875d4739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n\r\n");
            WriteLiteral(@"            <div class=""card"">
                <div class=""row col-12"">
                    <div class=""col-3"">
                        Showing:
                    </div>
                    <div class=""col-3"">

                    </div>
                    <div class=""col-3"">
                        <div class=""dropdown"">
                            <button class=""btn btn-light dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Show:
                            </button>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                <a class=""dropdown-item"" href=""#"">3</a>
                                <a class=""dropdown-item"" href=""#"">6</a>
                                <a class=""dropdown-item"" href=""#"">9</a>
                            </div>
                        </div>
                    </div>
                    ");
            WriteLiteral(@"<div class=""col-3"">
                        <div class=""dropdown"">
                            <button class=""btn btn-light dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Sort by:
                            </button>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                <a class=""dropdown-item"" href=""#"">Price</a>
                                <a class=""dropdown-item"" href=""#"">Price by</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </div>
                    </div>


                </div>
            </div>

");
            WriteLiteral("\r\n            <div class=\"album py-5 bg-light\">\r\n                <div class=\"container\">\r\n\r\n                    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 59 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                          
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-4\">\r\n                                    <div class=\"myProducts card mb-4 shadow-sm\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2594, "\"", 2615, 1);
#nullable restore
#line 64 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2600, item.PhotoPath, 2600, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"240\" />\r\n                                        <div class=\"middle\">\r\n                                            ");
#nullable restore
#line 66 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                                       Write(Html.ActionLink("Detail","Detail","Shop", new {id = item.Id, @class="btn btn-info text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"card-body\">\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 69 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                                                            Write(item.NameOfProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <div class=\"d-flex justify-content-between align-items-center\">\r\n                                                <div class=\"btn-group\">\r\n                                                    <label>");
#nullable restore
#line 72 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; <a style=\"color:gray\">$</a>  </label> \r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"row\">\r\n");
#nullable restore
#line 76 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                                                 for (int i = 0; i < item.Rate; i++)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ff063eca390de71fa7a9ec5ad7eb957f300875d10932", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 84 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Shop\Index.cshtml"
                            }

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral(@"            <br />
            <br />
            <div class=""container"" style=""text-align:center"">
                <nav aria-label=""..."">
                    <ul class=""pagination"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                        </li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item active"">
                            <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">Next</a>
                        </li>
                    </ul>
                </nav>
            </div>






        </div>
        <div class=""jumbotron col-md-4"">
        ");
            WriteLiteral(@"    <div class=""row"">
                <input type=""text"" placeholder=""Search our store"" />
                <input type=""button"" value=""Search"" />
            </div>
            <br />
            <br />
            <h5><b>Categories</b></h5>
            <p>Best Sellers(12)</p>
            <p>New Arrivals(14)</p>
            <p>Sale Items(14)</p>
            <p>Top Sell(14)</p>
            <br />
            <br />

            <hr />
            <br />

            <h5><b>Vendors</b></h5>

            <div class=""row col-6"">
                <div class=""col-3"">
                    <input id=""checkbox1"" type=""checkbox"" />
                </div>
                <div>
                    <label for=""checkbox1"">Vendor 1</label>

                </div>
            </div>
            <div class=""row col-6"">
                <div class=""col-3"">
                    <input id=""checkbox1"" type=""checkbox"" />
                </div>
                <div>
                    <label for=""check");
            WriteLiteral(@"box1"">Vendor 10</label>

                </div>
            </div>
            <div class=""row col-6"">
                <div class=""col-3"">
                    <input id=""checkbox1"" type=""checkbox"" />
                </div>
                <div>
                    <label for=""checkbox1"">Vendor 11</label>

                </div>
            </div>
            <div class=""row col-6"">
                <div class=""col-3"">
                    <input id=""checkbox1"" type=""checkbox"" />
                </div>
                <div>
                    <label for=""checkbox1"">Vendor 12</label>

                </div>
            </div>
            <div class=""row col-6"">
                <div class=""col-3"">
                    <input id=""checkbox1"" type=""checkbox"" />
                </div>
                <div>
                    <label for=""checkbox1"">Vendor 2</label>

                </div>
            </div>

            <hr />
            <br />

            <h5><b>Colors</b></h5>
 ");
            WriteLiteral(@"           <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Red</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Green</label>
                </div>
            </div>
            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Blue</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Yellow</label>
                </div>
            </div>

            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox");
            WriteLiteral(@"1"">White</label>
                </div>
            </div>

            <hr />
            <br />

            <h5><b>Size</b></h5>
            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">S</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">M</label>
                </div>
            </div>
            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">L</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">XL</label>
                </div>
            </div>

            <div class=""row col-12"">
           ");
            WriteLiteral(@"     <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Xxl</label>
                </div>
            </div>

            <hr />
            <br />

            <h5><b>Tags</b></h5>
            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Black</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Blue</label>
                </div>
            </div>
            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Fiber</label>
                </div>


                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
             ");
            WriteLiteral(@"       <label for=""checkbox1"">Gold</label>
                </div>
            </div>

            <div class=""row col-12"">
                <div class=""col-6"">
                    <input id=""checkbox1"" type=""checkbox"" />
                    <label for=""checkbox1"">Gray</label>
                </div>
            </div>

        </div>
    </div>
</div>






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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.Data.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
