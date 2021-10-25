using System.Collections.Generic;
using WebApiProdutos.Domain.Entities;

namespace WebApiProdutos.Domain.Interfaces
{
    public interface IRepositoryProdutos
    {
        void Save(Produtos obj);

        void Remove(int id);

        Produtos GetById(int id);

        IList<Produtos> GetAll();
    }
}
