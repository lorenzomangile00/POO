

namespace Heranca
{
    public class Moto : Veiculos
    {
        public string Capacete;

        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); 
            Console.WriteLine($"Capacete: {Capacete}");
        }
    }
}