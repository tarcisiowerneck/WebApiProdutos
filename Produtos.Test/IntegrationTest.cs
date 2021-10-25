using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.WebApi.Controllers;
using Xunit;

namespace WebApiProdutos.Test
{
    public class IntegrationTest
    {
        [Fact]
        public void TestRecoverAll()
        {
            var mock = new List<Produtos>()
            {
                new Produtos(1,"Produto1",10.21m, DateTime.Now,12.37m, Domain.Enums.TipoProdutos.Outros),
                new Produtos(2,"Produto2",1.37m, DateTime.Now,1m, Domain.Enums.TipoProdutos.Limpeza),
                new Produtos(3,"Produto3",-2.37m, new DateTime(),3.3m, Domain.Enums.TipoProdutos.Eletrodomestico),
                new Produtos(4,"Produto4",3m, DateTime.Now,-4.4m, Domain.Enums.TipoProdutos.Alimento),
            };

            var mockService = new MockupService(mock);

            var controller = new ProdutosController(mockService);

            var result = controller.RecoverAll();

            Assert.IsAssignableFrom<OkObjectResult>(result);
        }

        [Fact]
        public void TestRecoverById()
        {
            var mock = new List<Produtos>()
            {
                new Produtos(1,"Produto1",10.21m, DateTime.Now,12.37m, Domain.Enums.TipoProdutos.Outros),
                new Produtos(2,"Produto2",1.37m, DateTime.Now,1m, Domain.Enums.TipoProdutos.Limpeza),
                new Produtos(3,"Produto3",-2.37m, new DateTime(),3.3m, Domain.Enums.TipoProdutos.Eletrodomestico),
                new Produtos(4,"Produto4",3m, DateTime.Now,-4.4m, Domain.Enums.TipoProdutos.Alimento),
            };

            var mockService = new MockupService(mock);

            var controller = new ProdutosController(mockService);

            var result = controller.Recover(3);

            Assert.IsAssignableFrom<OkObjectResult>(result);
            if (result is OkObjectResult ok && ok.Value is ProdutosModel produtoModel)
                Assert.Equal("Produto3", produtoModel.Descricao);
        }

        [Fact]
        public void TestRecoverWithInvalidId()
        {
            var mock = new List<Produtos>()
            {
                new Produtos(1,"Produto1",10.21m, DateTime.Now,12.37m, Domain.Enums.TipoProdutos.Outros),
                new Produtos(2,"Produto2",1.37m, DateTime.Now,1m, Domain.Enums.TipoProdutos.Limpeza),
                new Produtos(4,"Produto4",3m, DateTime.Now,-4.4m, Domain.Enums.TipoProdutos.Alimento),
            };

            var mockService = new MockupService(mock);

            var controller = new ProdutosController(mockService);

            var result = controller.Recover(3);

            Assert.IsAssignableFrom<BadRequestObjectResult>(result);
        }
    }
}
