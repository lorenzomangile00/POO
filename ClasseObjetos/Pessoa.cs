
namespace ClasseObjetos
{
    public class Pessoa
    {
        public string nome = "";

        public int idade;

        public void falar()
        {
            Console.WriteLine($"Ola, meu nome e {nome}");
        }

        public int envelhecer(int anos)
        {
            if (anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return idade;
            }
            idade += anos;

            return idade;
        }



    }
}