using Microsoft.AspNetCore.Mvc;
using System;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.WebApi.Controllers
{
    [Route("api/limpeza")]
    [ApiController]
    public class LimpezaController : Controller
    {
        private readonly IServiceProdutos _serviceProdutos;

        public LimpezaController(IServiceProdutos serviceProdutos) => _serviceProdutos = serviceProdutos;


        [HttpPost]
        public IActionResult Register([FromBody] CreateProdutosTipoModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Insert(produtoModel.ConvertToProdutosModel(TipoProdutos.Alimento));

                return Created($"/api/limpeza/{produto?.Id}", produto?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}