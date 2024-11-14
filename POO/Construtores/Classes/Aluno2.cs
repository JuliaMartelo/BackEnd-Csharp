using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;
        public int CPF;

        public Aluno2(string chuchu int abobrinha){
            Nome = chuchu;
            CPF = abobrinha;
        }

        public void exibirDados(){
            Console.WriteLine(@"
            nome: {Nome}
            cpf : {CPF}
            ");
            
        }
    }
}