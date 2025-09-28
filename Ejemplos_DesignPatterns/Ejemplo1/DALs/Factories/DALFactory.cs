namespace Ejemplo.DALs.Factories;
abstract public class DALFactory
{
    public static DALFactory GetDALFactory(string tipo)
    {
        if (tipo == "List")
        {
            return new ListDALFactory();
        }
        //else if (tipo == "OtroTipo"){...}
        
        return null;
    }

    abstract public IFigurasDAL GetFigurasDAL();

    //otro abstract get  DAL
}
