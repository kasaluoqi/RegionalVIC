#pragma checksum "C:\Users\kasal\Source\Repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbf9a65ba199b6d5cdfd38e0902eacec5e6af25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbf9a65ba199b6d5cdfd38e0902eacec5e6af25", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\kasal\Source\Repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(41, 538, true);
            WriteLiteral(@"<style>

    .vidheader {
        position: relative;
        width: 100%;
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
        overflow: hidden;
    }

    video {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        min-width: 100%;
        min-height: 100%;
        z-index: -1;
        object-position: center;
        object-fit: cover;
    }
</style>
<!DOCTYPE html>
<html lang=""en"">
");
            EndContext();
            BeginContext(579, 1103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948c20bf289e47a393db4a4f9b453700", async() => {
                BeginContext(585, 1090, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>RegionalVIC - A guide to moving to regional Victoria</title>
    <!-- Bootstrap core CSS -->
    <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Custom fonts for this template -->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>
    <!-- Custom styles for this tem");
                WriteLiteral("plate -->\r\n    <link href=\"css/agency.min.css\" rel=\"stylesheet\">\r\n");
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
            BeginContext(1682, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1684, 10527, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e72722c55774336ae6dc1dc18946b90", async() => {
                BeginContext(1704, 8663, true);
                WriteLiteral(@"
    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">RegionalVIC</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav text-uppercase ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#about"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#team"">Team</a>
                    </li>

                    <li class=""nav-");
                WriteLiteral(@"item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/Map"">Map</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/News"">News</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Header -->
    <header class=""masthead"">
        <div class=""vidheader"">
            <div class='container'>
                <video poster=""/img/river-poster.jpg"" id=""bgvid"" playsinline autoplay muted loop>
                    <source src=""/video/loop.mp4"" type=""video/mp4"">
                </video>
                <div class=""intro-text"">
                    <div class=""intro-lead-in"">Welcome To RegionalVIC!</div>
                    <div class=""intro-heading text-uppercase"">Wanna move to regional Victoria?</div>
                    <a class=""btn btn-primary btn-xl text-uppercase js-scroll-trigger"" href=""/Map/index""><i>Let's go!</i></a>
               ");
                WriteLiteral(@" </div>
            </div>
        </div>
    </header>
    <!-- About -->
    <section id=""about"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h2 class=""section-heading text-uppercase"">About</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <ul class=""timeline"">
                        <li>
                            <div class=""timeline-image"">
                                <img class=""rounded-circle img-fluid"" src=""img/about/a1.jpg"" alt="""">
                            </div>
                            <div class=""timeline-panel"">
                                <div class=""timeline-heading"">
                                    <h4 class=""subheading"">Background</h4>
                                </div>
                                <div class=""timeline-body"">
                                    <p cla");
                WriteLiteral(@"ss=""text-muted"">Over-population is one of the issues in Melbourne. Besides, for international graduates, many competitors are in the application of skilled immigration visa. As a result, it becomes more challenging for international graduates who want to live in Australia permanently. </p>
                                </div>
                            </div>
                        </li>
                        <li class=""timeline-inverted"">
                            <div class=""timeline-image"">
                                <img class=""rounded-circle img-fluid"" src=""img/about/a2.jpg"" alt="""">
                            </div>
                            <div class=""timeline-panel"">
                                <div class=""timeline-heading"">
                                    
                                    <h4 class=""subheading"">What we provide</h4>
                                </div>
                                <div class=""timeline-body"">
                               ");
                WriteLiteral(@"     <p class=""text-muted"">RegionalVIC - provides the key information for international graduates who consider moving to regional Victoria. Our website analyzes their requirements such as accommodation and safety to provide the suggestion of suitable areas to live in. </p>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class=""timeline-image"">
                                <img class=""rounded-circle img-fluid"" src=""img/about/a3.jpg"" alt="""">
                            </div>
                            <div class=""timeline-panel"">
                                <div class=""timeline-heading"">
                                    <h4 class=""subheading"">Value</h4>
                                </div>
                                <div class=""timeline-body"">
                                    <p class=""text-muted"">Mitigate the over-population issue in Melbourne. Help internatio");
                WriteLiteral(@"nal graduates to decide on a suitable region to live. Coordinate with the new immigration policy of Australian government - encourage new immigrants to move to regional areas. </p>
                                </div>
                            </div>
                        </li>
                        <li class=""timeline-inverted"">
                            <div class=""timeline-image"">
                                <h4>
                                    Be Part
                                    <br>Of Our
                                    <br>Story!
                                </h4>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!-- Team -->
    <section class=""bg-light"" id=""team"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h2 class=""section-heading text-upp");
                WriteLiteral(@"ercase"">Our Amazing Team</h2>
                    <h3 class=""section-subheading text-muted""><a href=""http://www.freepik.com"">Avatar Designed by Freepik.</a></h3>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <div class=""team-member"">
                        <img class=""mx-auto rounded-circle"" src=""img/team/1.png"" style=""width:200px;height:200px;"" alt="""">
                        <h4>Sam</h4>
                        <p class=""text-muted"">Developer</p>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""team-member"">
                        <img class=""mx-auto rounded-circle"" src=""img/team/2.png"" style=""width:200px;height:200px;""  alt="""">
                        <h4>Mahi</h4>
                        <p class=""text-muted"">Business Analyst</p>
                    </div>
                </div>
                <div class=""col"">
                    <div cl");
                WriteLiteral(@"ass=""team-member"">
                        <img class=""mx-auto rounded-circle"" src=""img/team/3.png"" style=""width:200px;height:200px;"" alt="""">
                        <h4>Thea</h4>
                        <p class=""text-muted"">Business Analyst</p>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""team-member"">
                        <img class=""mx-auto rounded-circle"" src=""img/team/4.png"" style=""width:200px;height:200px;"" alt="""">
                        <h4>Tonya</h4>
                        <p class=""text-muted"">Data Analyst</p>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""team-member"">
                        <img class=""mx-auto rounded-circle"" src=""img/team/5.png"" style=""width:200px;height:200px;"" alt="""">
                        <h4>Alan</h4>
                        <p class=""text-muted"">Cybersecurity Specialist</p>
                    </div>
          ");
                WriteLiteral(@"      </div>
            </div>
        </div>
    </section>
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
                BeginContext(11646, 558, true);
                WriteLiteral(@"            </div>
        </div>
    </footer>
    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Plugin JavaScript -->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>
    <!-- Contact form JavaScript -->
    <script src=""js/jqBootstrapValidation.js""></script>
    <script src=""js/contact_me.js""></script>
    <!-- Custom scripts for this template -->
    <script src=""js/agency.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12211, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
