

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Falar");
        }

        public override void Mover()
        {
         System.Console.WriteLine($"A pessoa esta andando");
        }
    }
}