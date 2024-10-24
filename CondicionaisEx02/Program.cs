Console.WriteLine(@$"

    --------------------------------
    |       Placar do Jogo         |
    |  Time A = 2 gols             |
    |  Time B = 1 gol              |
    --------------------------------
");

int TimeA = 2;
int TimeB = 1;

if (TimeA > TimeB)
{
    Console.WriteLine($"Time A ganhou");
}

else if (TimeA == TimeB)
{
    Console.WriteLine($"Os times empataram");
}

else {
    Console.WriteLine($"O time B ganhou");
}