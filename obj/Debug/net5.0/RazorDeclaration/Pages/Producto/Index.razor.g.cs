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
    [Microsoft.AspNetCore.Components.RouteAttribute("/producto/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Nicole Pineda\OneDrive\Escritorio\AdminHamber\Acministrador.Hamber.blazor\Pages\Producto\Index.razor"
       
    private IEnumerable<Producto> productos = new List<Producto>();
    private string searchText = "";

    protected override async Task OnInitializedAsync()
    {
        await getAll();
    }

    private async Task getAll()
    {
        var httpResponse = await httpClient.GetStringAsync("producto");
        productos = JsonSerializer.Deserialize<IEnumerable<Producto>>(httpResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
    private void goAdd()
    {
        NavigationManager.NavigateTo("/producto/agregar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
