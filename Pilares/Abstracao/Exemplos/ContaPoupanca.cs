

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Saldo atual de: R${Saldo}");
            }
            else
            {
                Console.WriteLine("O valor depositado nao pode ser igual zero");
            }
        }

        public override void Sacar(float valor)
        {
            if (Saldo > valor * 1.03f && valor > 0 && valor <= Saldo + valor * 1.03f)
            {
                Saldo -= valor * 1.03f;
                Console.WriteLine($"Saldo atual de: R${Saldo}");
            }
            else
            {
                Console.WriteLine(" O saldo ou valor desejado nao e suficiente");
            }

        }
    }
}