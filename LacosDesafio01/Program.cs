// Faca um programa que rode 10 vezes e pergunte o sexo das pessoas e pergunte tambem se ela gosta de esportes.Informe:

// quantidade de pessoas 

Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");

//  criar um laco de 10 repeticoes 
// dentro do laco perguntar o sexo da pessoa
// se for homem contar na variavel homem, se for mulher contar na variavel mulher.


int qtdHomem = 0;
int qtdMulher = 0;
int qtdGostaesporte = 0;
int qtdNaoGostaesporte = 0;


Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine());

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Voce gosta de esportes? s/n");
    string gostaEsporte = Console.ReadLine();
    Console.WriteLine();

    if (sexo == "f")
    {
        qtdMulher++;
    }

    else
    {
        qtdHomem++;
    }

    if (gostaEsporte == "s")
    {
        qtdGostaesporte++;
    }

    else {
        qtdNaoGostaesporte++;
    }
}

float percentual = (100/ qtdDeEntrevistados) * qtdGostaesporte;

Console.WriteLine($"Quantidade de homem: {qtdHomem}");
Console.WriteLine($"Quantidade de mulher: {qtdMulher}");
Console.WriteLine($"Total de pessoas na mesa: {qtdMulher + qtdHomem}");
Console.WriteLine($"total de pessoas que gostam de esporte: {qtdGostaesporte}");
Console.WriteLine($"Total de pessoas que nao gostam de esporte: {qtdNaoGostaesporte}");
Console.WriteLine($"Tercentual de pessoas que gostam de esportes: {percentual}%");

