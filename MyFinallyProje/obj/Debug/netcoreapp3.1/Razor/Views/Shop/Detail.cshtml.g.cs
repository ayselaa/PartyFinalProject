#pragma checksum "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34cedd29c441e48b7a0e1cb19799d5ab09752de9"
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
#line 5 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\_ViewImports.cshtml"
using Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\_ViewImports.cshtml"
using DAL.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\_ViewImports.cshtml"
using Business.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34cedd29c441e48b7a0e1cb19799d5ab09752de9", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbf655c22fc9720b5f4720c166d34c13a263534", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/products/part-shop-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/products/party-shop.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/products/party-shop-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/products/party-shop-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
  
    Layout = "_SecondLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n<main> \n \n       \n     <section class=\"book-content\">\n      <div class=\"container\">\n");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
              foreach (var pro in Model.ProductImage.Where(n => n.ProductId== Model.Id))
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"imggggggg\">\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cedd29c441e48b7a0e1cb19799d5ab09752de96891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 291, "~/assets/uploads/images/", 291, 24, true);
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 315, pro.Image.Url, 315, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n          </div>\n");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \n          <div class=\"book-details\">\n              <div class=\"details\">\n                  <h1>");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                  <ul>\n                      <li>Product Name : &nbsp;<span>");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </li>\n                      <li>Category:  &nbsp;<span>Party Shop Accesuares</span></li>\n                      <li>Price: &nbsp; <span>$");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                  </ul>
              </div>
              <div class=""Add-Cart"">
                 
                  <div class=""btn-cart"">
                        <a class=""btn btn-primary addtobasket text-white ml-5 mt-5"">
                            Add To Cart
                        </a>
                      <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 1068, "\"", 1085, 1);
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 1076, Model.Id, 1076, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                  </div>\n              </div>\n              <div class=\"buy-it-now\">\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cedd29c441e48b7a0e1cb19799d5ab09752de910473", async() => {
                WriteLiteral("Back Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              </div>    
          </div>

      </div>
  </section>
  <section class=""tabs"">
      <div class=""container"">
          <div class=""tabset"">
              <input type=""radio"" name=""tabset"" id=""tab1"" aria-controls=""description"" checked>
              <label for=""tab1"">DESCRIPTION</label>
              <input type=""radio"" name=""tabset"" id=""tab2"" aria-controls=""bookInformation"">
              <label for=""tab2"">INFORMATION</label>
  
              <div class=""tab-panels"">
                  <div id=""description"" class=""tab-panel"">
                      <h2>");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Shop\Detail.cshtml"
                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi dolorem ut deserunt
                          soluta libero voluptatum mollitia illum sapiente aut natus enim vitae reiciendis,
                          magnam, laborum quidem fugiat molestias officiis. Sit eum tenetur tempore ipsam
                          molestias doloribus mollitia incidunt dolore, doloremque ducimus aliquam laborum magnam
                          aperiam, atque officia deserunt odio! Velit!</p>
                  </div>
                  <div id=""bookInformation"" class=""tab-panel"">

                      <p><strong>Name:</strong>Flowers</p>
                      <p><strong>Category:</strong>Accesuares</p>
                      <p><strong>Color:</strong> Red</p>

                  </div>
              </div>
          </div>
      </div>
  </section>

  <section class=""related-books"">
      <div class=""container"">
          <div class=""related-title"">
              <h1>RELATED PRODUCTS</h1>
");
            WriteLiteral(@"          </div>
          <div class=""row"">
              <div class=""col col-lg-3 col-md-6 col-sm-12"">
                  <div class=""card"">
                      <div class=""face face1"">
                          <div class=""content"">
                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cedd29c441e48b7a0e1cb19799d5ab09752de914100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                      </div>
                      <div class=""face face2"">
                          <div class=""content"">
                              <div class=""content-info text-danger font-weight-bold"">
                                    <span style=""font-size=30px;"">GIFT BOX</span>
                              </div>
                            </div>
                      </div>
                  </div>
              </div>
              <div class=""col col-lg-3 col-md-6 col-sm-12"">
                  <div class=""card"">
                      <div class=""face face1"">
                          <div class=""content"">
                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cedd29c441e48b7a0e1cb19799d5ab09752de915840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                      </div>
                      <div class=""face face2"">
                          <div class=""content"">
                              <div class=""content-info text-danger font-weight-bold"">
                                    <span>CAKE</span>
                              </div>
                            </div>
                      </div>
                  </div>
              </div>
              <div class=""col col-lg-3 col-md-6 col-sm-12"">
                  <div class=""card"">
                      <div class=""face face1"">
                          <div class=""content"">
                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cedd29c441e48b7a0e1cb19799d5ab09752de917550", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                      </div>
                      <div class=""face face2"">
                          <div class=""content"">
                              <div class=""content-info text-danger font-weight-bold"">
                                    <span>CAKE</span>
                              </div>
                            </div>
                      </div>
                  </div>
              </div>
              <div class=""col col-lg-3 col-md-6 col-sm-12"">
                  <div class=""card"">
                      <div class=""face face1"">
                          <div class=""content"">
                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cedd29c441e48b7a0e1cb19799d5ab09752de919260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                      </div>
                      <div class=""face face2"">
                          <div class=""content"">
                              <div class=""content-info text-danger font-weight-bold"">
                                    <span>Flowers</span>
                              </div>
                         </div>
                  </div>
              </div>
          </div>
      </div>
  </section>




  </main>
");
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
