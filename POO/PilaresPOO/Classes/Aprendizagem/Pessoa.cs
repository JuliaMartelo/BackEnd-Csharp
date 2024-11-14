using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        //Atributos - caracteristicas
        public string? nome;
        public int? idade;
        public string? CPF;
        public float peso {get; set;}
        public float altura{get; set;}
       
        //Metodos - acoes
        public void envelhecer(){
            idade++;
        }
        public void engordar (float _kg){
            peso = peso + _kg;
        }
        public void emagrecer (float _kg){
            peso = peso - _kg;
        }

        }
       
    }
