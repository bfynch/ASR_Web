#pragma checksum "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4037fe75ad7116d95eeffb5d3ec97bdaeada875c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StaffDash_Details), @"mvc.1.0.view", @"/Views/StaffDash/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StaffDash/Details.cshtml", typeof(AspNetCore.Views_StaffDash_Details))]
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
#line 1 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/_ViewImports.cshtml"
using Asr;

#line default
#line hidden
#line 2 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/_ViewImports.cshtml"
using Asr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4037fe75ad7116d95eeffb5d3ec97bdaeada875c", @"/Views/StaffDash/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bafbcc93ccda9824b9d665db48f911727b573b0", @"/Views/_ViewImports.cshtml")]
    public class Views_StaffDash_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asr.Models.Slot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(69, 99, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(169, 40, false);
#line 13 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
            EndContext();
            BeginContext(209, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(253, 43, false);
#line 16 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(340, 45, false);
#line 19 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(385, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(429, 41, false);
#line 22 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(514, 49, false);
#line 25 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(607, 45, false);
#line 28 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.Staff.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(696, 46, false);
#line 31 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff.Name));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 42, false);
#line 34 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.Staff.Name));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(872, 53, false);
#line 37 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(925, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(969, 49, false);
#line 40 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1062, 48, false);
#line 43 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1154, 44, false);
#line 46 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StaffDash/Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 58, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1256, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463eaec97d9b45958a6c57bf7d694fe7", async() => {
                BeginContext(1278, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1294, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asr.Models.Slot> Html { get; private set; }
    }
}
#pragma warning restore 1591
