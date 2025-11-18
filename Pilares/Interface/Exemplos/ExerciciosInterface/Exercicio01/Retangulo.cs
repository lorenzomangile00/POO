

namespace Exercicio01
{
    public class Retangulo : IForma
    {

        public float Largura;

        public float Altura;

        public void CalcularArea()
        {
            System.Console.WriteLine($"A area do retangulo e {Largura * Altura}");
        }
    }
}