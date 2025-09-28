using Ejemplo;
using Ejemplo.DALs.Factories;
using Ejemplo.Models;

Console.WriteLine("Ejemplo de prueba");

//me devuelve el tipo de factoria que necesito - 
//en este caso el grupo que construye las clases para persistencia en una lista en memoria.
DALFactory dalFactory = DALFactory.GetDALFactory("List");

dalFactory.GetFigurasDAL().Add(new RectanguloModel() { Area=null, Ancho=1, Largo=1});
dalFactory.GetFigurasDAL().Add(new CirculoModel() { Area = null, Radio = 1 });


foreach (FiguraModel figura in dalFactory.GetFigurasDAL().GetAll())
{ 
    Console.WriteLine(figura);
};