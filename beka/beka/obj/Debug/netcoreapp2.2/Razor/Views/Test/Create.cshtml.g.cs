#pragma checksum "C:\Users\PC\Desktop\Projekty_Net_Core\DlaBeki\beka\beka\Views\Test\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b61e567f9e10188e4dc38565d14b1e3f90697a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Create), @"mvc.1.0.view", @"/Views/Test/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Create.cshtml", typeof(AspNetCore.Views_Test_Create))]
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
#line 1 "C:\Users\PC\Desktop\Projekty_Net_Core\DlaBeki\beka\beka\Views\_ViewImports.cshtml"
using beka;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\Projekty_Net_Core\DlaBeki\beka\beka\Views\_ViewImports.cshtml"
using beka.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61e567f9e10188e4dc38565d14b1e3f90697a13", @"/Views/Test/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9759ad1211815d47638116dbd66d17d863f55b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 490, true);
            WriteLiteral(@"


    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://code.jquery.com/jquery-3.5.0.js""></script>
<h1>Tworzenie testu</h1>


 
        <label>Pytanie</label>
        <input type=""text"" id=""txtName"" />
        <input type=""submit"" id=""addTest"" />



<div id=""testWithQuestion""></div>
<p id=""ziomek"">Elo </p>


<script type=""text/javascript"">
    $(""p"").append(""<strong>Hello</strong>"");
      
</script>");
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
