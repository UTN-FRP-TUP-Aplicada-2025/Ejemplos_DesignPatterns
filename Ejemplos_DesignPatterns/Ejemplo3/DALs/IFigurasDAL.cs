using Ejemplo3.Models;

namespace Ejemplo3.DALs;

public interface IFigurasDAL
{
    List<FiguraModel> GetAll();
    FiguraModel? GetById(int id);
    FiguraModel? Add(FiguraModel figura);
    FiguraModel? Save(FiguraModel nuevo);
    void Remove(int id);
}
