#pragma checksum "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3529d34d86163de83a6dfbc58301e759a87343f"
// <auto-generated/>
#pragma warning disable 1591
namespace Administrador.Hamber.blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Administrador.Hamber.blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Administrador.Hamber.blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Administrador.Hamber.blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Administrador.Hamber.blazor.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 2 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                   Color.Tertiary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Style", "border-left-style");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(4);
                __builder2.AddAttribute(5, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 3 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                              Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Href", "/");
                __builder2.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(12);
                __builder2.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                       Icons.Filled.People

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 4 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                       Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Href", "/clientes");
                __builder2.AddAttribute(16, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                                              NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Clientes");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(20);
                __builder2.AddAttribute(21, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                       Icons.Sharp.AddShoppingCart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                               Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Href", "/productos");
                __builder2.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                                                       NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, "Productos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(28);
                __builder2.AddAttribute(29, "Title", "Mas");
                __builder2.AddAttribute(30, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(32);
                    __builder3.AddAttribute(33, "Href", "/categorias");
                    __builder3.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                              Icons.Sharp.Apps

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                           Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Categorias");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(40);
                    __builder3.AddAttribute(41, "Href", "/marcas");
                    __builder3.AddAttribute(42, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                          Icons.Sharp.AppsOutage

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                             Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                                                                   NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(46, "Marcas");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudThemeProvider>(48);
                __builder2.AddAttribute(49, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 11 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                             _theme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "IsDarkMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                         _isDarkMode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "IsDarkModeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _isDarkMode = __value, _isDarkMode))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSwitch<bool>>(53);
                __builder2.AddAttribute(54, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Class", "ma-4");
                __builder2.AddAttribute(56, "Label", "Tema Dark xd");
                __builder2.AddAttribute(57, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 12 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
                               _isDarkMode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "CheckedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _isDarkMode = __value, _isDarkMode))));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Shared\NavMenu.razor"
          
        private MudTheme _theme = new();
        private bool _isDarkMode;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
