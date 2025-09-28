
using Ejemplo2;
using Ejemplo2.DALs;
using Ejemplo2.DALs.List;
using Ejemplo2.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
.ConfigureServices((context, services) =>
{
    IConfiguration configuration = context.Configuration;

    //registro de servicios
    services.AddSingleton<IFigurasDAL, FigurasListDAL>();
   
})
.Build();


//lo siguiente podría ser un metodo en un servicio - ver ejemplo3
//consiguiendo el formulario principal
var figuraDAL = host.Services.GetRequiredService<IFigurasDAL>();

figuraDAL.Add(new RectanguloModel() { Area = null, Ancho = 1, Largo = 1 });
figuraDAL.Add(new CirculoModel() { Area = null, Radio = 1 });

foreach (FiguraModel figura in figuraDAL.GetAll())
{
    Console.WriteLine(figura);
}
