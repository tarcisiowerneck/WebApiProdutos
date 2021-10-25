using System;
using WebApiProdutos.Domain.Enums;

namespace WebApiProdutos.Domain.Models
{
    public class UpdateProdutosModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal Quantidade { get; set; }

        public TipoProdutos Tipo { get; set; }
    }
}
