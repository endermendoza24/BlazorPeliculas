#pragma checksum "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f436f6aeb8c156a5b9915a8bfe686d1e9e13b9b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "Título: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                   Pelicula.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Lanzamiento: ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                        Pelicula.Lanzamiento.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
      
    [Parameter] public  Pelicula Pelicula { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591