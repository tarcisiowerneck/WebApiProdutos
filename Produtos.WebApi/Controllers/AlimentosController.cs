using Microsoft.AspNetCore.Mvc;
using System;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.WebApi.Controllers
{
    [Route("api/alimentos")]
    [ApiController]
    public class AlimentosController : Controller
    {
        private readonly IServiceProdutos _serviceProdutos;

        public AlimentosController(IServiceProdutos serviceProdutos) => _serviceProdutos = serviceProdutos;


        [HttpPost]
        public IActionResult Register([FromBody] CreateProdutosTipoModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Insert(produtoModel.ConvertToProdutosModel(TipoProdutos.Alimento));

                return Created($"/api/alimentos/{produto?.Id}", produto?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}