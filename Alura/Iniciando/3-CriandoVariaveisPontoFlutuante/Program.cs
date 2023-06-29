using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto - Variáveis Ponto Flutuante");

            double salario;
            double inss;
            salario = 3000.10;
            inss = 0.89;

            Console.WriteLine(salario * inss);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
