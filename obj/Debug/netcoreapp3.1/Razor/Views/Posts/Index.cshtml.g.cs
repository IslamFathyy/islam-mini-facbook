#pragma checksum "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe18a721afa466bc52b846a98b47f1c26f794cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
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
#line 1 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\_ViewImports.cshtml"
using Facbook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\_ViewImports.cshtml"
using Facbook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\_ViewImports.cshtml"
using Facbook.ViewModell;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe18a721afa466bc52b846a98b47f1c26f794cf", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba07e7ed3f5d4b5f1809c1c7c98ace9eaddfba0", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Posts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:20vh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dislike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
  
    Layout = "~/Views/Shared/_MyDefaultlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
    .fa {
        font-size: 50px;
        cursor: pointer;
        user-select: none;
    }

        .fa:hover {
            color: darkblue;
        }

    body {
        background-color: #F5F5F5;
    }

    .navbar {
        position: fixed;
        top: 0;
        z-index: 1;
    }

    .post {
        text-align: center;
        padding: 5%;
        -webkit-box-shadow: 1px 3px 15px -4px rgba(0,0,0,0.75);
        -moz-box-shadow: 1px 3px 15px -4px rgba(0,0,0,0.75);
        box-shadow: 1px 3px 15px -4px rgba(0,0,0,0.75);
        border-radius: 20px;
        background-color: white;
    }

    textarea {
        width: 80%;
        resize: none;
        height: 20vh;
    }

    .friends ul li img {
        height: 50px;
        width: 50px;
        border-radius: 50%;
    }

    .friends ul li p {
        display: inline-flex
    }

");
            WriteLiteral(@"    .friends ul {
        margin-top: 10%
    }

    .friends {
        border-left: 1px solid black;
        position: fixed;
        top: 10vh;
        bottom: 0;
        z-index: -1
    }

    .feed {
        margin-top: 5%;
    }

    .feedpost {
        width: 50%;
        /*border: 1px solid black;*/
        margin-top: 2%;
        background-color: white;
        padding: 2% 2% 1% 2%;
        -webkit-box-shadow: 0px 0px 17px -7px rgba(0,0,0,0.75);
        -moz-box-shadow: 0px 0px 17px -7px rgba(0,0,0,0.75);
        box-shadow: 0px 0px 17px -7px rgba(0,0,0,0.75);
    }

    .feedPostReact {
        margin-top: 3%;
        border: 1px solid black;
        padding-top: 1%;
    }

        .feedPostReact ul li {
            display: inline;
        }

    .body textarea {
        border: none;
    }

    .feedpost header {
    }

        .feedpost header img {
            width: 50px;
            height: 50px;
            border-radius: 50%
        }

      ");
            WriteLiteral(@"  .feedpost header h6 {
            display: inline;
        }

    .feedpost .body img {
        max-width: 100%;
        max-height: 100%;
        height: auto;
        width: 100%
    }
</style>
<div id=""emptyDiv""></div>
<div id=""emptyDivDel""></div>
<div id=""likesdiv""></div>
<div class=""container"" style=""margin-top: 7%"">
    <div class=""row"">
        <div class=""col-6"">
");
#nullable restore
#line 125 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
               await Html.RenderPartialAsync("_CreatePostPartial", new Posts());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr class=\"mt-4\" />\r\n        </div>\r\n        <div class=\"col-2 offset-4\">\r\n            <div class=\"friends\">\r\n                <ul>\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf8829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p>Ahmed Essam</p>\r\n                    </li>\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf9986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p>Ahmed Essam</p>\r\n                    </li>\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf11143", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p>Ahmed Essam</p>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"feed\">\r\n\r\n");
#nullable restore
#line 151 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
         foreach (var item in Model)
        { 
            var user = await UserManager.FindByIdAsync(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"feedpost\">\r\n                <header>\r\n");
#nullable restore
#line 156 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                      
                        string pb = null;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                         if (user.Photo == null)
                            pb = "/images/user.png";
                        else
                            pb = "/images/" + user.Photo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3876, "\"", 3885, 1);
#nullable restore
#line 164 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3882, pb, 3882, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h5>");
#nullable restore
#line 165 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                   Write(user.MyUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6>");
#nullable restore
#line 166 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                   Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </header>\r\n\r\n                <div class=\"body\">\r\n\r\n                    ");
#nullable restore
#line 171 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PostBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 172 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                     if (item.HasAttachment == true)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                         if (item.Attachment.Count > 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n");
#nullable restore
#line 178 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                 foreach (var photo in item.Attachment)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-6 mt-3\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf15575", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Images/");
#nullable restore
#line 180 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                   WriteLiteral(photo.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 180 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 182 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 184 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"

                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                             foreach (var photo in item.Attachment)
                            {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf18875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Images/");
#nullable restore
#line 189 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                    WriteLiteral(photo.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 189 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 189 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                         
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                         

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbe18a721afa466bc52b846a98b47f1c26f794cf21970", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 194 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 194 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 196 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                     if (item.UserId == ViewBag.IsAuth)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5202, "\"", 5232, 3);
            WriteAttributeValue("", 5212, "editt(", 5212, 6, true);
