#pragma checksum "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf3d61cc4056d7d286d7f45635b64b2a6208794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Product_Comments), @"mvc.1.0.view", @"/Areas/Manage/Views/Product/Comments.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf3d61cc4056d7d286d7f45635b64b2a6208794", @"/Areas/Manage/Views/Product/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1fddda541c9a6bcdf5ea78393a8d2905d713fa", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Product_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "infocomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletecomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light delete-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
  
    ViewData["Title"] = "Comments";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 style=""display:inline-block"">Comments</h1>
        </div>
        <div class=""col-lg-12"">
            <table class=""table table-info table-hover"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">FullName</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">BookName</th>
                        <th scope=""col"">Text</th>
                        <th scope=""col"">Rate</th>
                        <th scope=""col"">Status</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                     foreach (ProductComment item in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                            Write(item.Text==null || item.Text.Length<=250?item.Text:item.Text.Substring(0,250)+"...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                           Write(item.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><span");
            BeginWriteAttribute("style", " style=\"", 1555, "\"", 1597, 2);
            WriteAttributeValue("", 1563, "color:", 1563, 6, true);
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
WriteAttributeValue("", 1569, item.Status?"green":"red", 1569, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1598, "\"", 1649, 3);
            WriteAttributeValue("", 1606, "badge", 1606, 5, true);
            WriteAttributeValue(" ", 1611, "badge-", 1612, 7, true);
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
WriteAttributeValue("", 1618, item.Status?"success":"info", 1618, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                                                                                                                                 Write(item.Status?"Təsdiqlənib":"Gözləmədədir");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf3d61cc4056d7d286d7f45635b64b2a620879410054", async() => {
                WriteLiteral("<i style=\"color:lightgreen\" class=\"fa-solid fa-info fa-flip\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf3d61cc4056d7d286d7f45635b64b2a620879412434", async() => {
                WriteLiteral("<i style=\"color: crimson\" class=\"fa-solid fa-trash-can fa-shake\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\Product\Comments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@10/dist/sweetalert2.all.min.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591