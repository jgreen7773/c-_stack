#pragma checksum "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bbe7a577baf581a3c36878160374d6d4fa6b2dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Survey.Views_Survey_DisplaySurvey), @"mvc.1.0.view", @"/Views/Survey/DisplaySurvey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/DisplaySurvey.cshtml", typeof(MyApp.Namespace.Survey.Views_Survey_DisplaySurvey))]
namespace MyApp.Namespace.Survey
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/_ViewImports.cshtml"
using Dojo_Survey;

#line default
#line hidden
#line 3 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbe7a577baf581a3c36878160374d6d4fa6b2dc", @"/Views/Survey/DisplaySurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01e3f2afe10c7434de49ab52f22434ccd308901", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_DisplaySurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SurveyUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\n\n");
            EndContext();
            BeginContext(69, 160, true);
            WriteLiteral("{\n    <div style=\"width:888px;height:777px;border:2px solid gold;border-radius:50px;padding:30px;\">\n        <h2 style=\"margin-bottom:30px;\">Submitted Info</h2>\n");
            EndContext();
#line 8 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
         foreach(SurveyUser person in Model)
        {

#line default
#line hidden
            BeginContext(284, 31, true);
            WriteLiteral("            <p>Your Name:<span>");
            EndContext();
            BeginContext(316, 11, false);
#line 10 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                          Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(327, 47, true);
            WriteLiteral("</span></p>\n            <p>Dojo Location:<span>");
            EndContext();
            BeginContext(375, 15, false);
#line 11 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                              Write(person.Location);

#line default
#line hidden
            EndContext();
            BeginContext(390, 51, true);
            WriteLiteral("</span></p>\n            <p>Favorite Language:<span>");
            EndContext();
            BeginContext(442, 15, false);
#line 12 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                                  Write(person.Language);

#line default
#line hidden
            EndContext();
            BeginContext(457, 41, true);
            WriteLiteral("</span></p>\n            <p>Comment:<span>");
            EndContext();
            BeginContext(499, 15, false);
#line 13 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
                        Write(person.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(514, 12, true);
            WriteLiteral("</span></p>\n");
            EndContext();
#line 14 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/DisplaySurvey.cshtml"
        }

#line default
#line hidden
            BeginContext(536, 61, true);
            WriteLiteral("        <a href=\"/\"><button>Go Back</button></a>\n    </div>\n}");
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
