using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string matricula;

        public Aluno (string nm, int id , string ma){
            nome = nm;
            idade = id;
            matricula = ma;
        }

        public void ExibirDados()
        {
             Console.WriteLine(@$"
        Nome: {nome}
        Idade: {idade}
        Matricula: {matricula}");
        }
    }
    }
