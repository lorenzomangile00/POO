
namespace PrimeiraClasse
{
    public class Hello
    {
        //propriedades/caracteristicas - variaveis internas da classe
        public string TextoHello = "";

        //metodos/comportamento/acoes - sao as funcoes internas dessa classe
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
        public void SaudarComNome(string n)
        {
            Console.WriteLine($"Ola {n}");
        }
    }
}

