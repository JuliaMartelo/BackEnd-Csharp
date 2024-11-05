string[] frutas = {"Melancia", "Carambola", "Maracuja", "Morango", "Limao", "Jabuticaba", 
"Abacate","Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pessego","Banana"}

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

foreach (string f in frutas)
{
    Console.WriteLine($"{f},");
    
}

Console.WriteLine();

