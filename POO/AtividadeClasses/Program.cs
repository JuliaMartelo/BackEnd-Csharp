using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using AtividadeClasses;
// Criacao do objeto carro
veiculos carro = new veiculos();

carro.Ligar(carro.modelo);
carro.Acelerar(carro.modelo);

Console.WriteLine($"Informe a marca do seu carro: ");
carro.marca = Console.ReadLine();

Console.WriteLine($"Informe o modelo do seu carro: ");
carro.modelo = Console.ReadLine ();

Console.WriteLine ($"Informe a cor do {carro.modelo}: ");
carro.cor = Console.ReadLine ();

Console.WriteLine($"Qual a potencia do {carro.modelo}: ");
carro.potencia = float.Parse(Console.ReadLine());

Console.WriteLine($"Quantas portas tem o {carro.modelo}: ");
carro.qtdPortas = int.Parse(Console.ReadLine());

carro.Freiar(carro.modelo);

carro.Desligar(carro.modelo);