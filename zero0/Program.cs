using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zero0
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaraão de variaveis
            
            float result, n1, n2;

            //entrada
            Console.WriteLine("Digite um valor:");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor:");
            n2 = float.Parse(Console.ReadLine());

            //processamento
            result = n1 / n2;

            while (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Impossivel dividir por zero, tente de novo");

                Console.WriteLine("Digite um valor:");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite um valor:");
                n2 = float.Parse(Console.ReadLine());
            }


            //saida
            Console.WriteLine("o valor é:" + result.ToString("F5"));
            Console.ReadKey();
        }
    }
}
