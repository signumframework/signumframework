﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Views
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Signum\Views\NormalControl.cshtml"
    using System.Configuration;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Signum\Views\NormalControl.cshtml"
    using Signum.Engine.Operations;
    
    #line default
    #line hidden
    using Signum.Entities;
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/NormalControl.cshtml")]
    public partial class NormalControl : System.Web.Mvc.WebViewPage<TypeContext>
    {
        public NormalControl()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Signum\Views\NormalControl.cshtml"
  
    ModifiableEntity modifiable = Model.UntypedValue as ModifiableEntity;
    string partialViewName = ViewData[ViewDataKeys.PartialViewName].ToString();

            
            #line default
            #line hidden
WriteLiteral("\r\n<h3>\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.Hidden(ViewDataKeys.TabId, ViewData[ViewDataKeys.TabId]));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.Hidden(ViewDataKeys.PartialViewName, ViewData[ViewDataKeys.PartialViewName]));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..\Signum\Views\NormalControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Signum\Views\NormalControl.cshtml"
     if (string.IsNullOrEmpty(ViewBag.Title))
    {
        ViewBag.Title = modifiable.TryToString();
    }

            
            #line default
            #line hidden
WriteLiteral("    <span");

WriteLiteral(" class=\"sf-entity-title\"");

WriteLiteral(">");

            
            #line 17 "..\..\Signum\Views\NormalControl.cshtml"
                              Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    <br />\r\n    <small");

WriteLiteral(" class=\"sf-type-nice-name\"");

WriteLiteral(">");

            
            #line 19 "..\..\Signum\Views\NormalControl.cshtml"
                                Write(Navigator.Manager.GetTypeTitle(modifiable));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n</h3>\r\n");

            
            #line 21 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.RenderWidgetsForEntity(modifiable, partialViewName, Model.Prefix));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-button-bar\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 23 "..\..\Signum\Views\NormalControl.cshtml"
Write(ButtonBarEntityHelper.GetForEntity(new EntityButtonContext
    {
        Url = Url,
        ViewMode = ViewMode.Navigate,
        ShowOperations = (bool)ViewData[ViewDataKeys.ShowOperations],
        ControllerContext = this.ViewContext,
        PartialViewName = ViewData[ViewDataKeys.PartialViewName].ToString(),
        Prefix = Model.Prefix
    }, (ModifiableEntity)Model.UntypedValue).ToStringButton(Html));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 33 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.ValidationSummaryAjax());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 34 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.HiddenRuntimeInfo(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..\Signum\Views\NormalControl.cshtml"
 if (((bool?)ViewData[ViewDataKeys.WriteEntityState]) == true)
{
    
            
            #line default
            #line hidden
            
            #line 37 "..\..\Signum\Views\NormalControl.cshtml"
Write(Html.Hidden(ViewDataKeys.EntityState, Navigator.Manager.SerializeEntity(modifiable)));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Signum\Views\NormalControl.cshtml"
                                                                                         
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" id=\"divMainControl\"");

WriteLiteral(" class=\"sf-main-control\"");

WriteLiteral(" data-prefix=\"");

            
            #line 39 "..\..\Signum\Views\NormalControl.cshtml"
                                                         Write(Model.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-test-ticks=\"");

            
            #line 39 "..\..\Signum\Views\NormalControl.cshtml"
                                                                                         Write(DateTime.Now.Ticks);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

            
            #line 40 "..\..\Signum\Views\NormalControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 40 "..\..\Signum\Views\NormalControl.cshtml"
       Html.RenderPartial(partialViewName, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
