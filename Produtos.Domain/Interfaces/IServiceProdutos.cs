using System.Collections.Generic;
using WebApiProdutos.Domain.Models;

namespace WebApiProdutos.Domain.Interfaces
{
    public interface IServiceProdutos
    {
        ProdutosModel Insert(CreateProdutosModel produtoModel);

        ProdutosModel Update(int id, UpdateProdutosModel produtoModel);

        void Delete(int id);

        ProdutosModel RecoverById(int id);

        IEnumerable<ProdutosModel> RecoverAll();
    }
}
