#pragma checksum "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8897165bb7fb940e10990e541d292f4441511c6b"
// <auto-generated/>
#pragma warning disable 1591
namespace Administrador.Hamber.blazor.Pages.Producto
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/producto/editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
               Typo.h2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "ml");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Editar Producto");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(8);
                __builder2.AddAttribute(9, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                         7

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(12);
                    __builder3.AddAttribute(13, "Class", "pa-4");
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
                        __builder4.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                             produ

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                   OnValidSubmit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(20, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCard>(21);
                            __builder5.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudCardContent>(23);
                                __builder6.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar.TypeInference.CreateMudTextField_0(__builder7, 25, 26, "Nombre", 27, 
#nullable restore
#line 15 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                       () => produ.Nombre

#line default
#line hidden
#nullable disable
                                    , 28, 
#nullable restore
#line 15 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                  produ.Nombre

#line default
#line hidden
#nullable disable
                                    , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produ.Nombre = __value, produ.Nombre)));
                                    __builder7.AddMarkupContent(30, "\r\n                        ");
                                    __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar.TypeInference.CreateMudTextField_1(__builder7, 31, 32, "categoria", 33, 
#nullable restore
#line 16 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                               () => produ.IdCategoria

#line default
#line hidden
#nullable disable
                                    , 34, 
#nullable restore
#line 16 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                     produ.IdCategoria

#line default
#line hidden
#nullable disable
                                    , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produ.IdCategoria = __value, produ.IdCategoria)));
                                    __builder7.AddMarkupContent(36, "\r\n                        ");
                                    __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar.TypeInference.CreateMudTextField_2(__builder7, 37, 38, "marca", 39, 
#nullable restore
#line 17 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                       () => produ.IdMarca

#line default
#line hidden
#nullable disable
                                    , 40, 
#nullable restore
#line 17 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                 produ.IdMarca

#line default
#line hidden
#nullable disable
                                    , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produ.IdMarca = __value, produ.IdMarca)));
                                    __builder7.AddMarkupContent(42, "\r\n                        ");
                                    __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar.TypeInference.CreateMudTextField_3(__builder7, 43, 44, "descripcion", 45, 
#nullable restore
#line 18 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                                 () => produ.Descripcion

#line default
#line hidden
#nullable disable
                                    , 46, 
#nullable restore
#line 18 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                       produ.Descripcion

#line default
#line hidden
#nullable disable
                                    , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produ.Descripcion = __value, produ.Descripcion)));
                                    __builder7.AddMarkupContent(48, "\r\n                        ");
                                    __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar.TypeInference.CreateMudTextField_4(__builder7, 49, 50, "precio", 51, 
#nullable restore
#line 19 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                       () => produ.Precio

#line default
#line hidden
#nullable disable
                                    , 52, 
#nullable restore
#line 19 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                  produ.Precio

#line default
#line hidden
#nullable disable
                                    , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produ.Precio = __value, produ.Precio)));
                                    __builder7.AddMarkupContent(54, "\r\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudDivider>(55);
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudCardActions>(57);
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudButton>(59);
                                    __builder7.AddAttribute(60, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 23 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                               ButtonType.Submit

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(61, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 23 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                           Variant.Filled

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(62, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                                  Color.Primary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(63, "Class", "ml-auto");
                                    __builder7.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(65, "Guardar cambios");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 27 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
             if (showLeaveAlert)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAlert>(66);
                        __builder4.AddAttribute(67, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 29 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                    Severity.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "ContentAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.HorizontalAlignment>(
#nullable restore
#line 29 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                      HorizontalAlignment.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "CloseIconClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.MudAlert>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.MudAlert>(this, 
#nullable restore
#line 29 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
                                                                                                                                         (() => CloseMe(true))

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(72, "Ocurrió un problema.");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 30 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Editar.razor"
       
    [Parameter]
    public int id { get; set; }
    private bool showLeaveAlert = false;
    Producto produ = new Producto();

    protected override async Task OnInitializedAsync()
    {
        Http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", await _localStorageService.GetItemAsync<string>("token"));

        var resp = await Http.GetStringAsync("producto/" + id);
        produ = JsonSerializer.Deserialize<Producto>(resp, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    private async Task OnValidSubmit(EditContext context)
    {
        await saveChanges();
    }

    private async Task saveChanges()
    {

        var httpResponse = await Http.PutAsJsonAsync<Producto>("producto/" + produ.Id, produ);

        if (!(httpResponse.StatusCode == System.Net.HttpStatusCode.OK))
        {
            showLeaveAlert = true;
        }
        else
        {
            NavigationManager.NavigateTo("/producto/index");
        }
    }

    private void CloseMe(bool value)
    {
        showLeaveAlert = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Administrador.Hamber.blazor.Pages.Producto.Editar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591