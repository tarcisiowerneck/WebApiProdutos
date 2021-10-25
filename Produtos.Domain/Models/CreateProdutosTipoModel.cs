using System;

namespace WebApiProdutos.Domain.Models
{
    public class CreateProdutosTipoModel
    {
        public string Descricao { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal Quantidade { get; set; }

    }
}
