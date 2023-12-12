using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPagamento.Context;
using ApiPagamento.Controllers;
using ApiPagamento.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiPagamento.services
{
    public class PagamentoCartao
    {
        private readonly PagamentoContext _context; 

        public PagamentoCartao(PagamentoContext context)    
        {
            _context = context;
        }

        public List<PagamentoCartaoModel> Listar()
        {
            return _context.PagCartao.ToList();
        }


        public void CadastrarCartao(PagamentoCartaoModel cartao)
        {
            _context.PagCartao.Add(cartao);
            _context.SaveChanges();
        }

        public void RemoverCartao(int id)
        {
           var cartao = _context.PagCartao.Find(id);

           try
           {
             _context.PagCartao.Remove(cartao);
             _context.SaveChanges();
           }
           catch (System.Exception)
           {
            
            throw;
           }

        }   
}
}