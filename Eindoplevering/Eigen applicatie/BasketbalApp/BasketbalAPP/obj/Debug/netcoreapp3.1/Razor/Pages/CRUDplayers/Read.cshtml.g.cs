#pragma checksum "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2c2746cd078308fe574b58c3b29cbef0dfe21c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasketbalAPP.Pages.CRUDplayers.Pages_CRUDplayers_Read), @"mvc.1.0.razor-page", @"/Pages/CRUDplayers/Read.cshtml")]
namespace BasketbalAPP.Pages.CRUDplayers
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
#line 1 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\_ViewImports.cshtml"
using BasketbalAPP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2c2746cd078308fe574b58c3b29cbef0dfe21c", @"/Pages/CRUDplayers/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8d44cfe991415fb0d9b27828f1e0259022b86f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CRUDplayers_Read : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Players", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details Page</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Player Id : ");
#nullable restore
#line 11 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                   Write(Html.DisplayFor(model => model.DisplayPlayer.IdPlayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Points : ");
#nullable restore
#line 14 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                Write(Html.DisplayFor(model => model.DisplayPlayer.Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Rebounds : ");
#nullable restore
#line 17 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                  Write(Html.DisplayFor(model => model.DisplayPlayer.Rebounds));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Assists : ");
#nullable restore
#line 20 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                 Write(Html.DisplayFor(model => model.DisplayPlayer.Assists));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Blocks : ");
#nullable restore
#line 23 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                Write(Html.DisplayFor(model => model.DisplayPlayer.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Nationality : ");
#nullable restore
#line 26 "C:\Users\Kevin\Documents\GitHub\BasketballApplicatie\Oplevering Iteratie 4\BasketbalAppInversion\BasketbalAPP\Pages\CRUDplayers\Read.cshtml"
                     Write(Html.DisplayFor(model => model.DisplayPlayer.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2c2746cd078308fe574b58c3b29cbef0dfe21c6141", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketbalAPP.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketbalAPP.Pages.DetailsModel>)PageContext?.ViewData;
        public BasketbalAPP.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
