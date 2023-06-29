using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double investimento = 1000;

            int mes;

            for (mes=1; mes <= 12; mes++)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem R$" + investimento + " investidos");
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
