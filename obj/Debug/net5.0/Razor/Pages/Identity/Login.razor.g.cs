#pragma checksum "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a36f3a5a81ad1f779c48a2e5bcf46397ec8320"
// <auto-generated/>
#pragma warning disable 1591
namespace DoiT_Study_Manager.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using DoiT_Study_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using DoiT_Study_Manager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MinShiGee\Desktop\doit-study-manager\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/identity/Account/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"margin-top: 1rem;\">Login</h2>\r\n<hr>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "style", "width: 40%");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLogin>(4);
                __builder2.AddAttribute(5, "AllowRegister", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "AllowResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                                                                  userName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Password", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                                                                                     password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Login", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoginArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoginArgs>(this, 
#nullable restore
#line 7 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                    args => OnLogin(args, "Login with default values")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "ResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 8 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                            args => OnResetPassword(args, "Login with default values")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "Register", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
                                       args => OnRegister("Login with default values")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Style", "margin-bottom: 20px;");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\MinShiGee\Desktop\doit-study-manager\Pages\Identity\Login.razor"
       
    string userName = "";
    string password = "";

    void OnLogin(LoginArgs args, string name)
    {

    }

    void OnRegister(string name)
    {

    }

    void OnResetPassword(string value, string name)
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
