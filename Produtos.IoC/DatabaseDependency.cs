using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiProdutos.Infra.Context;

namespace WebApiProdutos.IoC
{
    public static class DatabaseDependency
    {
        public static void AddDatabaseDependency(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<ProdutosDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Produtos.Infra")));

        public static void UseMigrate(this IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ProdutosDbContext>();
                context.Database.Migrate();
            }
        }
    }
}
