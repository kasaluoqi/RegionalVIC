#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\locations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58361f30d2ea63e3fea621ff2cb63729b71206e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_locations_Index), @"mvc.1.0.view", @"/Views/locations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/locations/Index.cshtml", typeof(AspNetCore.Views_locations_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58361f30d2ea63e3fea621ff2cb63729b71206e1", @"/Views/locations/Index.cshtml")]
    public class Views_locations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RegionalVIC.Models.location>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/location.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\locations\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 105, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<div id=\"map\" style=\"height:500px\"></div>\r\n<div id=\'geocoder\' class=\'geocoder\'></div>\r\n");
            EndContext();
            BeginContext(309, 16, true);
            WriteLiteral("<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(325, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073fe6d73d28437d96aa324d44a9960c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(372, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18f546cf2be44bb3a485041aac6bf594", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(421, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(501, 1453, true);
            WriteLiteral(@"<script src='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v3.1.3/mapbox-gl-directions.js'></script>
<link rel='stylesheet' href='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v3.1.3/mapbox-gl-directions.css' type='text/css' />

<div class=""col-sm-6"">
    <div class=""form-group"">

    </div>
</div>
<div class=""col-sm-6"">
    <br />
    <br />
    <br />
</div>


<script>
    var counter = 0;
    $('.multi-field-wrapper').each(function () {
        var $wrapper = $('.multi-fields', this);
        $("".add-field"", $(this)).click(function (e) {
            counter++;
            $('.multi-field:first-child', $wrapper).clone(true).appendTo($wrapper).find('location').val('').focus();
        });
        $('.multi-field .remove-field', $wrapper).click(function () {
            if ($('.multi-field', $wrapper).length > 1)
                $(this).parent('.multi-field').remove();
        });
    });
    document.getElementById('form-trip')
        .addEv");
            WriteLiteral(@"entListener('click', function () {
            console.log(""form a trip"");
            var list = $('.multi-field-wrapper .multi-field .tmp');
            var counter = 0;
            var length = list.length;
            for (var e of list) {
                clearDropoff();
                var value = e.options[e.selectedIndex].value;
                var lat, lng;
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(1955, 36, false);
#line 59 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\locations\Index.cshtml"
                     Write(Url.Action("getLatLng", "locations"));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 827, true);
            WriteLiteral(@"',
                    type: 'POST',
                    data: ""{id:'"" + value + ""', counter:'"" + counter + ""'}"",
                    contentType: 'Application/json',
                    success: function(result)
                    {
                        var array = result.split("";"");
                        newDropoff([array[0], array[1]], array[2], length);
                    }
                });
                counter++;
            }


        });

    document.getElementById('show-trip')
        .addEventListener('click', function () {
            console.log(""show a saved trip"");
            var list = $('.form-group .form-control');

            for (var e of list) {
                var value = e.options[e.selectedIndex].value;
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(2819, 34, false);
#line 83 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\locations\Index.cshtml"
                     Write(Url.Action("getTrip", "locations"));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 444, true);
            WriteLiteral(@"',
                    type: 'POST',
                    data: ""{route_id:'"" + value + ""'}"",
                    contentType: 'Application/json',
                    success: function(data)
                    {
                        showSavedTrip(JSON.parse(data));
                        //newDropoff([array[0], array[1]], array[2], length);
                    }
                });
            }


        });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RegionalVIC.Models.location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
