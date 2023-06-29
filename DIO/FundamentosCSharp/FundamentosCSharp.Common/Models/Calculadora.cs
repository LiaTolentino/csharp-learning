using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"O valor de {x} somado a {y} " + 
            $"é igual a {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"O valor de {x} subtraído de {y} "+
            $"é igual a {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"O valor de {x} multiplicado por {y} " +
            $"é igual a {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"O valor de {x} dividido por {y} " +
            $"é igual a {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"O valor de {x} elevado a {y} " +
            $"é igual a {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno do angulo {angulo}º = {seno:F4}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno do angulo {angulo}º = {coseno:F4}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente do angulo {angulo}º = {tangente:F4}");
        }

        public void RaizQuadada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é igual a {raiz}");
        }
    }
}