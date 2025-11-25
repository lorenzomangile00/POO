 using Encapsulamento;

// float dinheiro = -200;

// ContaBancaria contaLorenzo = new ContaBancaria();
// ContaBancaria contaGueba = new ContaBancaria(dinheiro);

// contaLorenzo.Depositar(dinheiro);
// System.Console.WriteLine($"Saldo do Lorenzo: R${contaLorenzo.GetSaldo()}");
// System.Console.WriteLine($"Saldo do Gueba: R${contaGueba.GetSaldo()}");

// contaLorenzo.Sacar(100);
// Console.WriteLine($"Saldo do Lorenzo apos saque: R${contaLorenzo.GetSaldo()}");



public static class Program
{
    public static void Main()
    {
        Carro c1 = new Carro();

        c1.DefinirMarca("BMW");
        c1.DefinirModelo("Hatch");

        c1.Acelerar(50);
        c1.Acelerar(20);
        c1.Frear(30);
        c1.Frear(50);

        Console.WriteLine($"Marca do carro:  {c1.ObterMarca()}");
        Console.WriteLine($"Modelo do carro: {c1.ObterModelo()}");
        Console.WriteLine($"Velocidade atual: {c1.ObterVelocidade()} km/h");
    }
}