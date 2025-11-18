

namespace Exercicio01
{
    public class Circulo : IForma
    {

        public float Raio;

        private float PI = 3.14f;

        public void CalcularArea()
        {

            System.Console.WriteLine($"O raio do circulo e {PI * Raio * Raio}");
        }
    }
}