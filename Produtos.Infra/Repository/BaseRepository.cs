using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Infra.Context;

namespace WebApiProdutos.Infra.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType>
    {
        protected readonly ProdutosDbContext _produtosDbContext;

        public BaseRepository(ProdutosDbContext produtosDbContext)
        {
            _produtosDbContext = produtosDbContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _produtosDbContext.Set<TEntity>().Add(obj);
            _produtosDbContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _produtosDbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _produtosDbContext.SaveChanges();
        }

        protected virtual void Update<TProperty>(TEntity obj, params PropertyEntry<TEntity, TProperty>[] propsToIgnore)
        {
            _produtosDbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            foreach (var item in propsToIgnore)
                item.IsModified = false;

            _produtosDbContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _produtosDbContext.Set<TEntity>().Remove(Select(id));
            _produtosDbContext.SaveChanges();
        }

        protected virtual IList<TEntity> Select() =>
            _produtosDbContext.Set<TEntity>().ToList();

        protected virtual TEntity Select(int id) =>
            _produtosDbContext.Set<TEntity>().Find(id);
    }
}
