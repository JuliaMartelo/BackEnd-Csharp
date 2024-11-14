using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome;
        public int CPF;

        public Aluno (string chuchu){
            nome = chuchu;
        }

        public void ExibirDados()
        {
             Console.WriteLine(@$"
        Nome: {nome}");
        }
    }
    }
