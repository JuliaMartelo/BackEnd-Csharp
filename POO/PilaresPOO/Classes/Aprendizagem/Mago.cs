using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        

        public override void Atacar(){
            Console.WriteLine($"O Mago está lançando feitiço!🪄");
            
        }
    }
}