

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Miau");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"O gato engatinhou");
        }
    }
}