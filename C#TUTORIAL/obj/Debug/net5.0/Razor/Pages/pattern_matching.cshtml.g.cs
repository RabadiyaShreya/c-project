#pragma checksum "C:\C#TUTORIAL\Pages\pattern_matching.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca69c648cc37ae2ca6a0158f166565b67c03d3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(C_TUTORIAL.Pages.Pages_pattern_matching), @"mvc.1.0.razor-page", @"/Pages/pattern_matching.cshtml")]
namespace C_TUTORIAL.Pages
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
#line 1 "C:\C#TUTORIAL\Pages\_ViewImports.cshtml"
using C_TUTORIAL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca69c648cc37ae2ca6a0158f166565b67c03d3b9", @"/Pages/pattern_matching.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3c987eef8e67713cc41d4d02eb288681eef6ce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_pattern_matching : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylesheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\C#TUTORIAL\Pages\pattern_matching.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca69c648cc37ae2ca6a0158f166565b67c03d3b93738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""scroll"">
        <center></br></br><h3>Pattern matching overview</h3></center>
        <p class=""f_size"">
            Pattern matching is a technique where you test an expression to determine if it has certain characteristics. 
            C# pattern matching provides more concise syntax for testing expressions and taking action when an expression matches. 
            The ""is expression"" supports pattern matching to test an expression and conditionally declare a new variable to the result 
            of that expression. The ""switch expression"" enables you to perform actions based on the first matching pattern for an 
            expression. These two expressions support a rich vocabulary of patterns.
        </p>

        <h5>Null checks</h5>
        <p class=""f_size"">One of the most common scenarios for pattern matching is to ensure values aren't null. You can test and convert a nullable value type to its underlying type while testing for null using the following.</p>
        ");
            WriteLiteral(@"<p class=""f_size""> <b>&#x2022;</b>Eample1:</p>
        <p class=""f_size"">int? maybe = 12;</br>
                &nbsp;&nbsp;if (maybe is int number)</br>
                &nbsp;&nbsp;{</br>
                    &nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine($""The nullable int 'maybe' has the value {number}"");</br>
                &nbsp;&nbsp;}</br>
                &nbsp;&nbsp;else</br>
                &nbsp;&nbsp;{</br>
                   &nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(""The nullable int 'maybe' doesn't hold a value"");</br>
                &nbsp;&nbsp;}</p>

        <p class=""f_size""><b>&#x2022;</b>Example2:</p>
        <p class=""f_size"">string? message = ""This is not the null string"";</br>
                &nbsp;&nbsp;if (message is not null)</br>
                &nbsp;&nbsp;{</br>
                    &nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(message);</br>
                &nbsp;&nbsp;}</p>
        
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pattern_matching> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pattern_matching> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pattern_matching>)PageContext?.ViewData;
        public pattern_matching Model => ViewData.Model;
    }
}
#pragma warning restore 1591
