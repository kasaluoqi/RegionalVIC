#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436c32359ac0130452ec856b73aded400ee2f1aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Job/Index.cshtml", typeof(AspNetCore.Views_Job_Index))]
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
#line 1 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml"
using RegionalVIC.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436c32359ac0130452ec856b73aded400ee2f1aa", @"/Views/Job/Index.cshtml")]
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(107, 374, true);
            WriteLiteral(@"<style>
    #message {
        display: none;
    }

    .axis-bottom .domain {
        display: none;
    }

    .n {
        opacity: .8;
        font-size: 10px;
        margin-left: 4px;
        font-family: sans-serif;
        color: white;
        padding: 6px;
        background-color: #3C3176;
    }
</style>

<!DOCTYPE html>
<html lang=""en"">
");
            EndContext();
            BeginContext(481, 2974, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0365410f66224742b334e57fe7ab64fb", async() => {
                BeginContext(487, 2961, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>RegionalVIC - Explore Regional Victoria</title>
    <!-- Fontawesome -->
    <link rel=""stylesheet"" href=""/fontawesome/css/font-awesome.min.css"">
    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <!-- Custom fonts for this template -->
    <link href=""/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>

    <link href='https://api.tiles.mapbox.com/mapbox-g");
                WriteLiteral(@"l-js/v0.53.1/mapbox-gl.css' rel='stylesheet' />
    <link rel='/stylesheet' href='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v3.1.6/mapbox-gl-geocoder.css' type='text/css' />

    <link href=""https://cdn.jsdelivr.net/npm/tailwindcss/dist/tailwind.min.css"" rel=""stylesheet"">

    <link href=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6/css/select2.min.css"" rel=""stylesheet"" />

    <!-- Bootstrap core JavaScript -->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Plugin JavaScript -->
    <script src=""/vendor/jquery-easing/jquery.easing.min.js""></script>
    <script src=""https://unpkg.com/tinyqueue@2.0.0/tinyqueue.min.js""></script>
    <script src=""/js/polylabel.js""></script>

    <script src='https://api.tiles.mapbox.com/mapbox-gl-js/v0.53.1/mapbox-gl.js'></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6/js/select2.min.js""></script>
    <script s");
                WriteLiteral(@"rc=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0""></script>

    <script src='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v3.1.6/mapbox-gl-geocoder.min.js'></script>

    <script src=""/Scripts/ion.rangeSlider.min.js""></script>
    <script src=""/Scripts/covervid.min.js""></script>
    <script src=""https://api.tiles.mapbox.com/mapbox.js/plugins/turf/v2.0.0/turf.min.js""></script>

    <script src=""https://d3js.org/d3.v5.min.js""></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/d3-tip/0.7.1/d3-tip.min.js'></script>

    <link href=""/css/rangeslider.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/css/css-loader.css"">

    <link rel=""stylesheet"" href=""/css/ion.rangeSlider.min.css"">

    <!-- Custom styles for this template -->
    <link href=""/css/agency.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"">
");
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
            BeginContext(3455, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3459, 15880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033c53aa9b5045e0a1ed834872923274", async() => {
                BeginContext(3465, 2560, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-dark fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""/"">RegionalVIC</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav text-uppercase ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/"">Home</a>
                    </li>

                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/News"">News</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
   ");
                WriteLiteral(@" <!-- Header -->
    <header class=""masthead"" style=""background-image: url('/img/map1.jpg');background-size: cover;"">
        <div class=""container"">
            <div class=""intro-normal"">

            </div>
        </div>
    </header>

    <div id=""first"">
        <div class=""container"">
            <h2>Multiple items selector with filter</h2>
            <div class=""form-group"">
                <select class=""js-example-basic-multiple col-12"" name=""industry[]"" multiple=""multiple"" id=""industry-list""></select>

                <select class=""js-example-basic-multiple col-12"" name=""region[]"" multiple=""multiple"" id=""region-list""></select>
            </div>
            <div class=""form-group"">

                <div class=""row"">
                    <button class=""btn btn-primary"" id=""nob-button"">Number of business</button>
                    <button class=""btn btn-primary"" id=""poe-button"">Proportion of employess</button>
                </div>
            </div>
        </div>
    </d");
                WriteLiteral(@"iv>


    <div id=""second"">
        <div id=""barchart""></div>
    </div>
    <div id=""third""></div>
    <!-- Footer -->
    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""copyright"">
                        Copyright &copy; RegionalVIC 2019. Theme is from <a href=""https://startbootstrap.com/themes/"">Start Bootstrap</a> website under MIT license.
                    </span>
                </div>
");
                EndContext();
                BeginContext(7416, 4297, true);
                WriteLiteral(@"            </div>
        </div>
    </footer>
    <script>

        function generateChart(data, name) {
            //if( $('#leftmenu').is(':empty') ) {
            $('#barchart').empty()
            const keys = Object.keys(data[0]).slice(1);

            const tip = d3.tip().html(d => d.value);

            const margin = {
                top: 40,
                right: 80,
                bottom: 20,
                left: 240
            },
                width = 800,
                height = 480,
                innerWidth = width - margin.left - margin.right,
                innerHeight = height - margin.top - margin.bottom;

            svg = d3.select('#barchart').append('svg').attr('width', width).attr('height', height)
            g = svg.append('g').attr('transform', `translate(${margin.left}, ${margin.top})`);

            svg.call(tip)

            const x0 = d3.scaleBand()
                .rangeRound([0, innerWidth])
                .paddingInner(.1);

      ");
                WriteLiteral(@"      const x1 = d3.scaleBand()
                .padding(.05);

            const y = d3.scaleLinear()
                .rangeRound([innerHeight, 0]);

            //const z = d3.scaleOrdinal()
            //    .range(['#AA8139', '#AA9439', '#3C3176', '#2C4770', '#96A537', '#68266F', '#492E74']);

            const z = d3.scaleOrdinal()
                .range([""#ca0020"", ""#f4a582"", ""#92c5de"", ""#0571b0"", '#68266F', '#492E74']);

            x0.domain(data.map(d => d.industry));
            x1.domain(keys).rangeRound([0, x0.bandwidth()]);
            y.domain([0, d3.max(data, d => d3.max(keys, key => d[key]))]).nice();

            g.append('g')
                .selectAll('g')
                .data(data)
                .enter()
                .append('g')
                .attr('transform', d => 'translate(' + x0(d.industry) + ',0)')
                .selectAll('rect')
                .data(d => keys.map(key => { return { key: key, value: d[key] } }))
                .enter().append('rec");
                WriteLiteral(@"t')
                .attr('x', d => x1(d.key))
                .attr('y', d => y(d.value))
                .attr('width', x1.bandwidth())
                .attr('height', d => innerHeight - y(d.value))
                .attr('fill', d => z(d.key))
                .on('mouseover', tip.show)
                .on('mouseout', tip.hide)

            g.append('g')
                .attr('class', 'axis-bottom')
                .attr('transform', 'translate(0,' + innerHeight + ')')
                .call(d3.axisBottom(x0));

            g.append('g')
                .attr('class', 'axis-left')
                .call(d3.axisLeft(y).ticks(null, 's'))
                .append('text')
                .attr('x', 10)
                .attr('y', y(y.ticks().pop()) + 10)
                .attr('dy', '0.32em')
                .attr('fill', '#000')
                .style('transform', 'rotate(-90deg)')
                .attr('font-weight', 'bold')
                .attr('text-anchor', 'end')
                .text(");
                WriteLiteral(@"name);

            const legend = g.append('g')
                .attr('font-family', 'sans-serif')
                .attr('font-size', 10)
                .attr('text-anchor', 'end')
                .selectAll('g')
                .data(keys.slice().reverse())
                .enter().append('g')
                .attr('transform', (d, i) => 'translate(0,' + i * 20 + ')');

            legend.append('rect')
                .attr('x', innerWidth - 19)
                .attr('width', 10)
                .attr('height', 10)
                .attr('fill', z);

            legend.append('text')
                .attr('x', innerWidth - 32)
                .attr('y', 6)
                .attr('dy', '0.32em')
                .text(d => d);
        }

        $(""#nob-button"").click(function () {
            $(""#loader"").addClass(""is-active"");

            //document.querySelector('#list-name').innerHTML = ""Rent"";
            //list.style.display = ""block"";
            //slist.style.display = ""n");
                WriteLiteral("one\";\r\n\r\n            var industry = $(\"#industry-list\").select2(\"val\");\r\n            var region = $(\"#region-list\").select2(\"val\");\r\n\r\n            $.ajax({\r\n                /**/\r\n                url: \'");
                EndContext();
                BeginContext(11714, 36, false);
#line 289 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml"
                 Write(Url.Action("getBarchartData", "Job"));

#line default
#line hidden
                EndContext();
                BeginContext(11750, 1572, true);
                WriteLiteral(@"',
                /**/
                type: 'POST',
                data: { industries: industry, regions: region, option: ""0"" },
                success: function (data) {
                    var tmpObj = JSON.parse(data);
                    var data = [];


                    var industries = [...new Set(tmpObj.map(x => x.IdsName))]

                    for (var i = 0; i < industries.length; i++) {

                        var dataObj = new Object;
                        dataObj[""industry""] = industries[i]

                        for (var j = 0; j < tmpObj.length; j++) {
                            var item = tmpObj[j];
                            if (item[""IdsName""] === industries[i]) {
                                dataObj[item[""LgaName""]] = item[""NoOfBsn""]
                            }
                        }

                        data.push(dataObj);
                    }

                    generateChart(data, 'Number of Business')
                    $(""#loader""");
                WriteLiteral(@").removeClass(""is-active"");

                },
            });
        
        });


        $(""#poe-button"").click(function () {
            $(""#loader"").addClass(""is-active"");

            //document.querySelector('#list-name').innerHTML = ""Rent"";
            //list.style.display = ""block"";
            //slist.style.display = ""none"";

            var industry = $(""#industry-list"").select2(""val"");
            var region = $(""#region-list"").select2(""val"");

            $.ajax({
                /**/
                url: '");
                EndContext();
                BeginContext(13323, 36, false);
#line 336 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml"
                 Write(Url.Action("getBarchartData", "Job"));

#line default
#line hidden
                EndContext();
                BeginContext(13359, 2164, true);
                WriteLiteral(@"',
                /**/
                type: 'POST',
                data: { industries: industry, regions: region, option: ""1"" },
                success: function (data) {
                    var tmpObj = JSON.parse(data);
                    var data = [];


                    var industries = [...new Set(tmpObj.map(x => x.IdsName))]

                    for (var i = 0; i < industries.length; i++) {

                        var dataObj = new Object;
                        dataObj[""industry""] = industries[i]

                        for (var j = 0; j < tmpObj.length; j++) {
                            var item = tmpObj[j];
                            if (item[""IdsName""] === industries[i]) {
                                dataObj[item[""LgaName""]] = item[""Proportion""]
                            }
                        }

                        data.push(dataObj);
                    }

                    generateChart(data, 'Proportion of Employee')
                    $(""#");
                WriteLiteral(@"loader"").removeClass(""is-active"");

                },
            });
        });

        $(""#industry-list"").change(function () {
            var ele = $(this);
            if (ele.val().length == 3) {
                ele.select2('close');
            }
        });
        $(""#region-list"").change(function () {
            var ele = $(this);
            if (ele.val().length == 3) {
                ele.select2('close');
            }
        });
        // In your Javascript (external .js resource or <script> tag)
        $(document).ready(function () {
            $('#region-list').select2({
                maximumSelectionLength: 3,
                minimumSelectionLength: 2,
                closeOnSelect: false
            });

            $('#industry-list').select2({
                maximumSelectionLength: 3,
                closeOnSelect: false
            });



            initIndustryList();
            initRegionList();
        });


        function initRegion");
                WriteLiteral("List() {\r\n            $(\"#region-list\").empty();\r\n            $.ajax({\r\n                /**/\r\n                url: \'");
                EndContext();
                BeginContext(15524, 34, false);
#line 405 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml"
                 Write(Url.Action("getAllRegions", "Map"));

#line default
#line hidden
                EndContext();
                BeginContext(15558, 851, true);
                WriteLiteral(@"',
                /**/
                type: 'POST',
                data: {},
                success: function (data) {
                    var list = JSON.parse(data);
                    for (var i = 0; i < list.length; i++) {
                        var item = list[i];
                        var value = item[""code""];
                        var label = item[""name""];
                        var o = new Option(value, value);
                        /// jquerify the DOM object 'o' so we can use the html method
                        $(o).html(label);
                        $(""#region-list"").append(o);
                    }
                },
            });

        }

        function initIndustryList() {
            $(""#industry-list"").empty();
            $.ajax({
                /**/
                url: '");
                EndContext();
                BeginContext(16410, 35, false);
#line 429 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Job\Index.cshtml"
                 Write(Url.Action("getAllIndustry", "Job"));

#line default
#line hidden
                EndContext();
                BeginContext(16445, 2577, true);
                WriteLiteral(@"',
                /**/
                type: 'POST',
                data: {},
                success: function (data) {
                    var list = JSON.parse(data);
                    for (var i = 0; i < list.length; i++) {
                        var value = list[i];

                        var o = new Option(value, value);
                        /// jquerify the DOM object 'o' so we can use the html method
                        $(o).html(value);
                        $(""#industry-list"").append(o);

                        //var newElement = '<div class=""items col-xs-4 col-sm-2 col-md-2 col-lg-2"">' +
                        //    '<div class=""info-block block-info clearfix"">' +
                        //    '<div data-toggle=""buttons"" class=""btn-group btn-group-toggle"">' +
                        //    '<label class=""btn btn-info"">' +
                        //    '<input type=""checkbox"" name=""options"" autocomplete=""off"">' + value +
                        //    '</label>' +");
                WriteLiteral(@"
                        //    '</div>' +
                        //    '</div>' +
                        //    '</div>';


                        //$('#industry-list').append(newElement);

                    }

                    //const max = 3;

                    //var $checkboxes = $(':checkbox').change(function (e) {
                    //    var checked = $checkboxes.filter(':checked').length;
                    //    //var maxChecked = checked === max;
                    //    // disable/enable others based on limit

                    //    //$checkboxes.not(':checked').prop('disabled', maxChecked);
                    //    if (checked > max) {
                    //        $(""#message"").slideDown();
                    //        $(this).closest('label').toggleClass('active', this.checked);
                    //        $(this).prop('checked', false);
                    //    } else {
                    //        $(""#message"").slideUp();
                    //    }
");
                WriteLiteral(@"                    //});



                },
            });

        }



        //$(function () {
        //    $('#search').on('keyup', function () {
        //        var pattern = $(this).val();
        //        $('.items-collection .items').hide();
        //        $('.items-collection .items').filter(function () {
        //            return $(this).text().match(new RegExp(pattern, 'i'));
        //        }).show();
        //    });
        //});
    </script>
    <!-- Load the File-->
");
                EndContext();
                BeginContext(19091, 241, true);
                WriteLiteral("\r\n    <!-- Contact form JavaScript -->\r\n    <script src=\"/js/jqBootstrapValidation.js\"></script>\r\n    <script src=\"/js/contact_me.js\"></script>\r\n    <!-- Custom scripts for this template -->\r\n    <script src=\"/js/agency.min.js\"></script>\r\n\r\n");
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
            BeginContext(19339, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
