using Exemplos;


ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

cc.Sacar(10);
cp.Sacar(5);

System.Console.WriteLine($"Saldo Conta corrente antes do saque: R${cc.Saldo}");
System.Console.WriteLine($"Saldo conta poupanca antes do saque: R${cp.Saldo}");

System.Console.WriteLine();

System.Console.WriteLine($"Saldo Conta corrente apos do saque: R${cc.Saldo}");
System.Console.WriteLine($"Saldo conta poupanca apos do saque: R${cp.Saldo}");