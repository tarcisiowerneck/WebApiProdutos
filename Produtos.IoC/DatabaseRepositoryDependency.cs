using Microsoft.Extensions.DependencyInjection;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Infra.Repository;

namespace WebApiProdutos.IoC
{
    public static class DatabaseRepositoryDependency
    {
        public static void AddDatabaseRepositoryDependency(this IServiceCollection services) => services.AddScoped<IRepositoryProdutos, ProdutosRepository>();
    }
}
