#pragma checksum "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49bc8e2f5d9ea39053e5169df2d7bd4148cf83ab"
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
    public partial class ListadoPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
 if (Peliculas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<img src=\"https://upload.wikimedia.org/wikipedia/commons/c/c7/Loading_2.gif?20170503175831\">");
            __builder.AddContent(1, "Cargando...");
#nullable restore
#line 4 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                            
}
else if (Peliculas.Count == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar...");
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "checkbox");
            __builder.AddAttribute(5, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                                  MostrarBotones

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MostrarBotones = __value, MostrarBotones));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
     foreach (var pelicula in Peliculas)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.PeliculaIndividual>(7);
            __builder.AddAttribute(8, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPeliculas.Shared.Entidades.Pelicula>(
#nullable restore
#line 15 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                                      pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "EliminarPelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorPeliculas.Shared.Entidades.Pelicula>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorPeliculas.Shared.Entidades.Pelicula>(this, 
#nullable restore
#line 15 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                                  EliminarPelicula

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "MostrarBotones", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
                                            MostrarBotones

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\ENDERSSONMENDOZA\Desktop\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
       
    [Parameter] public List<Pelicula> Peliculas { get; set; }
    bool MostrarBotones = true;

    void EliminarPelicula(Pelicula pelicula)
    {
        Peliculas.Remove(pelicula);
        Console.WriteLine($"Se ha eliminado la película {pelicula.Titulo}");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
