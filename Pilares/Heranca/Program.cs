using Heranca;
/*

ANIMAL


Animal a1 = new Animal();
Cachorro c1 = new Cachorro();
Gato g1 = new Gato();

 Console.WriteLine("Som do Animal:");
 a1.FazerSom();

Console.WriteLine("\nSom do Cachorro:");
 c1.FazerSom();

 Console.WriteLine("\nSom do Gato:");
 g1.FazerSom();

 -----------------------------
FUNCIONARIO

 Funcionario f1 = new Funcionario();
f1.Nome = "Mangile";
f1.SalarioBase = 200000;

Gerente g1 = new Gerente();
g1.Nome = "G.A";
g1.SalarioBase = 3000;
g1.Bonus = 1500;

Console.WriteLine($"Funcionário: {f1.Nome} | Salário: R${f1.CalcularSalario()}");
Console.WriteLine($"Gerente: {g1.Nome} | Salário: R${g1.CalcularSalario()}");

-------------------------------
CARRO & MOTO

Carro carro = new Carro();
carro.Marca = "Toyota";
carro.Modelo = "Corolla";
carro.NumeroPortas = 4;

Moto moto = new Moto();
moto.Marca = "Honda";
moto.Modelo = "CG 160";
moto.Capacete = "Fechado";

carro.MostrarInfo();
 moto.MostrarInfo();

 ---------------------------
 ALUNO & PROFESSOR
 

 Aluno aluno = new Aluno()
 {
     Nome = "Mangile",
     Idade = 17,
     Curso = "Desenvolvimento de Sistemas"
 };

 Professor professor = new Professor()
 {
     Nome = "Alexia",
     Idade = 23,
     Disciplina = "DEV"
 };

 aluno.MostrarInfo();
 professor.MostrarInfo();

 -------------------------------------
 CONTA BANCARIA
 */

 ContaPoupanca cp = new ContaPoupanca();

        cp.Numero = 1234;
        cp.Saldo = 0;

        Console.WriteLine($"Conta poupança: {cp.Numero}");
        Console.WriteLine($"Saldo inicial: R${cp.Saldo}");
        Console.WriteLine("----------------------------------");

        cp.Depositar(1000);

        Console.WriteLine($"Saldo antes do rendimento: R${cp.Saldo}");

        cp.CalcularRendimento();

        Console.WriteLine($"Saldo apos o rendimento: R${cp.Saldo}");
        Console.WriteLine("----------------------------------");
