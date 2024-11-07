
using System;
using RPG.Classes;

Personagem ps = new Personagem();

Console.WriteLine($"Bem-Vindo ao jogo RPG!");

Console.WriteLine($"Informe o nome do seu personagem: ");
ps.nome = Console.ReadLine();

Console.WriteLine($"Informe a idade do seu personagem: ");
ps.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o nome da armadura do seu personagem: ");
ps.armadura = Console.ReadLine();

Console.WriteLine($"Informe a IA do seu personagem");
ps.IA = Console.ReadLine();

Console.WriteLine($"");


Console.WriteLine($"Personagem:{ps.nome}");
Console.WriteLine($"Idade:{ps.idade}");
Console.WriteLine($"Armadura:{ps.armadura}");
Console.WriteLine($"IA:{ps.IA}");

Console.WriteLine($"");


ps.atacar();
ps.restaurarArmadura();
ps.defender();



