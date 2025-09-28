using Ejemplo.DALs;
using Ejemplo.DALs.Factories;
using Ejemplo1.DALs.List;

namespace Ejemplo1.DALs.Factories.List;

public class ListDALFactory: DALFactory
{
    override public IFigurasDAL GetFigurasDAL()
    { 
        return FigurasListDAL.GetInstance();
    }

    // get otro DAL
}
