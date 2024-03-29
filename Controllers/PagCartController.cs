using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPagamento.Models;
using ApiPagamento.services;
using Microsoft.AspNetCore.Mvc;

namespace ApiPagamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagCartController : ControllerBase
    {
        private readonly PagamentoCartao _service;

        public PagCartController(PagamentoCartao service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.Listar());
        }

        [HttpPost]
        public IActionResult CadastrarNumCart(PagamentoCartaoModel cartao)
        {
             _service.CadastrarCartao(cartao);

                return Ok("Numero do cartão cadastrado com sucesso");
           
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.RemoverCartao(id);
            return StatusCode(204);
        }
    }
}