 //Importando as classes dentro da pasta Classes
 using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using ClasseObjeto.Classes;

 //Cria o objeto/variavel animal
 Animal cachorro = new Animal();

 cachorro.nome = "Cristal";
 cachorro.raca = "Vira-Lata";
 cachorro.cor = "marrom";
 cachorro.idade = 8;

 Console.WriteLine($"Nome da {cachorro.nome}: {cachorro.nome}");
 Console.WriteLine($"Raca da {cachorro.nome}: {cachorro.raca}");
 Console.WriteLine($"Cor da {cachorro.nome}: {cachorro.cor}");
 Console.WriteLine($"Idade da {cachorro.nome}: {cachorro.idade}");

 Console.WriteLine($"");
 

 Animal gato = new Animal();

 gato.nome = "Arthur";
 gato.raca = "vira-lata";
 gato.cor = "cor";
 gato.idade = 8;

 Console.WriteLine($"Nome do {gato.nome}: {gato.nome}");
 Console.WriteLine($"Raca do {gato.nome}: {gato.raca}");
 Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
 Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");