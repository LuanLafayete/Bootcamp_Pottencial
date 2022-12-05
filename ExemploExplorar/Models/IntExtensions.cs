using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorar.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}

/*Aqui foi criado uma extensão de método e o mesmo pode ser chamado no programa principal desde de que 
a variável seja do mesmo tipo do método. 
No caso aqui, foi criado um método para trabalhar apenas com números inteiros (INT).
*/