#pragma checksum "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0af9a763e9caac7f596a37a14b3f9aed728ed58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PostIndexPartial), @"mvc.1.0.view", @"/Views/Shared/_PostIndexPartial.cshtml")]
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
#line 5 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\_ViewImports.cshtml"
using Facbook.ViewModell;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0af9a763e9caac7f596a37a14b3f9aed728ed58", @"/Views/Shared/_PostIndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba07e7ed3f5d4b5f1809c1c7c98ace9eaddfba0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PostIndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Posts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:20vh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dislike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div id=\"emptyDiv\"></div>\r\n<div id=\"emptyDivDel\"></div>\r\n");
            WriteLiteral(@"<style>
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

    .friends ul {
        margin-top: 10%
    }

    .friends {
        border-left: 1px solid black;
        posit");
            WriteLiteral(@"ion: fixed;
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

        .feedpost header h6 {
            display: inline;
        }

    .feedpost .body img {
        max-width: 100%;
");
            WriteLiteral("        max-height: 100%;\r\n        height: auto;\r\n        width: 100%\r\n    }\r\n</style>\r\n\r\n<div class=\"feed\">\r\n");
#nullable restore
#line 120 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
     foreach (var item in Model.OrderByDescending(i=>i.PostDate).Where(i=>i.IsDeleted==false))
    {            var userr = await UserManager.FindByIdAsync(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"feedpost\">\r\n    <header>\r\n");
#nullable restore
#line 124 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
          
            string pb = null;

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
             if (userr.Photo == null)
                pb = "/images/user.png";
            else
                pb = "/images/" + userr.Photo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 2809, "\"", 2818, 1);
#nullable restore
#line 132 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 2815, pb, 2815, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h5>");
#nullable restore
#line 133 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
       Write(userr.MyUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6>");
#nullable restore
#line 134 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
       Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </header>\r\n    <div class=\"body\">\r\n\r\n        ");
#nullable restore
#line 138 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
   Write(Html.DisplayFor(modelItem => item.PostBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 139 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
         if (item.HasAttachment == true)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
             if (item.Attachment.Count > 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n");
#nullable restore
#line 145 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                     foreach (var photo in item.Attachment)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-6 mt-3\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0af9a763e9caac7f596a37a14b3f9aed728ed5810748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Images/");
#nullable restore
#line 147 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                       WriteLiteral(photo.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 147 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 149 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 151 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"

            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                 foreach (var photo in item.Attachment)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0af9a763e9caac7f596a37a14b3f9aed728ed5813993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Images/");
#nullable restore
#line 156 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                        WriteLiteral(photo.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 156 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
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
#line 156 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                                             
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
             

        }
        else
        {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0af9a763e9caac7f596a37a14b3f9aed728ed5817057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 161 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
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
#line 161 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 166 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
          
            var currentuser = ViewBag.IsAuth;

            var myuser = item.Likes.FirstOrDefault(i => i.UserId == currentuser && i.PostId == item.PostsId && i.IsDeleted == false);
            if (myuser == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0af9a763e9caac7f596a37a14b3f9aed728ed5819319", async() => {
                WriteLiteral("   Like ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                                   WriteLiteral(ViewBag.IsAuth);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
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
#line 171 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                                                                                                             }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0af9a763e9caac7f596a37a14b3f9aed728ed5822876", async() => {
                WriteLiteral("   unLike ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 174 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
                                                                     WriteLiteral(ViewBag.IsAuth);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 174 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
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
#line 175 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"

            }



        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 182 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
          
            var user = await UserManager.GetUserAsync(User);
            if (item.UserId.Equals(user.Id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4476, "\"", 4509, 3);
            WriteAttributeValue("", 4486, "editPost(", 4486, 9, true);
#nullable restore
#line 186 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 4495, item.PostsId, 4495, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4508, ")", 4508, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4551, "\"", 4586, 3);
            WriteAttributeValue("", 4561, "deletePost(", 4561, 11, true);
#nullable restore
#line 187 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 4572, item.PostsId, 4572, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4585, ")", 4585, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 188 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"

            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n    <div class=\"feedPostReact\">\r\n");
#nullable restore
#line 197 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
           var mydiv = "mylikescount" + @item.PostsId; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button");
            BeginWriteAttribute("id", " id=", 4756, "", 4766, 1);
#nullable restore
#line 199 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 4760, mydiv, 4760, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4790, "\"", 4823, 3);
            WriteAttributeValue("", 4800, "getcount(", 4800, 9, true);
#nullable restore
#line 199 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 4809, item.PostsId, 4809, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4822, ")", 4822, 1, true);
            EndWriteAttribute();
            WriteLiteral("> likes</button>\r\n\r\n\r\n        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4880, "\"", 4919, 3);
            WriteAttributeValue("", 4890, "viewModalLikes(", 4890, 15, true);
#nullable restore
#line 202 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"
WriteAttributeValue("", 4905, item.PostsId, 4905, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4918, ")", 4918, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Listt</a>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 212 "D:\iti\C# Summary\final facbook\Facbook\Facbook\Views\Shared\_PostIndexPartial.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
                <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js""></script>
                <script src=""https://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js""></script>

                <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js""></script>
                <script src=""https://ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js""></script>


");
                WriteLiteral(@"                <script type=""text/javascript"">
                    function editPost(id) {
                        $.ajax({
                            type: ""GET"",
                            url: ""Posts/Edit/"" + id,
                            success: function (response) {
                                $(""#emptyDiv"").html(response);
                                $(""#modalSubscriptionFormwe"").modal(""toggle"");
                            },
                            //success: function (response) {
                            //    alert(response)
                            //},
                            error: function () {
                                alert(""Error retreiving Posts"");
                            }
                        });
                    }
                    function deletePost(id) {
                        $.ajax({
                            type: ""GET"",
                            url: ""Posts/Delete/"" + id,
                            success: fu");
                WriteLiteral(@"nction (response) {
                                $(""#emptyDivDel"").html(response);
                                $(""#modalSubscriptionFormwd"").modal(""toggle"");
                            },
                            //success: function (response) {
                            //    alert(response)
                            //},
                            error: function () {
                                alert(""Error Deleting Posts"");
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
        public SignInManager<Users> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Users> UserManager { get; private set; }
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
