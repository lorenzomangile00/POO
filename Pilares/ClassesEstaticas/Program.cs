
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();


// int escolha;


 
// Console.WriteLine($"Digite um numero: ");
// float a = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite outro numero: ");
// float b = float.Parse(Console.ReadLine());


// //uso da classe estatica de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// float s = CalculosMatematicos.Subtracao(a, b);
// System.Console.WriteLine($"Subtracao: {s}");

// float m = CalculosMatematicos.Multiplicacao(a, b);
// System.Console.WriteLine($"Multiplicacao: {m}");

// float d = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Dividir: {d}");

Console.WriteLine($"Digite um numero: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro numero: ");
 float b = float.Parse(Console.ReadLine());
Console.WriteLine();

if(a == b)
{
    Console.WriteLine($"Os dois numeros sao iguais.");
} else {
    System.Console.WriteLine($"O numero maior: {Math.Max(a, b)}");
    System.Console.WriteLine($"O numero menor: {Math.Min(a, b)}");
}

