#pragma checksum "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0fa0dd0b01eae1354635448f6654ce96b25109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0fa0dd0b01eae1354635448f6654ce96b25109", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbf655c22fc9720b5f4720c166d34c13a263534", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about/maskedballmonaco.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about/new year.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/gallery-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about/about-1.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("     \n");
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
       
        Layout = "_Layout";
     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      <section id=""Digital"" class=""salam1"">
           <div class=""container"">
            <div data-aos=""fade"" class=""digital-text"">
                <hr>
                <h2 >Event Management<br>System.</h2>
            </div>

            <div data-aos=""fade-up"" class=""Box1 row"">

");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                     foreach (var boxs in Model.HomeBoxes)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  <div class=""box box1 col-md-4"">
                        <div class=""box-icon mb-5"">
                          <i class=""fa-solid fa-thumbtack""></i>
                          </div>
                        <div class=""box-text"">
                                <h4>");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                               Write(boxs.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <hr>\n                                <p>");
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                              Write(boxs.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                          </div>\n                    </div>\n");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </div>
                        </div>
            </section>

    <section id=""Services"">
      <div class=""container"">
        <div data-aos=""flip-up"" class=""services-text ml-4 mb-5"">
          <hr>
          <h2>EVENTS.</h2>
          <h4>WE PLAN THE BEST EVENTS!</h4>
        </div>
        <div data-aos=""fade-left"" class=""navbar"">

");
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
             foreach (Service events in Model.Services)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"col-md-4 mb-4\">\n                <div class=\"middle row justify-content-between\">\n                    <div class=\"col-text\">\n               \n\n                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0fa0dd0b01eae1354635448f6654ce96b251099315", async() => {
                WriteLiteral("\n                                <h5>");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                               Write(events.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                                                                            WriteLiteral(events.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    \n                      </div>\n                      <div class=\"col-icon\">\n                        <i class=\"fas fa-arrow-right\"></i>\n                      </div>\n                </div>\n              </div>\n");
#nullable restore
#line 59 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
             


        </div>
        <div class=""midhr mt-5 mb-5"">
            <hr>
         </div>
      </div>
    </section>

    <section id=""Works"">
      <div class=""container"">
          <div class=""works-contain row justify-content-between"">
              <div data-aos=""fade-right"" class=""works-text"">
                  <hr>
                  <h2>Gallery.</h2>
                  <h4>Unforgettable Memories...</h4>
                </div>
          </div>
        </div>
    </section>



    <section id=""Shoes"">

      <div class=""shoes-contain row"">

");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                   foreach (var gallery in Model.Galleries)
                 {


#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"black-fon\">\n                <div class=\"black-fon-img\">\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510913365", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2677, "~/assets/img/gallery/", 2677, 21, true);
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2698, gallery.GalleryImage.Where(n => n.GalleryId == gallery.Id).FirstOrDefault().Image.Url, 2698, 86, false);

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
            WriteLiteral("\n                </div>\n                <div class=\"black-fon-text\">\n                    <h3>");
#nullable restore
#line 97 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                   Write(gallery.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p></p>\n                </div>\n              </div>\n");
#nullable restore
#line 101 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                     
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      </div>
      <div class=""midhr mt-5"">
        <hr>
      </div>
    </section>



    <section id=""About"">
      <div class=""container"">
          <div class=""about-text row justify-content-between"">
              <div data-aos=""fade-right"" class=""col-md-4 about-left"">
                  <hr>
                  <h2>About.</h2>
                  <h4>Our System</h4>
              </div>
          </div>
          <div data-aos=""fade-right"" class=""about-img row"">
            <div class=""col-md-8 img-left pb-4"">
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510916189", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              <div class=""img-text"">
                  <h4>??oncept</h4>
                  <p>Committed and creative</p>
              </div>
            </div>
            <div data-aos=""fade-left"" class=""col-md-4 img-right"">
              <div class=""right1"">  
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510917595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"img-text1\">\n                    <h4>New Year</h4>\n                    <p>Premium Party</p>\n                </div>\n              </div>\n              <div class=\"right2 pt-4\">   \n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510918940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n          <div class=\"img-text2\">\n              <h4>The Fun With Us!</h4>\n              <p>Berlin, UK</p>\n          </div>\n        </div>\n              <div class=\"right2 pt-4\">   \n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510920266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""img-text2"">
                    <h4>Concept</h4>
                    <p>Azerbaijan, Baku</p>
                </div>
              </div>
            </div>
          </div>
        </div>
    </section>

    <section id=""Eventabout"">
      <div class=""container"">
        <div class=""row"">
            <div data-aos=""fade-up"" id=""Ab1"" class=""col-md-4"">
            <div class=""ngtn"">
              <h2>History</h2>
              <br>
              Bizim te??kilat???? ??irk??timiz 2022-ci ild??n  <br>
              f??aliyy??t g??st??rir
            </div>
          </div>
            <div data-aos=""fade-up"" id=""Ab2"" class=""col-md-4"">
                  <div class=""ngtn"">
                    <h2>Who we are?</h2>
                    <br>
                    H??m professional kollektiv hem de uy??un qiym??tl??ri il?? ??irk??timiz 
                    m????t??ril??rin g??v??nini qazanm???? ??irk??tl??r aras??ndad??r.??n keyfiyy??tli 
                    xidmetl?? f??aliyyet g??st??r??n ??irk??timiz daim sizin xidm??tinizd??dir.
 ");
            WriteLiteral(@"                 </div>
                </div>
            <div data-aos=""fade-up"" id=""Ab3"" class=""col-md-4"">
                  <div class=""ngtn"">
                    <h2>Our Mission</h2>
                    <br>
                    <ul>

                      <li>
                          Keyfiyyetli xidm??t
                      </li>

                      <li>
                          Bol ??yl??nc??
                      </li>

                      <li>
                          M????t??ri m??mnuniyy??ti
                      </li>

                      <li>
                         G??ncl??rin aktivliyini art??rmaq
                      </li>
                    </ul>
                  
                  </div>
                </div>
                 </div>
     </div>
    </section>

    <section id=""Latest"">
      <div data-aos=""flip-up"" class=""latest-text text-center mb-5"">
        <h2>News / Blog</h2>
        <h4>WORKING WITH EXCELLENT</h4>
      </div>
      <div class=""latest-img row"">


");
#nullable restore
#line 213 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
        foreach (var itemm in Model.Blogs)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div data-aos=\"flip-left\" class=\"col-md-4 latest-img-1 text-center\">\n");
#nullable restore
#line 216 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
              foreach (var images in itemm.BlogImage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"latest-img1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b0fa0dd0b01eae1354635448f6654ce96b2510924108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6822, "~/assets/img/blogsekilleri/", 6822, 27, true);
#nullable restore
#line 219 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6849, images.Image.Url, 6849, 17, false);

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
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 221 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          <div class=\"latest-text1-contain\">\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0fa0dd0b01eae1354635448f6654ce96b2510925987", async() => {
                WriteLiteral("<h3>");
#nullable restore
#line 225 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                                                                                   Write(itemm.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 225 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
                                                            WriteLiteral(itemm.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n              <i class=\"fas fa-long-arrow-alt-right\"></i>\n          </div>\n        </div>\n");
#nullable restore
#line 229 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Views\Home\Index.cshtml"
          
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


      </div>
      <div class=""midhr mt-5"">
        <hr>
     </div>
    </section>

    <section id=""Brands"">
      <div class=""container"">
        <div class=""brand-line mb-5"">
          <hr>
        </div>
        <div class=""brand-name row"">
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/01.png"">
          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/02.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/03.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/04.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2");
            WriteLiteral(@"019/01/05.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/06.png"">

          </div>
           <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/01.png"">
          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/02.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/03.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/04.png"">

          </div>
          <div class=""brand-name1"">
              <img class=""img-fluid"" src=""http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/05.png"">

          </div>
          <div cla");
            WriteLiteral("ss=\"brand-name1\">\n              <img class=\"img-fluid\" src=\"http://gentium.pixerex.com/wp/wp-content/uploads/2019/01/06.png\">\n\n          </div>\n        </div>\n        <div class=\"midhr mt-3\">\n         </div>\n      </div>\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
