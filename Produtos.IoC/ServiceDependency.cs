using Microsoft.Extensions.DependencyInjection;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Service;

namespace WebApiProdutos.IoC
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services) => services.AddScoped<IServiceProdutos, ProdutosService>();
    }
}