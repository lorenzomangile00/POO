using System.ComponentModel.Design.Serialization;
using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();
int opcao;

do{
System.Console.WriteLine($"Menu de opcao:");
System.Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatorios
6) Listar Contratos
0) Sair
Escolha a opcao:
");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
    {
        case 1:
        System.Console.WriteLine($"Cadastrar Fatura");
        break;
        case 2:
        System.Console.WriteLine($"Cadastrar Relatorio");
        break;
        case 3:
        System.Console.WriteLine($"Cadastrar Contrato");
        break;
        case 4:
        System.Console.WriteLine($"Listar Faturas");
        break;
        case 5: 
        System.Console.WriteLine($"Listar Relatorios");
        break;
        case 6:
        System.Console.WriteLine($"Listar Contratos");
        break;
        case 0:
        System.Console.WriteLine($"Sair");
        break;
    }

System.Console.WriteLine($"Digite <Enter> para continuar ...");
Console.ReadLine();

}while (opcao != 0);

void CadastrarFatura()
{
    System.Console.WriteLine($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    System.Console.WriteLine($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Quantos dias a fatura esta em atraso?");
    int diasAtraso = int.Parse(Console.ReadLine());

    Fatura f = new Fatura(dev, cred, valor, diasAtraso);

    documentos.Add(f);
    System.Console.WriteLine($"Fatura cadastrada com sucesso.");

}

void CadastrarContrato()
{
    System.Console.WriteLine($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome da contratada: ");
    string contratada = Console.ReadLine();
    System.Console.WriteLine($"Digite as clausulas do relatorio: ");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtClausulas);

    documentos.Add(c);
    System.Console.WriteLine($"Contrato cadastrado com sucesso.");
}

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite o nome do responsavel: ");
    string responsavel = Console.ReadLine();
    System.Console.WriteLine($"Escreva o seu relatorio: ");
    string txtRelatorio = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtRelatorio);
    documentos.Add(r);
    System.Console.WriteLine($"Relatorio cadastrado com sucesso");
}

void ListarFaturas()
{
    System.Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if(item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContrato()
{
    System.Console.WriteLine($"Listando os contratos: ");
    foreach (var item in documentos)
    {
        if(item is Contrato)
        {
            item.Imprimir();
        }
    }
}
void ListarRelatorio()
{
    System.Console.WriteLine($"Listando os relatorioss: ");
    foreach (var item in documentos)
    {
        if(item is Relatorio)
        {
            item.Imprimir();
        }
    }
}
/*Fatura fatLorenzo = new Fatura("Lorenzo", "Figueira", 50, 1);

fatLorenzo.Imprimir();
System.Console.WriteLine();

Relatorio relLorenzo = new Relatorio("Lorenzo", "Fez uma transferencia dia 18/11" );
relLorenzo.Imprimir();
System.Console.WriteLine();

Contrato conLorenzo = new Contrato("Lorenzo", "Itau", "Respeitar as politicas de privacidade");
conLorenzo.Imprimir();
System.Console.WriteLine();*/