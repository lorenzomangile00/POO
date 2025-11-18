using Exercicio01;

System.Console.WriteLine($"=== Bem vindo ao programa Calculo de Geometria ===");
System.Console.WriteLine();

System.Console.WriteLine($"Vamos calcular o retangulo");

System.Console.Write($"Digite a largura do retangulo: ");
float l = float.Parse(Console.ReadLine());
System.Console.Write($"Digite a altura do retangulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Agora vamos calcular a area do circulo");
System.Console.Write($"Informe o raio do circulo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Fim do programa");