using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Bradescuss");
Console.WriteLine("");

ContaCorrente contaEmilly = new ContaCorrente();
ContaCorrente contaClara = new ContaCorrente();

contaEmilly.Titular = "Emilly";
contaEmilly.Depositar ( 1000000f);

contaClara.Titular = "Clara";
contaEmilly.Depositar (1000000);

Console.WriteLine($"Conta da {contaEmilly} tem R$ {contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara} tem R$ {contaClara.Saldo}");

contaClara.Sacar (250f);

Console.WriteLine($"Conta da {contaEmilly} tem R$ {contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara} tem R$ {contaClara.Saldo}");
Console.WriteLine($"");


