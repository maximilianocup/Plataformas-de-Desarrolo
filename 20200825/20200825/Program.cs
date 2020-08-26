using System;

namespace _20200825
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;
            string numero = "";
            Console.WriteLine("Ingrese un numero");
            //numero = Console.ReadLine();
            while (numero != "3" && intentos <=3){
                //Console.Write("Ingrese un numero");
                numero = Console.ReadLine();
                int.Parse(numero);
                
                if (numero == "3")
                {
                    Console.WriteLine("Felicitaciones");
                }
                else
                {
                    Console.WriteLine("siga intentando");
                    Console.WriteLine("intento numero: " + intentos++);
                }
                

            }

            





        }
    }
}
