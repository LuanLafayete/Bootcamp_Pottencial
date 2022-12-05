using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorar.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador +1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}

/*Aqui foi desenvolvido um Array Genérico do tipo T cujo o objetivo é adicionar sempre um elemento
no método AdicionarElemento. 
Primeiramente o método faz um teste condicional para ver se ele ultrapassa a quantidade permitida no Array
depois ele insere o conteúdo e adiciona no contador. */