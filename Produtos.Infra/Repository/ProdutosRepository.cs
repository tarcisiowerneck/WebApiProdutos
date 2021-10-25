using System.Collections.Generic;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Infra.Context;

namespace WebApiProdutos.Infra.Repository
{
    public class ProdutosRepository : BaseRepository<Produtos, int>, IRepositoryProdutos
    {
        public ProdutosRepository(ProdutosDbContext produtosDbContext) : base(produtosDbContext) { }

        public void Remove(int id) => base.Delete(id);


        public void Save(Produtos obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public Produtos GetById(int id) => base.Select(id);

        public IList<Produtos> GetAll() => base.Select();

    }
}
