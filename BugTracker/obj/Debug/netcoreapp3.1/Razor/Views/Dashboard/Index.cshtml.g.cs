#pragma checksum "D:\Project_BugTracker\Project_BugTracker\BugTracker\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2226aa613537a49636db65a364ec36d2633c461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\Project_BugTracker\Project_BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project_BugTracker\Project_BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2226aa613537a49636db65a364ec36d2633c461", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project_BugTracker\Project_BugTracker\BugTracker\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid mt-n3 p-0"">
    <div class=""row flex-nowrap"">
        <div class=""col-auto col-md-3 col-xl-2 px-sm-2 px-0"" style=""background-color: #6B6FE5; "">
            <div class=""d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100"">
                <a href=""/"" class=""d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none"">
                    <div class=""container"" style=""background-color: #4E55C7;"">
                        <span class=""fs-5 d-none d-sm-inline"">Menu</span>
                </a>
                <div class=""dropdown pb-4"">
                    <a href=""#"" class=""d-flex align-items-center text-white text-decoration-none dropdown-toggle"" id=""dropdownUser1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                        <img src=""https://github.com/JorisDeRidder42.png"" alt=""Profilepic"" width=""30"" height=""30"" class=""rounded-circle"">
                        <span class=""d-none d-sm-inline mx-1"">Admin");
            WriteLiteral(@"</span>
                    </a>
                    <ul class=""dropdown-menu dropdown-menu-dark text-small shadow"">
                        <li><a class=""dropdown-item"" href=""#"">New project...</a></li>
                        <li><a class=""dropdown-item"" href=""#"">Settings</a></li>
                        <li><a class=""dropdown-item"" href=""#"">Profile</a></li>
                        <li>
                            <hr class=""dropdown-divider"">
                        </li>
                        <li><a class=""dropdown-item text-white"" href=""#"">Sign out</a></li>
                    </ul>
                </div>
            </div>
            <ul class=""nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start"" id=""menu"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link align-middle px-0 text-white"">
                        <i class=""fas fa-home""></i> <span class=""ms-1 d-none d-sm-inline"">Home</span>
                    </a>
       ");
            WriteLiteral(@"         </li>
                <li>
                    <a href=""#"" class=""nav-link px-0 align-middle text-white"">
                        <i class=""fas fa-bug""></i> <span class=""ms-1 d-none d-sm-inline"">Bugs</span>
                    </a>
                </li>
                <li>
                    <a href=""#submenu2"" data-bs-toggle=""collapse"" class=""nav-link px-0 align-middle text-white"">
                        <i class=""fas fa-user""></i> <span class=""ms-1 d-none d-sm-inline"">Users</span>
                    </a>
                </li>
            </ul>
            <hr>
        </div>
    </div>
    <div class=""col py-3"">
        <div class=""container"">
            <div class=""row mt-3"">
                <div class=""col-md-6"">
                    <h1>My bugs</h1>
                </div>
                <div class=""col-md-6 text-right"">
                    <button class=""btn btn-primary text-right"">Create issue</button>
                </div>
            </div>
            <div clas");
            WriteLiteral(@"s=""row mt-5"">
                <div class=""col-md-4"">
                    <p class=""inline-p"">BUG</p>
                </div>
                <div class=""col-md-8 text-right"">
                    <p class=""inline-p"">STATUS</p>
                    <p class=""inline-p"">CREATE</p>
                    <p class=""inline-p"">DUE</p>
                    <p class=""inline-p"">REPORTER</p>
                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-12"">
                    <span style=""font-size: 2em;"">
                        <i class=""fas fa-plus-circle""></i>
                        <h3>Webapplicaties</h3>
                    </span>
                </div>
                <div class=""row mt-3"">
                    <div class=""col-12"">
                        <p class=""inline-p"">MER22</p>
                        <p class=""inline-p"">Create company logo in 3 diffrent styles</p>
                    </div>
                </div>
            </div>
       ");
            WriteLiteral(" </div>\r\n    </div>\r\n</div>");
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