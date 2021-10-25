using Microsoft.AspNetCore.Mvc;
using System;
using WebApiProdutos.Domain.Interfaces;
using WebApiProdutos.Domain.Models;

namespace WebApiProdutos.WebApi.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IServiceProdutos _serviceProdutos;

        public ProdutosController(IServiceProdutos serviceProdutos) => _serviceProdutos = serviceProdutos;


        [HttpPost]
        public IActionResult Register([FromBody] CreateProdutosModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Insert(produtoModel);

                return Created($"/api/produtos/{produto?.Id}", produto?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateProdutosModel produtoModel)
        {
            try
            {
                var produto = _serviceProdutos.Update(id, produtoModel);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _serviceProdutos.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                var produto = _serviceProdutos.RecoverAll();
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                var produto = _serviceProdutos.RecoverById(id);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}