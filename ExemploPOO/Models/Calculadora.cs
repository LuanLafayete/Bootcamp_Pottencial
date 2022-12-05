using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;
{
    
}

namespace ExemploPOO.Models
{
    /*
        Essa classe usa a IMPLEMENTAÇÃO da interface ICalculadora.
        Lembrando que para não dar erro, é necessário realizar todas as implementeções que estão na interface 
        ICalculadora. Caso o mesmo não seja feito, fica sujeito a erro.
    */
    public class Calculadora : ICalculadora //Aqui não HERDA, ela IMPLEMENTA
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}