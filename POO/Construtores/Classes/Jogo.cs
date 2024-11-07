using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string ?nome;
        public int? lancamento;
        public string? genero;
        public float? preco;

        public Jogo(string nm, int lm, string gn, float pc){
            nome = nm;
            lancamento = lm;
            genero = gn;
            preco = pc;
        }

        public void ExibirDados(){
         Console.WriteLine(@$"
        Nome: {nome}
        Lancamento: {lancamento}
        Genero: {genero}
        Preco: {preco}");
        }
    }
}