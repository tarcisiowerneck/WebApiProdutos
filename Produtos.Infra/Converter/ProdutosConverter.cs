using System.Collections.Generic;
using System.Linq;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Domain.Models;

namespace WebApiProdutos.Infra.Converter
{
    public static class ProdutosConverter
    {
        public static CreateProdutosModel ConvertToProdutosModel(this CreateProdutosTipoModel produtoModel, TipoProdutos tipoProdutos) => new CreateProdutosModel() { Descricao = produtoModel.Descricao, ValorUnitario = produtoModel.ValorUnitario, DataCadastro = produtoModel.DataCadastro, Quantidade = produtoModel.Quantidade, Tipo = tipoProdutos };

        public static Produtos ConvertToProdutosEntity(this CreateProdutosModel produtoModel) => new Produtos(0, produtoModel.Descricao, produtoModel.ValorUnitario, produtoModel.DataCadastro, produtoModel.Quantidade, produtoModel.Tipo);

        public static Produtos ConvertToProdutosEntity(this UpdateProdutosModel produtoModel) => new Produtos(produtoModel.Id, produtoModel.Descricao, produtoModel.ValorUnitario, produtoModel.DataCadastro, produtoModel.Quantidade, produtoModel.Tipo);

        public static IEnumerable<ProdutosModel> ConvertToProdutos(this IList<Produtos> produto) => new List<ProdutosModel>(produto.Select(p => new ProdutosModel(p.Id, p.Descricao.ToString(), p.ValorUnitario, p.DataCadastro, p.Quantidade, p.Tipo)));

        public static ProdutosModel ConvertToProdutos(this Produtos produto) => new ProdutosModel(produto.Id, produto.Descricao.ToString(), produto.ValorUnitario, produto.DataCadastro, produto.Quantidade, produto.Tipo);
    }
}
