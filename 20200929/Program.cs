using System;
using System.Collections.Generic;
using System.Linq;

namespace _20200929
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaDeNumeros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var numerosPar = ListaDeNumeros.Where(n => n % 2 == 0).OrderByDescending(n => n);
            foreach (var n in numerosPar)
            {
                Console.WriteLine(n);
            }
        }

        
    }
}
