#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6417805a258c94298cbfec2a64f45fe4a1d1d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rtrtbls_Index), @"mvc.1.0.view", @"/Views/Rtrtbls/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rtrtbls/Index.cshtml", typeof(AspNetCore.Views_Rtrtbls_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6417805a258c94298cbfec2a64f45fe4a1d1d99", @"/Views/Rtrtbls/Index.cshtml")]
    public class Views_Rtrtbls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RegionalVIC.Models.DB.Rtrtbl>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(108, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c39cfd9bc494fb59388929ee2439fda", async() => {
                BeginContext(114, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(210, 2284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ca0e604f4b4ee8b6fb75e9a278b3ea", async() => {
                BeginContext(216, 140, true);
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(357, 38, false);
#line 22 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(395, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(451, 39, false);
#line 25 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(490, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(546, 43, false);
#line 28 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(589, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(645, 42, false);
#line 31 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
                EndContext();
                BeginContext(687, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(743, 43, false);
#line 34 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(786, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(842, 39, false);
#line 37 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(881, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(937, 45, false);
#line 40 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(982, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1038, 41, false);
#line 43 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1079, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1135, 42, false);
#line 46 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Median));

#line default
#line hidden
                EndContext();
                BeginContext(1177, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 52 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(1295, 50, true);
                WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1346, 37, false);
#line 56 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(1383, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1439, 38, false);
#line 59 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1533, 42, false);
#line 62 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(1575, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1631, 41, false);
#line 65 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
                EndContext();
                BeginContext(1672, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1728, 42, false);
#line 68 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1826, 38, false);
#line 71 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(1864, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1920, 44, false);
#line 74 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(1964, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2020, 40, false);
#line 77 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
                EndContext();
                BeginContext(2060, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2116, 41, false);
#line 80 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Median));

#line default
#line hidden
                EndContext();
                BeginContext(2157, 75, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2232, "\"", 2256, 1);
#line 83 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
WriteAttributeValue("", 2247, item.Seq, 2247, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2257, 52, true);
                WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2309, "\"", 2333, 1);
#line 84 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
WriteAttributeValue("", 2324, item.Seq, 2324, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2334, 54, true);
                WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2388, "\"", 2412, 1);
#line 85 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
WriteAttributeValue("", 2403, item.Seq, 2403, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2413, 47, true);
                WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 88 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Index.cshtml"
}

#line default
#line hidden
                BeginContext(2463, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2494, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RegionalVIC.Models.DB.Rtrtbl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
