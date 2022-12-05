using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar (int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public void Subtrair (int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar (int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir (int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Resto (int x, int y)
        {
            Console.WriteLine($"O resto de {x} e {y} é = {x % y}");
        }

        public void Potencia (int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} elevado a {y} é = {pot}");
        }

        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º é = {Math.Round(seno, 4)}");
        }

        public void Coseno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º é = {Math.Round(coseno, 4)}");
        }

        public void Tangente (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º é = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada (double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é igual a {Math.Round(raiz, 2)}");
        }
    }
}