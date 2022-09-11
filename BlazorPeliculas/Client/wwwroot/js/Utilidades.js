function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("Blazor.Peliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Conteo desde Javascript " + resultado);
        });
}

function pruebaPuntoNETInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}