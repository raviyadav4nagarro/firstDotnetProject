#pragma checksum "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\NewProj\Name.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe1a232b968391aa00850d7bf44795d5d138b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewProj_Name), @"mvc.1.0.view", @"/Views/NewProj/Name.cshtml")]
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
#line 1 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\_ViewImports.cshtml"
using firstproj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\_ViewImports.cshtml"
using firstproj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe1a232b968391aa00850d7bf44795d5d138b9e", @"/Views/NewProj/Name.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd9780aeb29f5c121838e16f39e55f79c570c06", @"/Views/_ViewImports.cshtml")]
    public class Views_NewProj_Name : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewProjNameModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\NewProj\Name.cshtml"
  
    ViewData["Title"] = "Name";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\NewProj\Name.cshtml"
 if(Model.ID == "1")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>My Name:</strong> <code>");
#nullable restore
#line 10 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\NewProj\Name.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 12 "D:\training_data_devops\Dot_Net_Core_MVC_Web_App\firstproj\firstproj\Views\NewProj\Name.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Name</h1>\r\n<p>Hey all !!!!!!!!!!!!!!!!</p><br />\r\n<p>My name is Ravi Yadav</p><br />\r\n<p>This is going to be my first paraghraph</p>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewProjNameModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
