#pragma checksum "/Users/benjaminfynch/Desktop/Ass2/ASR/Views/Home/FAQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e300ec44606df262833bc1ea2f382499c1855854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FAQ), @"mvc.1.0.view", @"/Views/Home/FAQ.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FAQ.cshtml", typeof(AspNetCore.Views_Home_FAQ))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e300ec44606df262833bc1ea2f382499c1855854", @"/Views/Home/FAQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bafbcc93ccda9824b9d665db48f911727b573b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FAQ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1412, true);
            WriteLiteral(@"<h2>Frequently Asked Questions</h2>
<br />
<h3>Student Questions</h3>
<br />
<h4>How do I book a slot?</h4>
<p>You can book a slot by logging in and visiting the student dashboard. Check the list of available slots and click ""Book Slot"" on the slot you wish to book.</p>
<br />
<h4>Why do some slots not have an option to book the slot?</h4>
<p>That is because you are only allowed one booking per day and you already have a slot booked for that day</p>
<br />
<h4>What do I do if I am no longer able to attend a booking?</h4>
<p>You can cancel a booking by logging in and visiting the student dashboard. Find the booking you wish to cancel in your bookings summary and click the Cancel Booking button.</p>
<br />
<h3>Staff Questions</h3>
<br />
<h4>How do I create a new slot?</h4>
<p>You can create a new slot by logging in and visiting the staff dashboard. Click the ""Create a new slot"" button on the side bar and enter the details.</p>
<br />
<h4>Why am I able to delete some slots but not all?</h4>
<");
            WriteLiteral(@"p>A slot is not able to be deleted if a student is booked into it.</p>
<br />
<h4>What do I do if my availability changes and I can no longer attend a slot I have created?</h4>
<p>You can delete a slot by logging in and visiting the staff dashboard. Find the slot you wish to delete and click the Delete Slot button. A slot will not be able to be deleted if a student is booked in.</p>");
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
