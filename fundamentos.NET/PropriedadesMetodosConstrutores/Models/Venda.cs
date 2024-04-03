using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
        }
        
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}