// CirculoVO.cs

public class CirculoVO : FiguraVO
{
    public double Raio { get; set; }

    public CirculoVO(double raio)
    {
        Raio = raio;
    }

    public override double Area()
    {
        return Math.PI * Raio * Raio;
    }
}
