using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pergunta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double OT = 19849.53;
            double VT = SP + RJ + MG + ES + OT;

            double SPP = SP / VT * 100;
            Console.WriteLine("Porcentagem de SP: " + SPP.ToString("F2") + "%");

            double RJJ = RJ / VT * 100;
            Console.WriteLine("Porcentagem de RJ: " + RJJ.ToString("F2") + "%");

            double MGG = MG / VT * 100;
            Console.WriteLine("Porcentagem de MG: " + MGG.ToString("F2") + "%");

            double ESS = ES / VT * 100;
            Console.WriteLine("Porcentagem de ES: " + ESS.ToString("F2") + "%");

            double OTT = OT / VT * 100;
            Console.WriteLine("Porcentagem de OUTROS: " + OTT.ToString("F2") + "%");
        }
    }
}
