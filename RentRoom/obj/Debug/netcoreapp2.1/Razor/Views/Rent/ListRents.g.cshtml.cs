#pragma checksum "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc270dfd606fe1bdf2bb8563028dad0a156ec8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rent_ListRents), @"mvc.1.0.view", @"/Views/Rent/ListRents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rent/ListRents.cshtml", typeof(AspNetCore.Views_Rent_ListRents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc270dfd606fe1bdf2bb8563028dad0a156ec8b3", @"/Views/Rent/ListRents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Rent_ListRents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentRoom.ViewModels.ListRentsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
  
    ViewData["Title"] = "ListRents";

#line default
#line hidden
            BeginContext(107, 92, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-sm navbar-light\" style=\"background-color: #e3f2fd\">\r\n    ");
            EndContext();
            BeginContext(200, 43, false);
#line 8 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
Write(Html.ActionLink("Home", "Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(243, 157, true);
            WriteLiteral("\r\n    <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\">\r\n        <ul class=\"navbar-nav mr-auto\">\r\n            <li class=\"nav-link active\">\r\n");
            EndContext();
#line 12 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
            BeginContext(493, 51, false);
#line 14 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
               Write(Html.ActionLink("Rezerwacja Sali", "Index", "Rent"));

#line default
#line hidden
            EndContext();
#line 14 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
                                                                        

                }

#line default
#line hidden
            BeginContext(567, 50, true);
            WriteLiteral("            </li>\r\n            \r\n        </ul>\r\n\r\n");
            EndContext();
#line 21 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
         if (User.Identity.IsAuthenticated)
        {
            

#line default
#line hidden
            BeginContext(686, 46, false);
#line 23 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
       Write(Html.ActionLink("Logout", "LogOut", "Account"));

#line default
#line hidden
            EndContext();
#line 23 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
                                                           
        }

#line default
#line hidden
            BeginContext(745, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(803, 67, true);
            WriteLiteral("            <div class=\"magin-right\">Użytkownik Zalogowany.</div>\r\n");
            EndContext();
#line 29 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(906, 70, true);
            WriteLiteral("            <div class=\"magin-right\">Użytkownik Niezalogowany.</div>\r\n");
            EndContext();
#line 33 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
        }

#line default
#line hidden
            BeginContext(987, 394, true);
            WriteLiteral(@"
    </div>
</nav>

<table class=""table table table-striped"">
    <thead>
    <tr>
        <th class=""col-md-2"" >
            <label>Nazwa Sali</label>
        </th>
        <th class=""col-md-2"">
            <label>Data</label>
        </th>
        <th class=""col-md-2"">
            <label>Godzina</label>
        </th>
        <th></th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 54 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1413, 53, true);
            WriteLiteral("    <tr>\r\n        <td class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(1467, 45, false);
#line 57 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
       Write(Html.DisplayFor(modelItem => item.NameOfRoom));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 60, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(1573, 46, false);
#line 60 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
       Write(Html.DisplayFor(modelItem => item.DateOfEvent));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 60, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(1680, 44, false);
#line 63 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
       Write(Html.DisplayFor(modelItem => item.HourEvent));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 45, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n\r\n            ");
            EndContext();
            BeginContext(1769, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63394f59b03844298ca68266da821c5b", async() => {
                BeginContext(1834, 10, true);
                WriteLiteral("Rezygnacja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1848, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 70 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Rent\ListRents.cshtml"
}

#line default
#line hidden
            BeginContext(1879, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentRoom.ViewModels.ListRentsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
