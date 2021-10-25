using Microsoft.AspNetCore.Mvc;
using System;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;
using WebApiProdutos.Infra.Converter;

namespace WebApiProdutos.WebApi.Controllers
{
    [Route("api/eletrodomestico")]
    [ApiController]
    public class EletrodomesticoController : Controller
    {
        private readonly IServiceProdutos _serviceProdutos;

        public EletrodomesticoController(IServiceProdutos serviceProdutos) => _serviceProdutos = serviceProdutos;


        [HttpPost]
        public IActionResult Register([FromBody] CreateProdutosTipoModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Insert(produtoModel.ConvertToProdutosModel(TipoProdutos.Eletrodomestico));

                return Created($"/api/eletrodomestico/{produto?.Id}", produto?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}