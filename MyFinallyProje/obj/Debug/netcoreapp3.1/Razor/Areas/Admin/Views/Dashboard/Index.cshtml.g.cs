#pragma checksum "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58c63fd8cd1476f0fa8ca4d9a13c26d04a5faaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 4 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Areas\Admin\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Final-main\MyFinallyProje\Areas\Admin\Views\_ViewImports.cshtml"
using Utilities.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58c63fd8cd1476f0fa8ca4d9a13c26d04a5faaa", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733403832f5c3d64b86330f7f5b3308780f676c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

 <div class=""clearfix""></div>

    <div class=""content-wrapper"">
      <div class=""container-fluid"">
        <div class=""card mt-3"">
          <div class=""card-content"">
            <div class=""row row-group m-0"">
              <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                <div class=""card-body"">
                  <h5 class=""text-white mb-0"">9526 <span class=""float-right""><i class=""fa fa-shopping-cart""></i></span>
                  </h5>
                  <div class=""progress my-3"" style=""height:3px;"">
                    <div class=""progress-bar"" style=""width:55%""></div>
                  </div>
                  <p class=""mb-0 text-white small-font"">Total Orders <span class=""float-right"">+4.2% <i
                        class=""zmdi zmdi-long-arrow-up""></i></span></p>
                </div>
              </div>
              <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                <div class=""card-body"">
                  <h5 class=""text-white mb-0"">8323 <span class=""float-");
            WriteLiteral(@"right""><i class=""fa fa-usd""></i></span></h5>
                  <div class=""progress my-3"" style=""height:3px;"">
                    <div class=""progress-bar"" style=""width:55%""></div>
                  </div>
                  <p class=""mb-0 text-white small-font"">Total Revenue <span class=""float-right"">+1.2% <i
                        class=""zmdi zmdi-long-arrow-up""></i></span></p>
                </div>
              </div>
              <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                <div class=""card-body"">
                  <h5 class=""text-white mb-0"">6200 <span class=""float-right""><i class=""fa fa-eye""></i></span></h5>
                  <div class=""progress my-3"" style=""height:3px;"">
                    <div class=""progress-bar"" style=""width:55%""></div>
                  </div>
                  <p class=""mb-0 text-white small-font"">Visitors <span class=""float-right"">+5.2% <i
                        class=""zmdi zmdi-long-arrow-up""></i></span></p>
                </div>
              </di");
            WriteLiteral(@"v>
              <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                <div class=""card-body"">
                  <h5 class=""text-white mb-0"">5630 <span class=""float-right""><i class=""fa fa-envira""></i></span></h5>
                  <div class=""progress my-3"" style=""height:3px;"">
                    <div class=""progress-bar"" style=""width:55%""></div>
                  </div>
                  <p class=""mb-0 text-white small-font"">Messages <span class=""float-right"">+2.2% <i
                        class=""zmdi zmdi-long-arrow-up""></i></span></p>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class=""row"">
          <div class=""col-12 col-lg-8 col-xl-8"">
            <div class=""card"">
              <div class=""card-header"">Site Traffic
                <div class=""card-action"">
                  <div class=""dropdown"">
                    <a href=""javascript:void();"" class=""dropdown-toggle dropdown-toggle-nocaret"" data-toggle=""dropdown"">
     ");
            WriteLiteral(@"                 <i class=""icon-options""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                      <a class=""dropdown-item"" href=""javascript:void();"">Action</a>
                      <a class=""dropdown-item"" href=""javascript:void();"">Another action</a>
                      <a class=""dropdown-item"" href=""javascript:void();"">Something else here</a>
                      <div class=""dropdown-divider""></div>
                      <a class=""dropdown-item"" href=""javascript:void();"">Separated link</a>
                    </div>
                  </div>
                </div>
              </div>
              <div class=""card-body"">
                <ul class=""list-inline"">
                  <li class=""list-inline-item""><i class=""fa fa-circle mr-2 text-white""></i>New Visitor</li>
                  <li class=""list-inline-item""><i class=""fa fa-circle mr-2 text-light""></i>Old Visitor</li>
                </ul>
                <div class=""chart-container-1"">
");
            WriteLiteral(@"                  <canvas id=""chart1""></canvas>
                </div>
              </div>

              <div class=""row m-0 row-group text-center border-top border-light-3"">
                <div class=""col-12 col-lg-4"">
                  <div class=""p-3"">
                    <h5 class=""mb-0"">45.87M</h5>
                    <small class=""mb-0"">Overall Visitor <span> <i class=""fa fa-arrow-up""></i> 2.43%</span></small>
                  </div>
                </div>
                <div class=""col-12 col-lg-4"">
                  <div class=""p-3"">
                    <h5 class=""mb-0"">15:48</h5>
                    <small class=""mb-0"">Visitor Duration <span> <i class=""fa fa-arrow-up""></i> 12.65%</span></small>
                  </div>
                </div>
                <div class=""col-12 col-lg-4"">
                  <div class=""p-3"">
                    <h5 class=""mb-0"">245.65</h5>
                    <small class=""mb-0"">Pages/Visit <span> <i class=""fa fa-arrow-up""></i> 5.62%</span></small>
                ");
            WriteLiteral(@"  </div>
                </div>
              </div>
            </div>
          </div>
        </div>


        <!--End Dashboard Content-->

        <!--start overlay-->
        <div class=""overlay toggle-menu""></div>
        <!--end overlay-->

      </div>
      <!-- End container-fluid-->

    </div>
    <!--End content-wrapper-->

  </div>

  <!--Start Back To Top Button-->
  <a href=""javaScript:void();"" class=""back-to-top""><i class=""fa fa-angle-double-up""></i> </a>
  <!--End Back To Top Button-->



















hello");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591