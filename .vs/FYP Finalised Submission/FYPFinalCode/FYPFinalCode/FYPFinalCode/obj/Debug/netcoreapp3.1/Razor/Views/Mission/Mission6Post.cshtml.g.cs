#pragma checksum "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "762ce0295e25a7fa945e84a07268f0ba4b1628f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_Mission6Post), @"mvc.1.0.view", @"/Views/Mission/Mission6Post.cshtml")]
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
#line 1 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\_ViewImports.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\_ViewImports.cshtml"
using FYPFinalCode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"762ce0295e25a7fa945e84a07268f0ba4b1628f9", @"/Views/Mission/Mission6Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbbd471861c5ad4dc73065ec50981ffcc6d1823", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_Mission6Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MissionPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    nav {
        background-color: snow;
        position: relative;
        margin-top:-50px;
    }
    #content1{
        position:absolute;
        left:350px;
        top:200px;
        width:160px;
        height:80px;
    }
    #content2 {
        position:absolute;
        left: 330px;
        top:830px;
    }
    body {
        background-color: lightsalmon;
        background-size: auto;
    }

    .btn {
        background-color:cornflowerblue;
        border: none;
        color: white;
        padding: 16px 32px;
        text-align: center;
        font-size: 16px;
        margin: 4px 2px;
        opacity: 0.6;
        transition: 0.3s;
        display: inline-block;
        text-decoration: none;
        cursor: pointer;
    }

    .btn:hover {
        opacity: 1
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762ce0295e25a7fa945e84a07268f0ba4b1628f95481", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762ce0295e25a7fa945e84a07268f0ba4b1628f95743", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
         if (ViewData["Picture"] != null)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <div class=\"form-group row\">\r\n                <div id=\"content1\">\r\n                    <img");
                    BeginWriteAttribute("src", " src=\"", 1173, "\"", 1206, 2);
                    WriteAttributeValue("", 1179, "/Photo/", 1179, 7, true);
#nullable restore
#line 54 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
WriteAttributeValue("", 1186, ViewData["Picture"], 1186, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 57 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
         if (ViewData["Message"] != null)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <div class=\"form-group row\">\r\n                <div id=\"content2\">\r\n                    <div");
                    BeginWriteAttribute("class", " class=\"", 1425, "\"", 1465, 3);
                    WriteAttributeValue("", 1433, "alert", 1433, 5, true);
                    WriteAttributeValue(" ", 1438, "alert-", 1439, 7, true);
#nullable restore
#line 63 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
WriteAttributeValue("", 1445, ViewData["MsgType"], 1445, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        <text>");
#nullable restore
#line 64 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
                         Write(Html.Raw(ViewData["Message"]));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</text>\r\n                    </div>\r\n                    <input type=\"submit\" value=\"Back To Missions\" class=\"btn\" />\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 70 "C:\Users\19013505\Documents\FYPFinalCode\FYPFinalCode\FYPFinalCode\Views\Mission\Mission6Post.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n      \r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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