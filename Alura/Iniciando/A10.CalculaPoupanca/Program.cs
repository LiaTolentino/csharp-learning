using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10.CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double investimento = 1000;

            int mes = 1;

            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem R$" + investimento + " investidos");

                mes += 1;
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
