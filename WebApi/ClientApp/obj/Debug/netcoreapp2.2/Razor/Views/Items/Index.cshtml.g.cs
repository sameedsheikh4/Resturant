#pragma checksum "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733b77135b9be3a202673f29ada646466e6b5516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\_ViewImports.cshtml"
using ClientApp;

#line default
#line hidden
#line 2 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\_ViewImports.cshtml"
using ClientApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733b77135b9be3a202673f29ada646466e6b5516", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e490365ce0c98bbe48a98ed5e1104456718389", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Common.DTOs.ItemDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(113, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733b77135b9be3a202673f29ada646466e6b55163777", async() => {
                BeginContext(136, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(150, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(243, 42, false);
#line 16 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(285, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(341, 40, false);
#line 19 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(437, 47, false);
#line 22 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(484, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(540, 48, false);
#line 25 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsOutOfStock));

#line default
#line hidden
            EndContext();
            BeginContext(588, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(644, 44, false);
#line 28 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(744, 46, false);
#line 31 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ArchivedBy));

#line default
#line hidden
            EndContext();
            BeginContext(790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(846, 46, false);
#line 34 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(892, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(948, 45, false);
#line 37 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(993, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1049, 47, false);
#line 40 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1152, 48, false);
#line 43 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1256, 48, false);
#line 46 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ArchivedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1422, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1471, 41, false);
#line 55 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1568, 39, false);
#line 58 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1663, 46, false);
#line 61 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1765, 47, false);
#line 64 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsOutOfStock));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1868, 43, false);
#line 67 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1967, 45, false);
#line 70 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArchivedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2068, 45, false);
#line 73 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2169, 44, false);
#line 76 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2269, 46, false);
#line 79 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2371, 47, false);
#line 82 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2474, 47, false);
#line 85 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArchivedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2577, 57, false);
#line 88 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2655, 59, false);
#line 89 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 92 "C:\Users\muham\Desktop\Resturant\WebApi\ClientApp\Views\Items\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2753, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Common.DTOs.ItemDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
