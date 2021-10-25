using Microsoft.AspNetCore.Mvc;
using System;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.WebApi.Controllers
{
    [Route("api/outros")]
    [ApiController]
    public class OutrosController : Controller
    {
        private readonly IServiceProdutos _serviceProdutos;

        public OutrosController(IServiceProdutos serviceProdutos) => _serviceProdutos = serviceProdutos;


        [HttpPost]
        public IActionResult Register([FromBody] CreateProdutosTipoModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Insert(produtoModel.ConvertToProdutosModel(TipoProdutos.Outros));

                return Created($"/api/outros/{produto?.Id}", produto?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}