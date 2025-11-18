

namespace Exemplos
{
    public class ControleRemoto : IControle.3
    {
        
        public int NivelVolume = 0;

        public int VolumeMaximo = 100;

        void Ligar()
        {
           System.Console.WriteLine($"Ligando a tv...");
        }

        void Desligar()
        {
            System.Console.WriteLine($"Desligando a tv...");
        }

        void AumentarVolume()
        {
            if (NivelVolume > VolumeMaximo){
                NivelVolume++;
                System.Console.WriteLine($"Nivel atual do volume {NivelVolume}");
            } else
            {
                System.Console.WriteLine($"O volume ja atingiu o nivel maximo {NivelVolume}");
            }
        }

        void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"O volume ja esta no minimo {NivelVolume}");
            } else
            {
                System.Console.WriteLine($"Nivel atual do volume: {NivelVolume}");
            }
        }
    }
}