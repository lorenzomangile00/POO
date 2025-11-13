

namespace Heranca
{
    public class Veiculos
    {
        public string Marca;

        public string Modelo;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($" Modelo: {Modelo}");
        }
    }
}