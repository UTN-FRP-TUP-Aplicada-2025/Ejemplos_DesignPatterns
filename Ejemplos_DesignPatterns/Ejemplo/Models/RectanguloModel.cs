
using Ejemplo.Models;

namespace Ejemplo;

public class RectanguloModel:FiguraModel
{
    public double? Ancho { get; set; }
    public double? Largo { get; set; }

    public override string ToString()
    {
        return $"Figura:Rectangulo, Ancho:{Ancho}, Largo:{Largo}";
    }
}
