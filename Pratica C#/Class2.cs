// Encapsulamento e Métodos Acessores
public class Ponto
{
    // Atributos privados
    private int x;
    private int y;

    // Métodos acessores
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // Método para incrementar as coordenadas
    public void IncrementarCoordenadas(int deltaX, int deltaY)
    {
        x += deltaX;
        y += deltaY;
    }

    // Método para imprimir as coordenadas
    public void ImprimirCoordenadas()
    {
        Console.WriteLine($"x={x}, y={y}");
    }

    // Método para zerar as coordenadas
    public void ZerarfCoordenadas()
    {
        x = 0;
        y = 0;
    }
}
