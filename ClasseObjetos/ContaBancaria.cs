

namespace ClasseObjetos

{
    public class AgenciaBancaria
    {
        public string titular;
        public double saldo;

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            MostrarSaldo();
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
            MostrarSaldo();
        }

   
        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo atual de {titular}: R${saldo}");
        }
    }
}
