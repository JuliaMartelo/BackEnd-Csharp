 Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");
 
 
 
 
 int totalSim = 0;
        int totalNao = 0;
        int mulheresSim = 0;
        int totalHomens = 0;
        int homensNao = 0;


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Entrevistando a pessoa {i + 1}:");

            Console.Write("Digite o sexo da pessoa (M para masculino, F para feminino): ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Gostou do produto? (S para sim, N para não): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                totalSim++;
                if (sexo == "F")
                {
                    mulheresSim++;
                }
            }
            else if (resposta == "N")
            {
                totalNao++;
                if (sexo == "M")
                {
                    homensNao++;
                }
            }

            if (sexo == "M")
            {
                totalHomens++;
            }
        }

        float percentualHomensNao = totalHomens > 0 ? (float)homensNao / totalHomens * 100 : 0;

        Console.WriteLine("\nResultados:");

        Console.WriteLine($"Número de pessoas que responderam SIM: {totalSim}");

        Console.WriteLine($"Número de pessoas que responderam NÃO: {totalNao}");

        Console.WriteLine($"Número de mulheres que responderam SIM: {mulheresSim}");
        
        Console.WriteLine($"Porcentagem de homens que responderam NÃO: {percentualHomensNao}%");

