#pragma checksum "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95046bf18a8c53abc5cd7e5bebc56b4303854e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_DisplaySurvey), @"mvc.1.0.view", @"/Views/Survey/DisplaySurvey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/DisplaySurvey.cshtml", typeof(AspNetCore.Views_Survey_DisplaySurvey))]
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
#line 11 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95046bf18a8c53abc5cd7e5bebc56b4303854e96", @"/Views/Survey/DisplaySurvey.cshtml")]
    public class Views_Survey_DisplaySurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SurveyUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95046bf18a8c53abc5cd7e5bebc56b4303854e963923", async() => {
                BeginContext(39, 197, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Dojo Survey!</title>\n    ");
                EndContext();
                BeginContext(236, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95046bf18a8c53abc5cd7e5bebc56b4303854e964508", async() => {
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
                EndContext();
                BeginContext(283, 1, true);
                WriteLiteral("\n");
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
            BeginContext(291, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(292, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95046bf18a8c53abc5cd7e5bebc56b4303854e966598", async() => {
                BeginContext(298, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(330, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(359, 172, true);
                WriteLiteral("    {\n        <div style=\"width:888px;height:777px;border:2px solid gold;border-radius:50px;padding:30px;\">\n            <h2 style=\"margin-bottom:30px;\">Submitted Info</h2>\n");
                EndContext();
#line 16 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
             foreach(SurveyUser person in Model)
            {

#line default
#line hidden
                BeginContext(594, 35, true);
                WriteLiteral("                <p>Your Name:<span>");
                EndContext();
                BeginContext(630, 11, false);
#line 18 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                              Write(person.Name);

#line default
#line hidden
                EndContext();
                BeginContext(641, 51, true);
                WriteLiteral("</span></p>\n                <p>Dojo Location:<span>");
                EndContext();
                BeginContext(693, 15, false);
#line 19 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                                  Write(person.Location);

#line default
#line hidden
                EndContext();
                BeginContext(708, 55, true);
                WriteLiteral("</span></p>\n                <p>Favorite Language:<span>");
                EndContext();
                BeginContext(764, 15, false);
#line 20 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                                      Write(person.Language);

#line default
#line hidden
                EndContext();
                BeginContext(779, 45, true);
                WriteLiteral("</span></p>\n                <p>Comment:<span>");
                EndContext();
                BeginContext(825, 15, false);
#line 21 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                            Write(person.Comments);

#line default
#line hidden
                EndContext();
                BeginContext(840, 12, true);
                WriteLiteral("</span></p>\n");
                EndContext();
#line 22 "/Users/James/c#_stack/c#_aspmvc_1/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
            }

#line default
#line hidden
                BeginContext(866, 74, true);
                WriteLiteral("            <a href=\"/\"><button>Go Back</button></a>\n        </div>\n    }\n");
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
            BeginContext(947, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SurveyUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
