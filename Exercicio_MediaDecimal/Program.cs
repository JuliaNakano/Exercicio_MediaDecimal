using System;

namespace Exercicio_MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // receber uma quantidade de numeros 
            // depois receber o numero decimal que o usuario digitar 
            // calcular 
            //Soma...: 20,94
            //Média..: 5,24
            //Maior..: 9,47
            //Menor..: 0,37
           
            Console.Write("digite um número:... ");
            int qtnumeros = Convert.ToInt32(Console.ReadLine());

            double qt2 = 1.0; 
            while(qt2 <= qtnumeros )
            {
                if(qt2 < 10)
                {
                    Console.Write($"Número #0{qt2}: ");
                }
                else
                {
                    Console.Write($"Número #{qt2}: ");
                }
                Console.ReadLine();

                qt2++;   
            }

            
        }
    }
}
