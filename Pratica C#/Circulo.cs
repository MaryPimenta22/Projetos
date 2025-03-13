
public class Circulo : Figura
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double Area()
    {
        return Math.PI * Raio * Raio;
    }
}
