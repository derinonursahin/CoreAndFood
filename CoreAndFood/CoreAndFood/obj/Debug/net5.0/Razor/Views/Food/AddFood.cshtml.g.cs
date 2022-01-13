#pragma checksum "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc67045e50724bee9f1467609041c99d46aa6369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_AddFood), @"mvc.1.0.view", @"/Views/Food/AddFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc67045e50724bee9f1467609041c99d46aa6369", @"/Views/Food/AddFood.cshtml")]
    public class Views_Food_AddFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.urunekle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
  
    ViewData["Title"] = "AddFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Food Add Page</h1>\r\n<br />\r\n<form class=\"form-group\" action=\"AddFood\" asp-controller=\"Food\" method=\"post\" enctype=\"multipart/form-data\">\r\n    ");
#nullable restore
#line 9 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x=>x.Name, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 12 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x=>x.Stock, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 15 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x=>x.Price, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Choose Image"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"file\" name=\"ImageURL\"/>\r\n    <br />\r\n    ");
#nullable restore
#line 21 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID, (List<SelectListItem>)ViewBag.v1,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 24 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\ONUR SAHIN\source\repos\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextAreaFor(x=>x.Description, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n    </form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.urunekle> Html { get; private set; }
    }
}
#pragma warning restore 1591
