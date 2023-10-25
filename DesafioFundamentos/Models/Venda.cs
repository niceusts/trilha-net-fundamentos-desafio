using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }

        public Venda(int id, string produto, decimal valor)
        {
            Id = id;
            Produto = produto;
            Valor = valor;
        }
    }
}