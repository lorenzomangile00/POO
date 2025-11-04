

namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;


        public Carro(string ma, string mod, int a)
        {
            Marca = ma;
            Modelo = mod;
            Ano = a;
        }

        

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"-------Carro------
                                        Marca:{Marca}
                                        Modelo:{Modelo}
                                        Ano:{Ano}");
        }
    }
}