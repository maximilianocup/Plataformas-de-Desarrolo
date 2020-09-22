using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _20200908
{
    class Calculadora
    {
       

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }


        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }


        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

    }
}
