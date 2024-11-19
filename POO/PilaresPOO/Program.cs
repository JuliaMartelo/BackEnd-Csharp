using System.Diagnostics;
using System.Globalization;
using PilaresPOO.Classes.Aprendizagem;
using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctJu = new ContaCorrente();
ctJu.Titular = "Julia Januario Martelo";
ctJu.BotaSaldoAi(1200f);

Console.WriteLine($"Titular da Conta: {ctJu.Titular}");
Console.WriteLine($"Saldo da Conta: {ctJu.DevolveSaldoAi()}");

float valorSacado = ctJu.Sacar(1200f);
Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Saldo da conta: {ctJu.DevolveSaldoAi()}");


