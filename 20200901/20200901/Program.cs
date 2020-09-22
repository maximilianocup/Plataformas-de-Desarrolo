using System;

namespace _20200901
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(10);
            
            int intentos = 1;
            int numero = 0;

            while (numero != secreto && intentos <= 3)
            {
                //Console.Write("Ingrese un numero");
                
                
                numero = int.Parse(Console.ReadLine());



                if (secreto == numero)
                {
                    Console.WriteLine("Felicitaciones");
                }
                else
                {
                    Console.WriteLine("siga intentando " + secreto);
                    Console.WriteLine("intento numero: " + intentos++);
                }


            }
        }
    }
}
