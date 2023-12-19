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
    public class PagPixController : ControllerBase
    {
        private readonly PagamentoPix _service;

        public PagPixController(PagamentoPix service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Lista()
        {
            return Ok(_service.Listar());
        }

        [HttpPost]
        public IActionResult Pix(PagamentoPixModel pix)
        {
            _service.cadastrarPix(pix);
            return Ok("Pix enviado com sucesso");
        }

       
    }
}