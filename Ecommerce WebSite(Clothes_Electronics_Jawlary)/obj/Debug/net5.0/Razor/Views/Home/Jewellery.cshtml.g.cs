#pragma checksum "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "219401d5bdcfd78343b73ceea6ab66cb9e4aae4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Jewellery), @"mvc.1.0.view", @"/Views/Home/Jewellery.cshtml")]
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
#line 1 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\_ViewImports.cshtml"
using Ecommerce_WebSite_Clothes_Electronics_Jawlary_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\_ViewImports.cshtml"
using Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219401d5bdcfd78343b73ceea6ab66cb9e4aae4d", @"/Views/Home/Jewellery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99132fd248d73091f65406a25e4e6541c4dc54a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Jewellery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
  
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""fashion_section"">
    <div id=""main_slider"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <div class=""container"">
                    <div class=""fashion_section_2"">
                        <div class=""row"">
");
#nullable restore
#line 12 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-lg-4 col-sm-4\">\r\n                                    <div class=\"box_main\">\r\n                                        <h4 class=\"shirt_text\">");
#nullable restore
#line 16 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p class=\"price_text\"> Category : <span style=\"color: #262626;\">");
#nullable restore
#line 17 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
                                                                                                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <div class=\"tshirt_img\"><img");
            BeginWriteAttribute("src", " src=\"", 962, "\"", 1017, 1);
#nullable restore
#line 18 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
WriteAttributeValue("", 968, string.Format("/Images/{0}", @item.ProductImage), 968, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        <p class=\"price_text\">\r\n                                            Price :  <span style=\"color: #262626;\">");
#nullable restore
#line 20 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"
                                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Islam\Desktop\Simple Ecommerce WebSite\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Ecommerce WebSite(Clothes_Electronics_Jawlary)\Views\Home\Jewellery.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
