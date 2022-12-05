using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    /*
        Aqui foi criado uma classe abstrata.
        Uma classe abstrata não pode ser instanciada no C#. Ela é somente usada para ser herdada por outras
        classes os seus atributos e métodos.
    */
    public abstract class Conta
    {
        /*
            Aqui foi usado um atributo Saldo do tipo Protected.
            Isso significa que o atributo não pode sofrer nenhum tipo de mudança externa.
            Somente as classes que herdam dessa classe aqui que pode fazer alteração no atributo saldo.
        */
        protected decimal saldo;

        /*
            Aqui foi usado um método abstrato sem implementação.
            Sabendo que estamos desenvolvendo uma classe abstrata (onde é somente usando para ser herdado)
            o método abstrato segue a mesma ideia. Você pode subscrever/override o método nas classses filhas,
            porém não pode esquecer qua ao herder uma classe abstrata é necessário subscrever/override os métodos 
            abstratos.
        */
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo ()
        {
            Console.WriteLine($"O seu saldo é {saldo}");
        }
    }
}