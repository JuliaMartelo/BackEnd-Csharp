using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public string? cor { get; set; }
        public float potencia;
        public int qtdPortas;

        public void Ligar()
        {
            Console.WriteLine($"O Veículo Ligou");

        }
        public void Desligar()
        {
            Console.WriteLine($"O Veículo Desligou");

        }

        public void Buzinar()
        {
            Console.WriteLine($"O Veículo Buzinou");

        }


    }
}