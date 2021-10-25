using System;
using System.ComponentModel.DataAnnotations;
using WebApiProdutos.Domain.DTO;
using WebApiProdutos.Domain.Enums;

namespace WebApiProdutos.Domain.Entities
{
    public class Produtos : BaseEntity<int>
    {
        public Produtos(int id, string descricao, decimal valorUnitario, DateTime dataCadastro, decimal quantidade, TipoProdutos tipo) : base(id)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            DataCadastro = dataCadastro;
            Quantidade = quantidade;
            Tipo = tipo;
        }

        protected Produtos() { }

        public Descricao Descricao { get; }

        public decimal ValorUnitario { get; }

        public DateTime DataCadastro { get; }

        public decimal Quantidade { get; }

        public Tipo Tipo { get; }
    }
}
