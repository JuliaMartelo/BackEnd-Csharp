using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public string raca;
        public string cor;
        public string nome;
        public int idade = 0;
    // Acoes
        public void FazerBarulho(string barulho)
        {
            Console.WriteLine($"Som do animal: {barulho = "Barulho Generico"}");
        }
        public void Envelhecer()
        {
            idade = idade +1;
        }
    }
}