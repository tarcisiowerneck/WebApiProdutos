using System.Collections.Generic;
using System.Linq;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.Test
{
    public class MockupService : IServiceProdutos
    {
        private readonly List<Produtos> _repositoryProdutos;

        public MockupService(List<Produtos> repositoryProdutos)
        {
            _repositoryProdutos = repositoryProdutos;
        }

        public IEnumerable<ProdutosModel> RecoverAll()
        {
            var produtos = _repositoryProdutos;
            return produtos.ConvertToProdutos();
        }

        public ProdutosModel RecoverById(int id)
        {
            var produtos = _repositoryProdutos.Where(p => p.Id.Equals(id)).Select(p => p).First();

            if (produtos is null)
                return default;

            return produtos.ConvertToProdutos();
        }

        public void Delete(int id) => _repositoryProdutos.Remove(_repositoryProdutos.Where(p => p.Id.Equals(id)).Select(p => p).First());

        public ProdutosModel Insert(CreateProdutosModel produtoModel)
        {
            var produtos = produtoModel.ConvertToProdutosEntity();

            _repositoryProdutos.Add(produtos);
            return produtos.ConvertToProdutos();
        }


        public ProdutosModel Update(int id, UpdateProdutosModel produtoModel)
        {
            if (id != produtoModel.Id)
                return default;

            var produtos = produtoModel.ConvertToProdutosEntity();
            _repositoryProdutos.Remove(_repositoryProdutos.Where(p => p.Id.Equals(id)).Select(p => p).First());
            _repositoryProdutos.Add(produtos);
            return produtos.ConvertToProdutos();
        }
    }
}
