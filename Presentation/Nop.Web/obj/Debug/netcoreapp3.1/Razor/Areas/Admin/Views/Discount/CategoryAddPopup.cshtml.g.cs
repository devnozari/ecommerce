#pragma checksum "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d2fdf71ad75f06217e612e6a222fe98106cfe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discount_CategoryAddPopup), @"mvc.1.0.view", @"/Areas/Admin/Views/Discount/CategoryAddPopup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d2fdf71ad75f06217e612e6a222fe98106cfe6", @"/Areas/Admin/Views/Discount/CategoryAddPopup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Discount_CategoryAddPopup : Nop.Web.Framework.Mvc.Razor.NopRazorPage<AddCategoryToDiscountSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Discount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryAddPopup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
  
    Layout = "_AdminPopupLayout";

    //page title
    ViewBag.PageTitle = T("Admin.Promotions.Discounts.AppliedToCategories.AddNew").Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
 if (ViewBag.RefreshPage == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        try {window.opener.document.forms[\'");
#nullable restore
#line 14 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                                       Write(Context.Request.Query["formId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'].");
#nullable restore
#line 14 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                                                                            Write(Context.Request.Query["btnId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".click();}\r\n        catch (e){}\r\n        window.close();\r\n    </script>\r\n");
#nullable restore
#line 18 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d2fdf71ad75f06217e612e6a222fe98106cfe616987", async() => {
                WriteLiteral("\r\n        <div class=\"content-header clearfix\">\r\n            <h1 class=\"pull-left\">\r\n                ");
#nullable restore
#line 27 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
           Write(T("Admin.Promotions.Discounts.AppliedToCategories.AddNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </h1>
            <div class=""pull-right"">
                &nbsp;
            </div>
        </div>

        <div class=""content"">
            <div class=""form-horizontal"">
                <div class=""panel-group"">
                    <div class=""panel panel-default panel-search panel-popup"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-sm-8"">
                                    <div class=""form-group"">
                                        <div class=""col-sm-4"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75d2fdf71ad75f06217e612e6a222fe98106cfe618330", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 43 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchCategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"col-sm-8\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75d2fdf71ad75f06217e612e6a222fe98106cfe620044", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 46 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchCategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""col-sm-8 col-sm-offset-4"">
                                            <button type=""button"" id=""search-categories"" class=""btn btn-primary btn-search"">");
#nullable restore
#line 51 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                                                                                                                       Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""panel panel-default"">
                        <div class=""panel-body"">
                            ");
#nullable restore
#line 61 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                       Write(await Html.PartialAsync("Table", new DataTablesModel
                            {
                                Name = "categories-grid",
                                UrlRead = new DataUrl("CategoryAddPopupList", "Discount", null),
                                SearchButtonId = "search-categories",
                                Length = Model.PageSize,
                                LengthMenu = Model.AvailablePageSizes,
                                Filters = new List<FilterParameter>
                                {
                                    new FilterParameter(nameof(Model.SearchCategoryName))
                                },
                                ColumnCollection = new List<ColumnProperty>
                                {
                                    new ColumnProperty(nameof(CategoryModel.Id))
                                    {
                                        IsMasterCheckBox = true,
                                        Render = new RenderCheckBox(nameof(AddCategoryToDiscountModel.SelectedCategoryIds)),
                                        ClassName =  NopColumnClassDefaults.CenterAll,
                                        Width = "50"
                                    },
                                    new ColumnProperty(nameof(CategoryModel.Breadcrumb))
                                    {
                                        Title = T("Admin.Catalog.Categories.Fields.Name").Text
                                    },
                                    new ColumnProperty(nameof(CategoryModel.Published))
                                    {
                                        Title = T("Admin.Catalog.Categories.Fields.Published").Text,
                                        Width = "100",
                                        ClassName = NopColumnClassDefaults.CenterAll,
                                        Render = new RenderBoolean()
                                    }
                                }
                            }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                        <div class=""panel-footer"">
                            <button type=""submit"" name=""save"" class=""btn bg-blue"">
                                <i class=""fa fa-floppy-o""></i>
                                ");
#nullable restore
#line 98 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                           Write(T("Admin.Common.Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-discountId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                    WriteLiteral(Context.Request.Query["discountId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["discountId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-discountId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["discountId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
               WriteLiteral(Context.Request.Query["btnId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["btnId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-btnId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["btnId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
                WriteLiteral(Context.Request.Query["formId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["formId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-formId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["formId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\nozary\Desktop\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Discount\CategoryAddPopup.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddCategoryToDiscountSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591