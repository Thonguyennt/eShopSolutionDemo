#pragma checksum "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolution.WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de0fb1af3b39b94bdb453edc6f19ace5e680e292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0fb1af3b39b94bdb453edc6f19ace5e680e292", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"323470ff8edcca0996d66cb77d9a2609deebb167", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("products.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal loginFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e2925130", async() => {
                WriteLiteral("\r\n\t<meta charset=\"utf-8\">\r\n\t<title>Bootshop online Shopping cart</title>\r\n\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\t<meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 213, "\"", 223, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 247, "\"", 257, 0);
                EndWriteAttribute();
                WriteLiteral(@">
	<!--Less styles -->
	<!-- Other Less css file //different less files has different color scheam
	 <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/simplex.less"">
	 <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/classified.less"">
	 <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/amelia.less"">  MOVE DOWN TO activate
	 -->
	<!--<link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/bootshop.less"">
	<script src=""/themes/js/less.js"" type=""text/javascript""></script> -->
	<!-- Bootstrap style -->
	<link id=""callCss"" rel=""stylesheet"" href=""/themes/bootshop/bootstrap.min.css"" media=""screen"" />
	<link href=""/themes/css/base.css"" rel=""stylesheet"" media=""screen"" />
	<!-- Bootstrap style responsive -->
	<link href=""/themes/css/bootstrap-responsive.min.css"" rel=""stylesheet"" />
	<link href=""/themes/css/font-awesome.css"" rel=""stylesheet"" type=""text/css"">
	<!-- Google-code-prettify -->
	<link href=""/themes/js/google-code-prettify/prettify.css"" rel=""styles");
                WriteLiteral(@"heet"" />
	<!-- fav and touch icons -->
	<link rel=""shortcut icon"" href=""/themes/images/ico/favicon.ico"">
	<link rel=""apple-touch-icon-precomposed"" sizes=""144x144"" href=""/themes/images/ico/apple-touch-icon-144-precomposed.png"">
	<link rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""/themes/images/ico/apple-touch-icon-114-precomposed.png"">
	<link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""/themes/images/ico/apple-touch-icon-72-precomposed.png"">
	<link rel=""apple-touch-icon-precomposed"" href=""/themes/images/ico/apple-touch-icon-57-precomposed.png"">
	<style type=""text/css"" id=""enject""></style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e2928397", async() => {
                WriteLiteral("\r\n\t<div id=\"header\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div id=\"welcomeLine\" class=\"row\">\r\n\t\t\t\t<div class=\"span6\">Welcome!<strong> User</strong></div>\r\n\t\t\t\t<div class=\"span6\">\r\n\t\t\t\t\t<div class=\"pull-right\">\r\n\t\t\t\t\t\t<a href=\"product_summary.html\"><span");
                BeginWriteAttribute("class", " class=\"", 2170, "\"", 2178, 0);
                EndWriteAttribute();
                WriteLiteral(">Fr</span></a>\r\n\t\t\t\t\t\t<a href=\"product_summary.html\"><span");
                BeginWriteAttribute("class", " class=\"", 2237, "\"", 2245, 0);
                EndWriteAttribute();
                WriteLiteral(">Es</span></a>\r\n\t\t\t\t\t\t<span class=\"btn btn-mini\">En</span>\r\n\t\t\t\t\t\t<a href=\"product_summary.html\"><span>&pound;</span></a>\r\n\t\t\t\t\t\t<span class=\"btn btn-mini\">$155.00</span>\r\n\t\t\t\t\t\t<a href=\"product_summary.html\"><span");
                BeginWriteAttribute("class", " class=\"", 2460, "\"", 2468, 0);
                EndWriteAttribute();
                WriteLiteral(@">$</span></a>
						<a href=""product_summary.html""><span class=""btn btn-mini btn-primary""><i class=""icon-shopping-cart icon-white""></i> [ 3 ] Itemes in your cart </span> </a>
					</div>
				</div>
			</div>
			<!-- Navbar ================================================== -->
			<div id=""logoArea"" class=""navbar"">
				<a id=""smallScreen"" data-target=""#topMenu"" data-toggle=""collapse"" class=""btn btn-navbar"">
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
				</a>
				<div class=""navbar-inner"">
					<a class=""brand"" href=""index.html""><img src=""/themes/images/logo.png"" alt=""Bootsshop"" /></a>
					");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29210447", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t<input id=\"srchFld\" class=\"srchTxt\" type=\"text\" />\r\n\t\t\t\t\t\t<select class=\"srchTxt\">\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29210842", async() => {
                        WriteLiteral("All");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29211924", async() => {
                        WriteLiteral("CLOTHES ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29213011", async() => {
                        WriteLiteral("FOOD AND BEVERAGES ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29214109", async() => {
                        WriteLiteral("HEALTH & BEAUTY ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29215204", async() => {
                        WriteLiteral("SPORTS & LEISURE ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29216300", async() => {
                        WriteLiteral("BOOKS & ENTERTAINMENTS ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t<button type=\"submit\" id=\"submitButton\" class=\"btn btn-primary\">Go</button>\r\n\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t<ul id=\"topMenu\" class=\"nav pull-right\">\r\n\t\t\t\t\t\t<li");
                BeginWriteAttribute("class", " class=\"", 3725, "\"", 3733, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"special_offer.html\">Specials Offer</a></li>\r\n\t\t\t\t\t\t<li");
                BeginWriteAttribute("class", " class=\"", 3798, "\"", 3806, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"normal.html\">Delivery</a></li>\r\n\t\t\t\t\t\t<li");
                BeginWriteAttribute("class", " class=\"", 3858, "\"", 3866, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"contact.html\">Contact</a></li>\r\n\t\t\t\t\t\t<li");
                BeginWriteAttribute("class", " class=\"", 3918, "\"", 3926, 0);
                EndWriteAttribute();
                WriteLiteral(@">
							<a href=""#login"" role=""button"" data-toggle=""modal"" style=""padding-right:0""><span class=""btn btn-large btn-success"">Login</span></a>
							<div id=""login"" class=""modal hide fade in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""login"" aria-hidden=""false"">
								<div class=""modal-header"">
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
									<h3>Login Block</h3>
								</div>
								<div class=""modal-body"">
									");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0fb1af3b39b94bdb453edc6f19ace5e680e29220341", async() => {
                    WriteLiteral(@"
										<div class=""control-group"">
											<input type=""text"" id=""inputEmail"" placeholder=""Email"">
										</div>
										<div class=""control-group"">
											<input type=""password"" id=""inputPassword"" placeholder=""Password"">
										</div>
										<div class=""control-group"">
											<label class=""checkbox"">
												<input type=""checkbox""> Remember me
											</label>
										</div>
									");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
									<button type=""submit"" class=""btn btn-success"">Sign in</button>
									<button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"">Close</button>
								</div>
							</div>
						</li>
					</ul>
				</div>
			</div>
		</div>
	</div>
	<!-- Header End====================================================================== -->
	");
#nullable restore
#line 107 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolution.WebApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("slider", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
	<div id=""mainBody"">
		<div class=""container"">
			<div class=""row"">
				<!-- Sidebar ================================================== -->
				<div id=""sidebar"" class=""span3"">
					<div class=""well well-small""><a id=""myCart"" href=""product_summary.html""><img src=""/themes/images/ico-cart.png"" alt=""cart"">3 Items in your cart  <span class=""badge badge-warning pull-right"">$155.00</span></a></div>
					<ul id=""sideManu"" class=""nav nav-tabs nav-stacked"">
						<li class=""subMenu open"">
							<a> ELECTRONICS [230]</a>
							<ul>
								<li><a class=""active"" href=""products.html""><i class=""icon-chevron-right""></i>Cameras (100) </a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Computers, Tablets & laptop (30)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Mobile Phone (80)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Sound & Vision (15)</a></li>
							</ul>
						</li>
						<li class=""subMenu"">
						");
                WriteLiteral(@"	<a> CLOTHES [840] </a>
							<ul style=""display:none"">
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Women's Clothing (45)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Women's Shoes (8)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Women's Hand Bags (5)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Men's Clothings  (45)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Men's Shoes (6)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Kids Clothing (5)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Kids Shoes (3)</a></li>
							</ul>
						</li>
						<li class=""subMenu"">
							<a>FOOD AND BEVERAGES [1000]</a>
							<ul style=""display:none"">
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Angoves  (35)</a></li>
								<li><a href=""products.html""><i class=""ic");
                WriteLiteral(@"on-chevron-right""></i>Bouchard Aine & Fils (8)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>French Rabbit (5)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Louis Bernard  (45)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>BIB Wine (Bag in Box) (8)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Other Liquors & Wine (5)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Garden (3)</a></li>
								<li><a href=""products.html""><i class=""icon-chevron-right""></i>Khao Shong (11)</a></li>
							</ul>
						</li>
						<li><a href=""products.html"">HEALTH & BEAUTY [18]</a></li>
						<li><a href=""products.html"">SPORTS & LEISURE [58]</a></li>
						<li><a href=""products.html"">BOOKS & ENTERTAINMENTS [14]</a></li>
					</ul>
					<br />
					<div class=""thumbnail"">
						<img src=""/themes/images/products/panasonic.jpg"" alt=""Bootshop panasonoc New cam");
                WriteLiteral(@"era"" />
						<div class=""caption"">
							<h5>Panasonic</h5>
							<h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
						</div>
					</div><br />
					<div class=""thumbnail"">
						<img src=""/themes/images/products/kindle.png"" title=""Bootshop New Kindel"" alt=""Bootshop Kindel"">
						<div class=""caption"">
							<h5>Kindle</h5>
							<h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
						</div>
					</div><br />
					<div class=""thumbnail"">
						<img src=""/themes/images/payment_methods.png"" title=""Bootshop Payment Methods"" alt=""Payments Methods"">
						<div class=""caption"">
							<h5>Payment Methods</h5>
						</div>
					</div>
	");
                WriteLiteral("\t\t\t</div>\r\n\t\t\t\t<!-- Sidebar end=============================================== -->\r\n\t\t\t\t<div class=\"span9\">\r\n\t\t\t\t\t");
#nullable restore
#line 177 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolution.WebApp\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
				</div>
			</div>
		</div>
	</div>
	<!-- Footer ================================================================== -->
	<div id=""footerSection"">
		<div class=""container"">
			<div class=""row"">
				<div class=""span3"">
					<h5>ACCOUNT</h5>
					<a href=""login.html"">YOUR ACCOUNT</a>
					<a href=""login.html"">PERSONAL INFORMATION</a>
					<a href=""login.html"">ADDRESSES</a>
					<a href=""login.html"">DISCOUNT</a>
					<a href=""login.html"">ORDER HISTORY</a>
				</div>
				<div class=""span3"">
					<h5>INFORMATION</h5>
					<a href=""contact.html"">CONTACT</a>
					<a href=""register.html"">REGISTRATION</a>
					<a href=""legal_notice.html"">LEGAL NOTICE</a>
					<a href=""tac.html"">TERMS AND CONDITIONS</a>
					<a href=""faq.html"">FAQ</a>
				</div>
				<div class=""span3"">
					<h5>OUR OFFERS</h5>
					<a href=""#"">NEW PRODUCTS</a>
					<a href=""#"">TOP SELLERS</a>
					<a href=""special_offer.html"">SPECIAL OFFERS</a>
					<a href=""#"">MANUFACTURERS</a>
					<a href=""#"">SUPPLIERS</a>
				</div");
                WriteLiteral(@">
				<div id=""socialMedia"" class=""span3 pull-right"">
					<h5>SOCIAL MEDIA </h5>
					<a href=""#""><img width=""60"" height=""60"" src=""/themes/images/facebook.png"" title=""facebook"" alt=""facebook"" /></a>
					<a href=""#""><img width=""60"" height=""60"" src=""/themes/images/twitter.png"" title=""twitter"" alt=""twitter"" /></a>
					<a href=""#""><img width=""60"" height=""60"" src=""/themes/images/youtube.png"" title=""youtube"" alt=""youtube"" /></a>
				</div>
			</div>
			<p class=""pull-right"">&copy; Bootshop</p>
		</div><!-- Container End -->
	</div>
	<!-- Placed at the end of the document so the pages load faster ============================================= -->
	<script src=""/themes/js/jquery.js"" type=""text/javascript""></script>
	<script src=""/themes/js/bootstrap.min.js"" type=""text/javascript""></script>
	<script src=""/themes/js/google-code-prettify/prettify.js""></script>

	<script src=""/themes/js/bootshop.js""></script>
	<script src=""/themes/js/jquery.lightbox-0.5.js""></script>

	<!-- Themes switcher section ==");
                WriteLiteral(@"=========================================================================================== -->
	<div id=""secectionBox"">
		<link rel=""stylesheet"" href=""/themes/switch/themeswitch.css"" type=""text/css"" media=""screen"" />
		<script src=""/themes/switch/theamswitcher.js"" type=""text/javascript"" charset=""utf-8""></script>
		<div id=""themeContainer"">
			<div id=""hideme"" class=""themeTitle"">Style Selector</div>
			<div class=""themeName"">Oregional Skin</div>
			<div class=""images style"">
				<a href=""/themes/css/#"" name=""bootshop""><img src=""/themes/switch/images/clr/bootshop.png"" alt=""bootstrap business templates"" class=""active""></a>
				<a href=""/themes/css/#"" name=""businessltd""><img src=""/themes/switch/images/clr/businessltd.png"" alt=""bootstrap business templates"" class=""active""></a>
			</div>
			<div class=""themeName"">Bootswatch Skins (11)</div>
			<div class=""images style"">
				<a href=""/themes/css/#"" name=""amelia"" title=""Amelia""><img src=""/themes/switch/images/clr/amelia.png"" alt=""bootstrap business temp");
                WriteLiteral(@"lates""></a>
				<a href=""/themes/css/#"" name=""spruce"" title=""Spruce""><img src=""/themes/switch/images/clr/spruce.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""superhero"" title=""Superhero""><img src=""/themes/switch/images/clr/superhero.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""cyborg""><img src=""/themes/switch/images/clr/cyborg.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""cerulean""><img src=""/themes/switch/images/clr/cerulean.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""journal""><img src=""/themes/switch/images/clr/journal.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""readable""><img src=""/themes/switch/images/clr/readable.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""simplex""><img src=""/themes/switch/images/clr/simplex.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""slate""><i");
                WriteLiteral(@"mg src=""/themes/switch/images/clr/slate.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""spacelab""><img src=""/themes/switch/images/clr/spacelab.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""united""><img src=""/themes/switch/images/clr/united.png"" alt=""bootstrap business templates""></a>
				<p style=""margin:0;line-height:normal;margin-left:-10px;display:none;""><small>These are just examples and you can build your own color scheme in the backend.</small></p>
			</div>
			<div class=""themeName"">Background Patterns </div>
			<div class=""images patterns"">
				<a href=""/themes/css/#"" name=""pattern1""><img src=""/themes/switch/images/pattern/pattern1.png"" alt=""bootstrap business templates"" class=""active""></a>
				<a href=""/themes/css/#"" name=""pattern2""><img src=""/themes/switch/images/pattern/pattern2.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern3""><img src=""/themes/switch/images/pattern/pattern3.png"" alt=""bo");
                WriteLiteral(@"otstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern4""><img src=""/themes/switch/images/pattern/pattern4.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern5""><img src=""/themes/switch/images/pattern/pattern5.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern6""><img src=""/themes/switch/images/pattern/pattern6.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern7""><img src=""/themes/switch/images/pattern/pattern7.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern8""><img src=""/themes/switch/images/pattern/pattern8.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern9""><img src=""/themes/switch/images/pattern/pattern9.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern10""><img src=""/themes/switch/images/pattern/pattern10.png"" alt=""bootstrap business templates""></a>

				<a href=""");
                WriteLiteral(@"/themes/css/#"" name=""pattern11""><img src=""/themes/switch/images/pattern/pattern11.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern12""><img src=""/themes/switch/images/pattern/pattern12.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern13""><img src=""/themes/switch/images/pattern/pattern13.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern14""><img src=""/themes/switch/images/pattern/pattern14.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern15""><img src=""/themes/switch/images/pattern/pattern15.png"" alt=""bootstrap business templates""></a>

				<a href=""/themes/css/#"" name=""pattern16""><img src=""/themes/switch/images/pattern/pattern16.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern17""><img src=""/themes/switch/images/pattern/pattern17.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern18""><im");
                WriteLiteral(@"g src=""/themes/switch/images/pattern/pattern18.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern19""><img src=""/themes/switch/images/pattern/pattern19.png"" alt=""bootstrap business templates""></a>
				<a href=""/themes/css/#"" name=""pattern20""><img src=""/themes/switch/images/pattern/pattern20.png"" alt=""bootstrap business templates""></a>
			</div>
		</div>
	</div>
	<span id=""/themesBtn""></span>
");
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
            WriteLiteral("\r\n</html>");
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