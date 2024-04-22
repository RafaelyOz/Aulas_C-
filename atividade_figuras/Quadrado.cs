public class Quadrado : FiguraGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;

    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}