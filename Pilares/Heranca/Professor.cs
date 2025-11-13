

namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Disciplina {Disciplina}");
        }
    }
}