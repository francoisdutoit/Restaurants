#pragma checksum "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78633454cd60b53f5ddd020185812ac0644b155c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adapt.Web.Pages.Restaurants.Pages_Restaurants_RestaurantList), @"mvc.1.0.razor-page", @"/Pages/Restaurants/RestaurantList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/RestaurantList.cshtml", typeof(Adapt.Web.Pages.Restaurants.Pages_Restaurants_RestaurantList), null)]
namespace Adapt.Web.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\_ViewImports.cshtml"
using Adapt.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78633454cd60b53f5ddd020185812ac0644b155c", @"/Pages/Restaurants/RestaurantList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f38ee16b8b1e0eafdf8aacadd8368cbdd75996d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_RestaurantList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RestaurantsByPostalCode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnUseCurrentLocation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RestaurantsByCurrentPostalCode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AllRestaurants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
  
    ViewData["Title"] = "RestaurantList";

#line default
#line hidden
            BeginContext(113, 26, true);
            WriteLiteral("\r\n<h2>Restaurants</h2>\r\n\r\n");
            EndContext();
            BeginContext(139, 687, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea9dbbe93294c9eb6215a51ab3b6f15", async() => {
                BeginContext(159, 216, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"currentPostalCode\" />\r\n    <table style=\"margin-top:40px\">\r\n        <tr>\r\n            <td>Postal Code: <input type=\"text\" name=\"postalCode\" /></td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(375, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "583d0016742d4cb7b32624cd6fe8a1c8", async() => {
                    BeginContext(440, 6, true);
                    WriteLiteral("Search");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(455, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(510, 131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d2698fdb4143049d365d41f1e0c046", async() => {
                    BeginContext(609, 23, true);
                    WriteLiteral("Use my current location");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(641, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(696, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc68737639434ad09e1a1b83f3cdaefa", async() => {
                    BeginContext(752, 8, true);
                    WriteLiteral("Show All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(769, 50, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 110, true);
            WriteLiteral("\r\n<table class=\"table\" style=\"margin-top:40px\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(937, 68, false);
#line 30 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].RestaurantLogoName));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1061, 64, false);
#line 33 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1181, 60, false);
#line 36 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].BranchName));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1297, 66, false);
#line 39 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].BranchStreetName));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1419, 68, false);
#line 42 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].BranchStreetNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1543, 62, false);
#line 45 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].BranchSuburb));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1661, 66, false);
#line 48 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].BranchPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1783, 61, false);
#line 51 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].OpeningTime));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1900, 61, false);
#line 54 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant[0].ClosingTime));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
         foreach (var item in Model.Restaurant)
        {

#line default
#line hidden
            BeginContext(2107, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2171, "\"", 2228, 1);
#line 64 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
WriteAttributeValue("", 2177, Url.Content("~/images/" + item.RestaurantLogoName), 2177, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2229, 70, true);
            WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2300, 49, false);
#line 67 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2417, 45, false);
#line 70 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchName));

#line default
#line hidden
            EndContext();
            BeginContext(2462, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2530, 51, false);
#line 73 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchStreetName));

#line default
#line hidden
            EndContext();
            BeginContext(2581, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2649, 53, false);
#line 76 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchStreetNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2702, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2770, 47, false);
#line 79 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchSuburb));

#line default
#line hidden
            EndContext();
            BeginContext(2817, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2885, 51, false);
#line 82 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3004, 46, false);
#line 85 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpeningTime));

#line default
#line hidden
            EndContext();
            BeginContext(3050, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3118, 46, false);
#line 88 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ClosingTime));

#line default
#line hidden
            EndContext();
            BeginContext(3164, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 91 "C:\Users\franc\Desktop\AdaptITProject\Adapt.Restaurants\Adapt.Web\Pages\Restaurants\RestaurantList.cshtml"
        }

#line default
#line hidden
            BeginContext(3219, 198, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div id=\"restaurantMap\" style=\"display:none\"></div>\r\n<script type=\'text/javascript\' src=\'https://www.bing.com/api/maps/mapcontrol?callback=GetMap\' async defer></script>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Adapt.Web.Pages.Restaurants.RestaurantListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Adapt.Web.Pages.Restaurants.RestaurantListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Adapt.Web.Pages.Restaurants.RestaurantListModel>)PageContext?.ViewData;
        public Adapt.Web.Pages.Restaurants.RestaurantListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591