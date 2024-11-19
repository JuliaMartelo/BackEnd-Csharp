using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Personagem
    {
        // virtual significa que o metodo pode ser sobrescrito na classe filha/subclasse
        public abstract void Atacar();
       
    }
}

//criar 3 classes
//mago, guerreiro e arqueiro