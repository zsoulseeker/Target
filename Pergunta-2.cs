using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pergunta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0 || numero == 1)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci");
                return;
            }

            int a = 0;
            int b = 1;
            int c = a + b;
            bool pertence = false;

            while (c <= numero)
            {
                if (c == numero)
                {
                    pertence = true;
                    break;
                }
                a = b;
                b = c;
                c = a + b;
            }

            if (pertence)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }
    }
}
