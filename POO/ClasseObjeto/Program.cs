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
 gato.cor = "preto";
 gato.idade = 8;

 Console.WriteLine($"Nome do {gato.nome}: {gato.nome}");
 Console.WriteLine($"Raca do {gato.nome}: {gato.raca}");
 Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
 Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");

 Console.WriteLine($"");

 Animal gata = new Animal();

gata.nome = "Emy";
gata.raca = "vira-lata";
gata.cor = "branca";
gata.idade = 17;

Console.WriteLine($"Nome do {gata.nome}: {gata.nome}");
 Console.WriteLine($"Raca do {gata.nome}: {gata.raca}");
 Console.WriteLine($"Cor do {gata.nome}: {gata.cor}");
 Console.WriteLine($"Idade do {gata.nome}: {gata.idade}");

Console.WriteLine($"");


cachorro.FazerBarulho("AU AU");
Console.WriteLine($"Idade da {cachorro.nome} eh {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade da {cachorro.nome} eh {cachorro.idade}");

Console.WriteLine($"");


gato.FazerBarulho("MIAU MIAU");
Console.WriteLine($"Idade do {gato.nome} eh {gato.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade da {gato.nome} eh {gato.idade}");

Console.WriteLine($"");


gata.FazerBarulho("MIAU MIAU");
Console.WriteLine($"Idade do {gata.nome} eh {gata.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade da {gata.nome} eh {gata.idade}");