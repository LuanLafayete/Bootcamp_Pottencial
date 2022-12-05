using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    /*
        Nessa aula foi aprendido a como usar o INTERFACE
        Deu para notar que a interface tem semelhança com CLASSE ABSTRATA.
        * Não podem ser instanciadas no Programa principal
        * Podem ser herdadas pelas classes filhas, porém uma INTERFACE usa o nome IMPLEMENTAÇÃO
    */
    public interface ICalculadora
    {
        /*
            Aqui nós temos métodos que não possuem corpo.
            Isso significa que eles são obrigatórios a serem implementados em suas classes filhas.
        */
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        
        /*  
            Já aqui foi usado uma interface que tem um corpo.
            Isso significa que ao desenvolver essa estrutura ela se torna opcional em suas implementações filhas, 
            pois ela usará essa forma de realizar seus métodos.
        */
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}