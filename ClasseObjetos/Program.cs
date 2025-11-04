using ClasseObjetos;



/*Console.Clear();

Garrafa g1 = new Garrafa();

Console.WriteLine($"Crie sua garrafa!");
Console.WriteLine();
Console.WriteLine($"Digite o nome do usuario:");
g1.nomeUsuario = Console.ReadLine();

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
Console.WriteLine();*/

  AgenciaBancaria a1 = new AgenciaBancaria();

        Console.WriteLine("Acesse sua conta bancária!");
        Console.WriteLine();
        Console.Write("Digite o nome do titular: ");
        a1.titular = Console.ReadLine();

        Console.Write("Digite o saldo inicial: R$");
        a1.saldo = double.Parse(Console.ReadLine());

        int opcao;
        do
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{a1.titular}, o que deseja fazer?");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opcao == 1)
            {
                Console.Write("Qual valor deseja depositar? R$");
                double valor = double.Parse(Console.ReadLine());
                a1.Depositar(valor);
            }
            else if (opcao == 2)
            {
                Console.Write("Qual valor deseja sacar? R$");
                double valor = double.Parse(Console.ReadLine());
                a1.Sacar(valor);
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Saindo... Obrigado por usar nosso banco!");
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
            }

        } while (opcao != 0);
    


/*Pessoa joao = new Pessoa();

joao.nome = "Joao Silva";

Console.WriteLine($"{joao.nome} tem {joao.idade} anos");

int novaIdade = joao.envelhecer (17);

Console.WriteLine($"{joao.nome} tem {novaIdade} anos");


joao.envelhecer(-50);
Console.WriteLine($"{joao.nome} tem {joao.idade} anos");*/