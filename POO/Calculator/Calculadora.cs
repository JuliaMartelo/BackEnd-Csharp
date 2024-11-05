using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;

        public float Somar()
        {
           float resultado = numero1 + numero2;
           Console.WriteLine($"O resultado da sua soma eh: {resultado} ");
           
        }

        public float Subtrair ()
        {
           float resultado = numero1 - numero2;
           Console.WriteLine($"O resultado da sua subtracao eh: {resultado}");
        }

        public Multiplicar ()
        {
           float resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da sua multiplicacao eh: {resultado} ");
        }

        public Dividir ()
        {
            float resultado = numero1 / numero2;
            Console.WriteLine($"O resultado da sua divisao  eh: {resultado}");
        }
    }
}