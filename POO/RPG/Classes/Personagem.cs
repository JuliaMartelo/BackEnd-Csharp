using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Personagem
    {
        public string? nome;
        public int? idade;
        public string? armadura;
        public  string? IA;

        public void atacar()
        {
            Console.WriteLine($"O personagem atacou!");
        }
        public void restaurarArmadura(){
            Console.WriteLine($"O personagem restaurou a armadura!");
        }
        public void defender (){
            Console.WriteLine($"O personagem defendeu!");
        }
    }
}