using System;
using ClassLibrary1;

namespace _20200908
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(1, 2));

            Console.WriteLine(calculadora.Restar(1, 2));


            Console.WriteLine(calculadora.Dividir(2, 1));


            Console.WriteLine(calculadora.Multiplicar(2, 2));



        }
    }
}
