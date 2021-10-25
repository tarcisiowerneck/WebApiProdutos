using System.Collections.Generic;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.Service
{
    public class ProdutosService : IServiceProdutos
    {
        private readonly IRepositoryProdutos _repositoryProdutos;

        public ProdutosService(IRepositoryProdutos repositoryProdutos)
        {
            _repositoryProdutos = repositoryProdutos;
        }

        public IEnumerable<ProdutosModel> RecoverAll()
        {
            var produtos = _repositoryProdutos.GetAll();
            return produtos.ConvertToProdutos();
        }

        public ProdutosModel RecoverById(int id)
        {
            var produtos = _repositoryProdutos.GetById(id);

            if (produtos is null)
                return default;

            return produtos.ConvertToProdutos();
        }

        public void Delete(int id) =>
            _repositoryProdutos.Remove(id);

        public ProdutosModel Insert(CreateProdutosModel produtoModel)
        {
            var produtos = produtoModel.ConvertToProdutosEntity();

            _repositoryProdutos.Save(produtos);
            return produtos.ConvertToProdutos();
        }


        public ProdutosModel Update(int id, UpdateProdutosModel produtoModel)
        {
            if (id != produtoModel.Id)
                return default;

            var produtos = produtoModel.ConvertToProdutosEntity();

            _repositoryProdutos.Save(produtos);
            return produtos.ConvertToProdutos();
        }
    }
}
