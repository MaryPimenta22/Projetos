using System;

public class Carro
{
    private string chassi;
    private double consumo; // em km/litro
    private double tanque; // em litros
    private double quilometragem; // em km

    public Carro(string chassi, double consumo)
    {
        if (chassi.Length != 17)
            throw new ArgumentException("O número do chassi deve ter 17 caracteres.");

        this.chassi = chassi;
        this.consumo = consumo;
        this.tanque = 0; // tanque inicia vazio
        this.quilometragem = 0; // quilometragem inicia em 0
    }

    public void AdicionarGasolina(double litros)
    {
        if (litros < 0)
            throw new ArgumentException("A quantidade de gasolina deve ser positiva.");

        tanque += litros;
    }

    public void Andar(double distancia)
    {
        double litrosNecessarios = distancia / consumo;

        if (litrosNecessarios > tanque)
        {
            Console.WriteLine("Não há combustível suficiente para andar essa distância.");
            distancia = tanque * consumo; // anda apenas o que é possível
        }

        quilometragem += distancia;
        tanque -= litrosNecessarios;
    }

    public void ImprimirDadosVeiculo()
    {
        Console.WriteLine($"Chassi: {chassi}");
        Console.WriteLine($"Consumo: {consumo} km/l");
        Console.WriteLine($"Tanque: {tanque} litros");
        Console.WriteLine($"Quilometragem: {quilometragem} km");
    }

    public override string ToString()
    {
        return $"Carro [Chassi={chassi}, Consumo={consumo} km/l, Tanque={tanque}L, Quilometragem={quilometragem} km]";
    }

    public override bool Equals(object obj)
    {
        if (obj is Carro outroCarro)
            return this.chassi == outroCarro.chassi;

        return false;
    }

    public override int GetHashCode()
    {
        return chassi.GetHashCode();
    }
}
