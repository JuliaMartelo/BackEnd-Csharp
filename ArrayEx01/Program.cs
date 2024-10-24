int[] numeros = new int [6];
int numeroImpar;

for (int i = 0; i < numeros.Leight; i++)
{
    Console.WriteLine($"Digite um numero inteiro: "!);
    numeros[1] = int.Parse(Console.ReadLine()!);

    if(numeros [1] %2 ==0)
    {
        numeroPar++;
    }

    else{
        numeroImpar++;
    }
}

Console.WriteLine($"Quantidade de numeros pares: "!);
Console.WriteLine($"Quantidade de numeros impares: "!);
