Console.Write("Digite o número de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());

decimal maca;

if (quantidade < 12)
{
    maca = 0.30m;
}
else
{
    maca = 0.25m;
}

decimal total = quantidade * maca;

Console.WriteLine($"O valor total da compra é: R$ {total}");


