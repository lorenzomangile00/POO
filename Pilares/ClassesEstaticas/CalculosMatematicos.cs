

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {

        /*operacoes matematicas simples
        visibilidade tipoDeRetorno Nome (parametros){corpo}*/
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtracao(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicacao(float a, float b)
        {
            return a * b;
        }

        public static float Dividir(float a, float b)
        {
            if (b == 0)
            {
                System.Console.WriteLine($"Nao e possivel a divisao por 0");
            } 
                return a / b;
            
        }
    }
}