using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    public class veiculos
    {
        public string marca;
        public string modelo;
        public string cor;
        public float potencia;
        public int qtdPortas;

        public void Acelerar(string nome)
        {
            Console.WriteLine($"O {modelo} esta acelerando!");
            
        }

        public void Ligar(string nome )
        {
            Console.WriteLine($"O veiculo {nome} foi ligado!");
            
        } 

        public void Desligar(string nome)
        {
            Console.WriteLine($"O veiculo {nome} foi desligado!");
            
        }

        public void Freiar(string nome)
        {
            Console.WriteLine($"O {modelo} esta freiando!");
        }
    }
}