int senha = 1234;

Console.WriteLine($"Informe sua senha");
int senhaD = int.Parse (Console.ReadLine());

if (senhaD == senha ) {
    Console.WriteLine($"Acesso Permitido");
}

else  {
    Console.WriteLine($"Acesso Negado");
}
