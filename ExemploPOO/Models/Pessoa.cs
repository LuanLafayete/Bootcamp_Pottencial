using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        /*
            Aqui na classe Pessoa foi contruído um construtor que obriga colocar o nome.
            O problema é que ao adicionar o Contrutro na classe Pai,
            as classes filhas não sabem como reagir a essas mudanças.
            Dessa forma é necessário adicionar o mesmo construtor nas classes filhas.
        */
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        //Ao digitar VIRTUAL no meu método, estou sinalizando que o mesmo pode ser usado nas classes filhas.
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}