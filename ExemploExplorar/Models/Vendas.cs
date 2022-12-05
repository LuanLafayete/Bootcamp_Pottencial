using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorar.Models
{
    public class Vendas
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] //Adiciona o nome original dos atributos que podem ser lidos no arquivo Json
        public string Produto { get; set; } //Faz as alterações do nome das propriedades seguindo a convenção do C#

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}