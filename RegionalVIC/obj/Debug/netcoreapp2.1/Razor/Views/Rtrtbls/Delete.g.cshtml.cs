#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719302efdf1bb56ff65153545077bc220505d2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rtrtbls_Delete), @"mvc.1.0.view", @"/Views/Rtrtbls/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rtrtbls/Delete.cshtml", typeof(AspNetCore.Views_Rtrtbls_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719302efdf1bb56ff65153545077bc220505d2f7", @"/Views/Rtrtbls/Delete.cshtml")]
    public class Views_Rtrtbls_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegionalVIC.Models.DB.Rtrtbl>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(66, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(95, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5549bf3d8664b849794260943228b9c", async() => {
                BeginContext(101, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            BeginContext(196, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(198, 1876, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e47a7393c3497cb4ff5466223c4d66", async() => {
                BeginContext(204, 150, true);
                WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Rtrtbl</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(355, 38, false);
#line 22 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(393, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(437, 34, false);
#line 25 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(471, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(515, 39, false);
#line 28 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(554, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(598, 35, false);
#line 31 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(633, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(677, 43, false);
#line 34 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(720, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(764, 39, false);
#line 37 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(803, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(847, 42, false);
#line 40 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
                EndContext();
                BeginContext(889, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(933, 38, false);
#line 43 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
                EndContext();
                BeginContext(971, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1015, 43, false);
#line 46 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(1058, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1102, 39, false);
#line 49 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(1141, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1185, 39, false);
#line 52 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(1224, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1268, 35, false);
#line 55 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(1303, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1347, 45, false);
#line 58 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(1392, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1436, 41, false);
#line 61 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1521, 41, false);
#line 64 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1562, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1606, 37, false);
#line 67 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1643, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1687, 42, false);
#line 70 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Median));

#line default
#line hidden
                EndContext();
                BeginContext(1729, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1773, 38, false);
#line 73 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Rtrtbls\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Median));

#line default
#line hidden
                EndContext();
                BeginContext(1811, 256, true);
                WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""Seq"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-default"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
            BeginContext(2074, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegionalVIC.Models.DB.Rtrtbl> Html { get; private set; }
    }
}
#pragma warning restore 1591
