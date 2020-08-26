using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tipee un numero del 0 al 15");
            int numero;
            string mensaje;
            string valor = Console.ReadLine();
            numero = int.Parse(valor);

            if (numero < 1 || numero == 6 )
            {
                mensaje = "pusiste un 0 o un 6";
                
            }
            else if (numero == 2)
            {
                mensaje = "pusiste el numero 2";
                
            }
            else if (numero > 3 && numero < 8)
            {
                mensaje = "el numero esta entre el 3 y el 8";

            }
            else if (numero > 10 && numero < 15)
            {
                mensaje = "pusiste un numero de 2 digitos";


            }
            else 
            {
                mensaje = "el numero que puso no es valido";
            }
            
            
             Console.WriteLine(mensaje);
            

            

        }
    }
}
