using PrimeiraClasse;

// string nome = "Lorenzo Mangile";

// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Ola usuario";

// cumprimento.SaudarUsuario();
// cumprimento.SaudarComNome("Lorenzo Mangile");

/*Carro c1 = new Carro();
c1.marca = "Lamborghini";
c1.modelo = "Urus";
c1.cor = "Preto";
c1.qtdPortas = 4;
c1.qtdRodas = 4;
c1.Ligar();
c1.Acelerar();
c1.Frear();
c1.Desligar();

Carro c2 = new Carro();
c2.marca = "Chevrolet";
c2.modelo = "Camaro";
c2.cor = "Amarelo";
c2.qtdPortas = 2;
c2.qtdRodas = 4;

Console.WriteLine($"Ligando o {c2.modelo}");
Console.WriteLine($"Acelerando o {c2.modelo}");
Console.WriteLine($"Freando o {c2.modelo}");
Console.WriteLine($"Desligando o {c2.modelo}");

Console.WriteLine();
Console.WriteLine("Caracteristicas");
Console.WriteLine();

Console.WriteLine($"-----{c1.marca}-----");
Console.WriteLine($"Carro: {c1.marca}");
Console.WriteLine($"Modelo: {c1.modelo}");
Console.WriteLine($"Cor: {c1.cor}");
Console.WriteLine($"Quantidade de portas: {c1.qtdPortas}");
Console.WriteLine();
Console.WriteLine("---");
Console.WriteLine();

Console.WriteLine($"-----{c2.marca}-----");
Console.WriteLine($"Carro: {c2.marca}");
Console.WriteLine($"Modelo: {c2.modelo}");
Console.WriteLine($"Cor: {c2.cor}");
Console.WriteLine($"Quantidade de portas: {c2.qtdPortas}");
Console.WriteLine();

Moto m1 = new Moto();
m1.marca = "Royal Enfield";
m1.modelo = "Classic 350";
m1.cor = "Preto";
m1.qtdRodas = 2;
m1.Ligar();
m1.Acelerar();
m1.Frear();
m1.Desligar();*/

/*Garrafa g1 = new Garrafa();
g1.marca = "Growth";
g1.capacidade = "500ml";
g1.material = "Plastico";
g1.cor = "Azul";
g1.Abrir();
g1.Fechar();
g1.Encher();
g1.Esvaziar();*/

Console.Clear();

Console.WriteLine($"Crie sua garrafa!");

Garrafa g1 = new Garrafa();

Console.WriteLine($"Qual a capacidade dessa garrafa?");
g1.capacidade = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Qual a marca dessa garrafa?");
g1.marca = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Qual a cor dessa garrafa?");
g1.cor = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Garrafa");
Console.WriteLine($"Capacidade: {g1.capacidade} L");
Console.WriteLine($"Tipo: {g1.marca}");
Console.WriteLine($"Cor: {g1.cor}");
Console.WriteLine();
