using System.Security.Cryptography;
using ExerciciosMetodoConstrutor;
/*
Carro c1 = new Carro("Audi", "R8", 2015);

System.Console.WriteLine(@$"Seu carro:");
System.Console.WriteLine($"Digite a marca:");  
c1.Marca = Console.ReadLine();
System.Console.WriteLine($"Digite o modelo:");
c1.Modelo = Console.ReadLine();
System.Console.WriteLine($"Digite o ano:");
c1.Ano = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Seu carro:
                            Marca:{c1.Marca}
                            Modelo:{c1.Modelo}
                            Ano:{c1.Ano}
");

Aluno a1 = new Aluno("Lorenzo", 10);



System.Console.WriteLine(@$"-------Aluno------
                                        Nome:{a1.Nome}
                                        Nota:{a1.Nota}
                                       ");*/
/*
Produto p1 = new Produto("Escova de dente", 13.54, 10);

System.Console.WriteLine(@$"Produto:");
System.Console.WriteLine($"Digite o nome:");  
p1.Nome = Console.ReadLine();
System.Console.WriteLine($"Digite o preco:");
p1.Preco = double.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite o estoque:");
p1.Estoque = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Seu carro:
                            Nome:{p1.Nome}
                            Preco:{p1.Preco}
                            Estoque:{p1.Estoque}
");*/

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Lucas";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Samuel";
a2.Media();


