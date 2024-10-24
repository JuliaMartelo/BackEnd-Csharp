//Criar um cabeçalho de  boas vindas

using System.Data;

Console.WriteLine(@"
                     --------------------------------------
                     |       Programa de Cadastros        |              
                     --------------------------------------
                     |Por favor digitar seus dados abaixo |
                     --------------------------------------

");

Console.WriteLine($"Olá, digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($" Ola {nome}, Agora digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;

//mostrar esses dados cadastrados

Console.WriteLine($"Agora informe sua data de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine ()!);
int anoAtual = DateTime.Now.Year;

Console.WriteLine(anoAtual - anoNascimento);
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Agora digite seu email: ");
string email = Console.ReadLine()!;

Console.WriteLine($"Agora digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Agora informe seu CPF: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Agora informe seu endereço: ");
string endereço = Console.ReadLine()!;

Console.WriteLine($"Agora digite sua estado civil: ");
string EstadoCivil = Console.ReadLine()!;



Console.WriteLine(@$"OBrigado: 
{nome} 
{sobrenome} 
{anoNascimento} 
{email} 
{telefone} 
{cpf} 
{endereço} 
{EstadoCivil} 
{idade}");


//nome
//data de nascimento 
//emailm
//telefone
//cpf
//endereço
//idade - calcular baseado na data de nascimento
//estado civil


