// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/producto/agregar")]
    public partial class Agregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Agregar.razor"
       
    bool success;
    private bool showLeaveAlert = false;
    Producto produc = new Producto();

    protected override async Task OnInitializedAsync()
    {
        Http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", await _localStorageService.GetItemAsync<string>("token"));
    }

    private async Task OnValidSubmit(EditContext context)
    {
        await save();
        success = true;
        StateHasChanged();
    }

    private async Task save()
    {

        var httpResponse = await Http.PostAsJsonAsync<Producto>("producto", produc);

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
#pragma warning restore 1591
