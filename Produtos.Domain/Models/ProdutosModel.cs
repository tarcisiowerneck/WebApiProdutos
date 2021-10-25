using System;

namespace WebApiProdutos.Domain.Models
{
    public class ProdutosModel
    {
        public ProdutosModel(int id, string descricao, decimal valorUnitario, DateTime dataCadastro, decimal quantidade, int tipo)
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            DataCadastro = dataCadastro;
            Quantidade = quantidade;
            Tipo = tipo;
        }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal Quantidade { get; set; }

        public int Tipo { get; set; }
    }
}
