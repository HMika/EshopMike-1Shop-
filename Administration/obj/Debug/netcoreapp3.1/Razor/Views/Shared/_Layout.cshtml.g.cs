#pragma checksum "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c561fc2ceb675a9ec65be81325a6de2e93275dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c561fc2ceb675a9ec65be81325a6de2e93275dae", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ca218e2b712a72441b9fbd1044820ed3271b81", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Autentication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c561fc2ceb675a9ec65be81325a6de2e93275dae4180", async() => {
                WriteLiteral(@"
    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.5/examples/dashboard/"">

    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"">

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }
    </style>
    <!-- Custom styles for this template -->
    <link href=""/css/adminStyle.css"" rel=""stylesheet"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c561fc2ceb675a9ec65be81325a6de2e93275dae5743", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow"">
        <a class=""navbar-brand col-md-3 col-lg-2 mr-0 px-3"" href=""#"">DEBRA</a>
        <button class=""navbar-toggler position-absolute d-md-none collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#sidebarMenu"" aria-controls=""sidebarMenu"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <input class=""form-control form-control-dark w-100"" type=""text"" placeholder=""Search"" aria-label=""Search"">
        <ul class=""navbar-nav px-3"">
            <li class=""nav-item text-nowrap"">
                ");
#nullable restore
#line 32 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Sign out", "SignOut", "Autentication", new { loginName = Context.Session.Keys.Where(x=>x.Contains("Admin")) }));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c561fc2ceb675a9ec65be81325a6de2e93275dae7081", async() => {
                    WriteLiteral("Sign out");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </li>
        </ul>
    </nav>
    <div class=""container-fluid"">
        <div class=""row"">
            <nav id=""sidebarMenu"" class=""col-md-3 col-lg-2 d-md-block bg-light sidebar collapse"">
                <div class=""sidebar-sticky pt-3"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""#"">
                                <span data-feather=""home""></span>
                                Dashboard <span class=""sr-only"">(current)</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2287, "\"", 2323, 1);
#nullable restore
#line 49 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2294, Url.Action("Index","Orders"), 2294, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <span data-feather=""file""></span>
                                Orders
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2593, "\"", 2631, 1);
#nullable restore
#line 55 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2600, Url.Action("Index","Products"), 2600, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <span data-feather=""shopping-cart""></span>
                                Produkt
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2911, "\"", 2948, 1);
#nullable restore
#line 61 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2918, Url.Action("Index","Article"), 2918, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <span data-feather=""users""></span>
                                Articles
                            </a>
                        </li>

                    </ul>


                </div>
            </nav>

            <main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-md-4"">
                ");
#nullable restore
#line 74 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>
        </div>
    </div>



    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script>window.jQuery || document.write('<script src=""/lib/jquery/dist/jquery.slim.min.js""><\/script>')</script>
    <script src=""/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.9.0/feather.min.js""></script>
    <script src=""/js/admin.js""></script>
    ");
#nullable restore
#line 86 "H:\Dekstop\ZalohaEshop\EshopMike(1Shop)\Administration\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591