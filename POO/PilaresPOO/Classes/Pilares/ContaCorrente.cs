using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente: Conta
    {
        public int limiteSaque;
        public float juros;
        public float Limites {get; set;}

        public override bool Depositar(float valor)
        {
            if (valor > 0){
                Saldo = Saldo + valor;  
                return true;
            }else{
                return false;
            }
            throw new NotImplementedException();
        }
        public  override float Sacar(float valor){
            if (valor >= Saldo){
                Saldo = Saldo - valor;
                return valor;
            }else{
                return valor;
            }
        //    Saldo = Saldo - valor;

           return valor;
        }  
        public  bool Transferir(float valor,  Conta ContaDestino)
        777
        {
          return false;  // Simulando que deu erro
        }
        
    }
}