#nullable restore
#line 198 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 5218, item.PostsId, 5218, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5231, ")", 5231, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        <a class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5282, "\"", 5314, 3);
            WriteAttributeValue("", 5292, "deletee(", 5292, 8, true);
#nullable restore
#line 199 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 5300, item.PostsId, 5300, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5313, ")", 5313, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 200 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 203 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                      
                        var currentuser = ViewBag.IsAuth;

                        var myuser = item.Likes.FirstOrDefault(i => i.UserId == currentuser && i.PostId == item.PostsId && i.IsDeleted == false);
                        if (myuser == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe18a721afa466bc52b846a98b47f1c26f794cf25840", async() => {
                WriteLiteral("   Like ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                               WriteLiteral(ViewBag.IsAuth);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                                                  WriteLiteral(item.PostsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 208 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                                                                                         }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe18a721afa466bc52b846a98b47f1c26f794cf29430", async() => {
                WriteLiteral("   unLike ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 211 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                 WriteLiteral(ViewBag.IsAuth);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 211 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                                                                                                                    WriteLiteral(item.PostsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 212 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"

                        }



                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"feedPostReact\">\r\n");
#nullable restore
#line 220 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
                       var mydiv = "mylikescount" + @item.PostsId; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button");
            BeginWriteAttribute("id", " id=", 6230, "", 6240, 1);
#nullable restore
#line 222 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 6234, mydiv, 6234, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6264, "\"", 6297, 3);
            WriteAttributeValue("", 6274, "getcount(", 6274, 9, true);
#nullable restore
#line 222 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 6283, item.PostsId, 6283, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6296, ")", 6296, 1, true);
            EndWriteAttribute();
            WriteLiteral("> likes</button>\r\n\r\n\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6366, "\"", 6405, 3);
            WriteAttributeValue("", 6376, "viewModalLikes(", 6376, 15, true);
#nullable restore
#line 225 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
WriteAttributeValue("", 6391, item.PostsId, 6391, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6404, ")", 6404, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Listt</a>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 229 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Posts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js""></script>
    <script src=""https://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js""></script>

    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js""></script>


");
                WriteLiteral(@"    <script type=""text/javascript"">
        function getcount(id) {
            $.ajax({
                type: ""GET"",
                url: ""Posts/Getlikescount/"" + id,
                success: function (response) {
                    var mydiv = ""mylikescount"" + id;
                    console.log(mydiv)
                    document.getElementById(mydiv).innerText = response;

                },

                //success: function (response) {
                //    alert(response)
                //},
                error: function () {
                    alert(""Error Deleting Posts"");
                }
            });
        }


        function editt(id) {
            $.ajax({
                type: ""GET"",
                url: ""Posts/Edit/"" + id,
                success: function (response) {
                    $(""#emptyDiv"").html(response);
                    $(""#modalSubscriptionFormwe"").modal({
                        ""backdrop"": ""static"",
                        ""keyb");
                WriteLiteral(@"oard"": true,
                        ""show"": true
                    });
                },
                //success: function (response) {
                //    alert(response)
                //},
                error: function () {
                    alert(""Error retreiving Posts"");
                }
            });
        }
        function deletee(id) {
            $.ajax({
                type: ""GET"",
                url: ""Posts/Delete/"" + id,
                success: function (response) {
                    $(""#emptyDivDel"").html(response);
                    $(""#modalSubscriptionFormwd"").modal({
                        ""backdrop"": ""static"",
                        ""keyboard"": true,
                        ""show"": true
                    });
                },

                //success: function (response) {
                //    alert(response)
                //},
                error: function () {
                    alert(""Error Deleting Posts"");
           ");
                WriteLiteral(@"     }
            });
        }

        function showLikes() {
            $(""#likesModal"").modal(""toggle"");
        }

        function viewModalLikes(id) {
            $.ajax({
                type: ""GET"",
                url: ""Posts/listLikeUser/"" + id,
                success: function (response) {
                    $(""#likesdiv"").html(response);
                    $(""#likesModal"").modal({
                        ""backdrop"": ""static"",
                        ""keyboard"": true,
                        ""show"": true
                    });
                },
                //success: function (response) {
                //    alert(response)
                //},
                error: function () {
                    alert(""Error retreiving Posts"");
                }
            });
        }


    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Users> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Users> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Posts>> Html { get; private set; }
    }
}
#pragma warning restore 1591