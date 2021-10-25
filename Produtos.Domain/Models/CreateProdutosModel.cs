using System;
using WebApiProdutos.Domain.Enums;

namespace WebApiProdutos.Domain.Models
{
    public class CreateProdutosModel
    {
        public string Descricao { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal Quantidade { get; set; }

        public TipoProdutos Tipo { get; set; }
    }
}
