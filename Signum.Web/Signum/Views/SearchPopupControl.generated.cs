﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
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
    using Signum.Entities;
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/SearchPopupControl.cshtml")]
    public partial class _Signum_Views_SearchPopupControl_cshtml : System.Web.Mvc.WebViewPage<Context>
    {
        public _Signum_Views_SearchPopupControl_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Signum\Views\SearchPopupControl.cshtml"
    FindOptions findOptions = (FindOptions)ViewData[ViewDataKeys.FindOptions];
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 101), Tuple.Create("\"", 134)
            
            #line 3 "..\..\Signum\Views\SearchPopupControl.cshtml"
, Tuple.Create(Tuple.Create("", 106), Tuple.Create<System.Object, System.Int32>(Model.Compose("panelPopup")
            
            #line default
            #line hidden
, 106), false)
);

WriteLiteral(" class=\"sf-search-popup modal fade\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"XXXX\"");

WriteLiteral(" data-prefix=\"");

            
            #line 3 "..\..\Signum\Views\SearchPopupControl.cshtml"
                                                                                                                                     Write(Model.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Signum\Views\SearchPopupControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 7 "..\..\Signum\Views\SearchPopupControl.cshtml"
                 if (!ViewData[ViewDataKeys.FindMode].Equals(FindMode.Find))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close sf-close-button\"");

WriteLiteral(">×</button>\r\n");

            
            #line 10 "..\..\Signum\Views\SearchPopupControl.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" style=\"float: right\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                            <button");

WriteAttribute("id", Tuple.Create(" id=\"", 743), Tuple.Create("\"", 771)
            
            #line 15 "..\..\Signum\Views\SearchPopupControl.cshtml"
, Tuple.Create(Tuple.Create("", 748), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnOk")
            
            #line default
            #line hidden
, 748), false)
);

WriteLiteral(" class=\"btn btn-primary sf-entity-button sf-close-button sf-ok-button\"");

WriteLiteral(">");

            
            #line 15 "..\..\Signum\Views\SearchPopupControl.cshtml"
                                                                                                                                  Write(JavascriptMessage.ok.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                            <button");

WriteAttribute("id", Tuple.Create(" id=\"", 1006), Tuple.Create("\"", 1038)
            
            #line 18 "..\..\Signum\Views\SearchPopupControl.cshtml"
, Tuple.Create(Tuple.Create("", 1011), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnCancel")
            
            #line default
            #line hidden
, 1011), false)
);

WriteLiteral(" class=\"btn btn-default sf-entity-button sf-close-button sf-cancel-button\"");

WriteLiteral(">");

            
            #line 18 "..\..\Signum\Views\SearchPopupControl.cshtml"
                                                                                                                                          Write(JavascriptMessage.cancel.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 21 "..\..\Signum\Views\SearchPopupControl.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <h4>\r\n                    <span");

WriteLiteral(" class=\"sf-entity-title\"");

WriteLiteral(">");

            
            #line 23 "..\..\Signum\Views\SearchPopupControl.cshtml"
                                             Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <a");

WriteAttribute("id", Tuple.Create(" id=\"", 1361), Tuple.Create("\"", 1396)
            
            #line 24 "..\..\Signum\Views\SearchPopupControl.cshtml"
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Model.Compose("sfFullScreen")
            
            #line default
            #line hidden
, 1366), false)
);

WriteLiteral(" class=\"sf-popup-fullscreen\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span>\r\n                    </a>\r\n                </h4>\r\n\r\n            </div>\r\n" +
"\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Signum\Views\SearchPopupControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Signum\Views\SearchPopupControl.cshtml"
                   
                    ViewData[ViewDataKeys.InPopup] = true;
                    ViewData[ViewDataKeys.AvoidFullScreenButton] = true;
                    Html.RenderPartial(Finder.Manager.SearchControlView, Model);
                
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Signum\Views\SearchPopupControl.cshtml"
           Write(Html.ValidationSummaryAjax(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
