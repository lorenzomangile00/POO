

namespace Heranca
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Curso: {Curso}");
        }
    }
}