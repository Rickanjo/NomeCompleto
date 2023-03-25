// Nome Completo ]

String Nome;
String Sobrenome;

Console.Write("Digite seu Nome:");
Nome = Console.ReadLine()!;

Console.Write("Digite seu Sobrenome: ");
Sobrenome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}");

Console.WriteLine($"Nome Catálogo: {Sobrenome.ToUpper()}, {Nome}");
