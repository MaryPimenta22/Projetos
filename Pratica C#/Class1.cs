// ATUALIZAÇÃO DO METODO MAIN
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Início do main...");

        Ponto p1 = new Ponto();
        p1.ImprimirCoordenadas();
        p1.IncrementarCoordenadas(5, 2);
        p1.ZerarCoordenadas();
        p1.ImprimirCoordenadas();
        p1.IncrementarCoordenadas(5, 2);
        p1.ZerarCoordenadas();
        p1.ImprimirCoordenadas();

        Ponto p2 = new Ponto();
        p2.ImprimirCoordenadas();
        p2.IncrementarCoordenadas(6, 9);
        p2.ImprimirCoordenadas();
        p2.IncrementarCoordenadas(5, 2);
        p2.ImprimirCoordenadas();
        p2.ZerarCoordenadas();

        Console.WriteLine("Fim do main...");
    }
}
