#pragma checksum "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "575aabfcf0963a76eb043832be37faecfa11f4df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentDash_Index), @"mvc.1.0.view", @"/Views/StudentDash/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentDash/Index.cshtml", typeof(AspNetCore.Views_StudentDash_Index))]
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
#line 2 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"575aabfcf0963a76eb043832be37faecfa11f4df", @"/Views/StudentDash/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bafbcc93ccda9824b9d665db48f911727b573b0", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentDash_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllBookings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookSlot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllSlots", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(114, 136, true);
            WriteLiteral("\r\n<h2>Student Dashboard</h2>\r\n<h3>My Bookings</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 32, false);
#line 11 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Room));

#line default
#line hidden
            EndContext();
            BeginContext(283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(339, 33, false);
#line 14 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Staff));

#line default
#line hidden
            EndContext();
            BeginContext(372, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(428, 37, false);
#line 17 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(x => x.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(465, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
         foreach (var item in Model.Where(x => x.StudentID == UserManager.GetUserName(User).Substring(0, 8)).OrderBy(y => y.StartTime))
        {

#line default
#line hidden
            BeginContext(699, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(760, 41, false);
#line 27 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(801, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(869, 42, false);
#line 30 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(911, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(979, 44, false);
#line 33 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1090, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee990affbe84ad7b03b56b2370dc18b", async() => {
                BeginContext(1190, 14, true);
                WriteLiteral("Cancel Booking");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                        WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                                                           WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1232, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8919ebbdff5947d79e993c870101c237", async() => {
                BeginContext(1326, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                  WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 37 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                                                     WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1337, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1392, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 43 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
 if (Model.Where(x => x.StudentID == UserManager.GetUserName(User).Substring(0, 8)).Count() > 4)
{

#line default
#line hidden
            BeginContext(1517, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1521, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e376a26e87e4832a14f8a7b9917a012", async() => {
                BeginContext(1549, 9, true);
                WriteLiteral(" See all ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1562, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1567, 110, true);
            WriteLiteral("<h3>Available Slots</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1678, 40, false);
#line 52 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1774, 41, false);
#line 55 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1871, 45, false);
#line 58 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
         foreach (var item in Model.Where(x => x.StudentID == null).OrderBy(y => y.StartTime).Take(5))
        {

#line default
#line hidden
            BeginContext(2117, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2178, 46, false);
#line 68 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Room.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2292, 45, false);
#line 71 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Staff.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2405, 44, false);
#line 74 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2516, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa77ec4d150b48a39f40d281297333ab", async() => {
                BeginContext(2611, 9, true);
                WriteLiteral("Book Slot");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                   WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 77 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                                                      WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2624, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2648, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a90b158974ac4a05bed686ee0aee4839", async() => {
                BeginContext(2742, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                  WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 78 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
                                                                                     WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 81 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2808, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 84 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
 if (Model.Where(x => x.StudentID == null).Count() > 4)
{

#line default
#line hidden
            BeginContext(2892, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33477fb8562844d89bb2a78c2a364c7c", async() => {
                BeginContext(2917, 7, true);
                WriteLiteral("See all");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2928, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 87 "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/StudentDash/Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
