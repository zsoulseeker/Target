using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pergunta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("Resultado: " + SOMA);

            Console.ReadKey();
        }
    }
}
