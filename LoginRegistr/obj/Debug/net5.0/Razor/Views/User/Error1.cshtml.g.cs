#pragma checksum "C:\Users\acer\Documents\C#\LoginRegistr\LoginRegistr\Views\User\Error1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5355d8ebed054a4e2478c4cb8b8621ae44e4cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Error1), @"mvc.1.0.view", @"/Views/User/Error1.cshtml")]
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
#line 1 "C:\Users\acer\Documents\C#\LoginRegistr\LoginRegistr\Views\_ViewImports.cshtml"
using LoginRegistr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\Documents\C#\LoginRegistr\LoginRegistr\Views\_ViewImports.cshtml"
using LoginRegistr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5355d8ebed054a4e2478c4cb8b8621ae44e4cc", @"/Views/User/Error1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396410d7eb547f134e5f1d555347227f1a87ecc1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Error1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script type=\"text/javascript\">\r\n    alert(\"parol ya da istifadeci adi yanlisdir!\");\r\n    var ok=confirm(\"Click the OK button now!\");\r\nif (ok==true)\r\n{\r\n  window.location.href = \'");
#nullable restore
#line 6 "C:\Users\acer\Documents\C#\LoginRegistr\LoginRegistr\Views\User\Error1.cshtml"
                     Write(Url.Action("Index", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n}\r\n</script>");
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