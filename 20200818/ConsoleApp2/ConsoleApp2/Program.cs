using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            Console.WriteLine("ingrese 10 numeros, cuando la suma llegue a 50 se detendra");
            
            
            
            for ( int posicion = 0; posicion < 10; posicion++)
            {
                Console.WriteLine("ingrese el numero");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (sum > 50)
                {
                    break;
                }

                Console.WriteLine("el total sumado es: " + sum);

            }
        }
    }
}
