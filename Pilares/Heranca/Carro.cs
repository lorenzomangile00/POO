

namespace Heranca
{
    public class Carro : Veiculos
    {
        public int NumeroPortas;

        public void MostrarInfo()
        {
            Console.WriteLine($" Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); 
            Console.WriteLine($"Portas: {NumeroPortas}");
        }
    }
}