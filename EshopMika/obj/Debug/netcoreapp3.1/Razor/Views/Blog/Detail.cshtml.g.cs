#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed57d34bcccbac5d2b0845eedcf284bf74861e54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed57d34bcccbac5d2b0845eedcf284bf74861e54", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9bf7a65c8a1012b6b9d1a0563ad0cc3bac419e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Data.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("s\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"well well-sm\">\r\n\r\n                <h1 style=\"text-align:center\">");
#nullable restore
#line 11 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <div class=""row"" style=""margin-left:120px"">

                    <i class=""fa fa-user-circle-o"" aria-hidden=""true"" style=""margin-left:10px;text-align:center""></i>  &nbsp;
                    <p style=""text-align: center"">Debra Demo Admin</p>&nbsp;
                    <i class=""fa fa-calendar"" style=""text-align: center"" aria-hidden=""true""></i>&nbsp;");
#nullable restore
#line 16 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                                                                                                 Write(DateTime.Now.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                                                                                                                   Write(DateTime.Now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                                                                                                                                       Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <div style=\"margin:10px\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 783, "\"", 803, 1);
#nullable restore
#line 21 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 789, Model.Picture, 789, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" />\r\n                </div>\r\n\r\n                <p>\r\n                    ");
#nullable restore
#line 25 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
               Write(Model.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                <div class=\"callout callout-danger\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 30 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                   Write(Model.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                ");
#nullable restore
#line 33 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
           Write(Model.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <hr />
                <div class=""row"">
                    <p style=""color:grey;margin-left:10px"">Tags:</p>&nbsp; <p><i>bestselling,collection,dress,fasion,men,style,woman</i></p>
                </div>
                <hr />

                <div class=""container"" style=""text-align: center;margin:20px"">
                    <p style=""color:gray;text-align:center"">SHARE THIS POST</p>
                    <a href=""https://twitter.com/?lang=ru"" class=""fa fa-twitter""></a>
                    <a href=""#"" class=""fa fa-facebook""></a>
                    <a href=""#"" class=""fa fa-google""></a>
                    <a href=""#"" class=""fa fa-pinterest""></a>
                </div>

            </div>
            <div class=""row"">
                <div class=""col-md-11"">

");
#nullable restore
#line 52 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                     using (Html.BeginForm("PostComment", "News", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <fieldset>
                            <legend>Leave a comment</legend>

                            <!-- Message body -->
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"" for=""message"">Your message</label>
                                <div class=""col-md-9"">
                                    <textarea class=""form-control"" id=""message"" name=""Message"" placeholder=""Message"" rows=""5"" required></textarea>
                                </div>
                            </div>

                            <!-- Name input-->
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"" for=""name"">Name</label>
                                <div class=""col-md-9"">
                                    <input id=""name"" name=""Username"" type=""text"" placeholder=""Your name"" class=""form-control"" required>
                                </div>
 ");
            WriteLiteral(@"                           </div>

                            <!-- Email input-->
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"" for=""email"">Your E-mail</label>
                                <div class=""col-md-9"">
                                    <input id=""email"" name=""Email"" type=""text"" placeholder=""Your email"" class=""form-control"" required>
                                </div>
                            </div>

                            <!-- Form actions -->
                            <div class=""form-group"">
                                <div class=""col-md-12 text-left"">
                                    <button type=""submit"" class=""btn btn-primary btn-lg"" style=""background-color: black"">Submit</button>
                                </div>
                            </div>
                        </fieldset>
");
#nullable restore
#line 88 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\EshopMika\Views\Blog\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""jumbotron col-md-4"">
            <div class=""row"">
                <input type=""text"" placeholder=""Search our store"" />
                <input type=""button"" value=""Search"" />
            </div>
            <br />
            <br />
            <h5><b>Custom menu</b></h5>
            <p>Home</p>
            <p>Shop</p>
            <p>Products</p>
            <p>Blog</p>
            <p>About us</p>
            <p>Contact</p>
            <br />
            <br />
            <h5><b>Recent post</b></h5>
            <div class=""row"">
                <img src=""/images/2.png"" width=""100"" />
                <p style=""margin-left:5px"">Loremm ipsum</p>
            </div>
            <hr />
            <div class=""row"">
                <img src=""/images/2.png"" width=""100"" />
                <p style=""margin-left:5px"">Loremm ipsum</p>
            </div>
            <hr />
            <div class=""row"">
           ");
            WriteLiteral(@"     <img src=""/images/2.png"" width=""100"" />
                <p style=""margin-left:5px"">Loremm ipsum</p>
            </div>
            <br />
            <br />
            <h5><b>Archive</b></h5>
            <h5><b>January 20</b></h5>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <p>Lorem ipsum</p>
            <br />
            <h5><b>Tags</b></h5>
            <div class=""row"" style=""margin:5px"">
                <span class=""label other"">Style</span> &nbsp;
                <span class=""label other"">Collection</span>
            </div>
            <div class=""row"" style=""margin:5px"">
                <span class=""label other"">Woman</span> &nbsp;
                <span class=""label other"">Men</span> &nbsp;
                <span class=""label oth");
            WriteLiteral(@"er"">Fasion</span>
            </div>
            <div class=""row"" style=""margin:5px"">
                <span class=""label other"">Dress</span> &nbsp;
                <span class=""label other"">Bestseller</span>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Data.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
