#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Products\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2f715124cd8556751c303a421b668ac9abf5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Add), @"mvc.1.0.view", @"/Views/Products/Add.cshtml")]
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
#line 1 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\_ViewImports.cshtml"
using Administration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2f715124cd8556751c303a421b668ac9abf5ce", @"/Views/Products/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ca218e2b712a72441b9fbd1044820ed3271b81", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Data.Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Products\Add.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n\r\n    <div class=\"card-header\">\r\n        <h1>Add new Product</h1>\r\n    </div>\r\n\r\n");
#nullable restore
#line 12 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Products\Add.cshtml"
     using (Html.BeginForm("Add", "Products", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card-body"">
            <div class=""card col-md-12 col-lg-6 col-12"">
                <label for=""Title"">Name Of Product</label>
                <input type=""text"" class=""form-control"" name=""NameOfProduct"" />

                <label for=""Description"">Description</label>
                <input type=""text"" class=""form-control"" name=""Description"" />

                <label for=""Price"">Price</label>
                <input type=""text"" class=""form-control"" name=""Price"" />

                <label for=""Discount"">Discount</label>
                <input type=""text"" class=""form-control"" name=""Discount"" />

                <label for=""Dph"">Dph</label>
                <input type=""text"" class=""form-control"" name=""Dph"" />

                <label for=""PhotoPath"">PhotoPath</label>
                <input type=""text"" class=""form-control"" name=""PhotoPath"" />

                <label for=""Size"">Size</label>
                <input type=""text"" class=""form-control"" name=""Size"" />

          ");
            WriteLiteral(@"      <label for=""Vendor"">Vendor</label>
                <input type=""text"" class=""form-control"" name=""Vendor"" />

                <label for=""Quantity"">Quantity</label>
                <input type=""text"" class=""form-control"" name=""Quantity"" />


            </div>
        </div>
        <hr />
        <div class=""card-footer"">
            <div class="" row"">
                <input type=""submit"" class=""btn btn-info"" value=""Save"" />
                <a class=""btn btn-warning""");
            BeginWriteAttribute("href", " href=\"", 1759, "\"", 1797, 1);
#nullable restore
#line 50 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Products\Add.cshtml"
WriteAttributeValue("", 1766, Url.Action("Index","Products"), 1766, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Return to list</a>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 54 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Products\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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