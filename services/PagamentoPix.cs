using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPagamento.Context;
using ApiPagamento.Models;

namespace ApiPagamento.services
{
    public class PagamentoPix
    {
        private readonly PagamentoContext _context;
        public PagamentoPix(PagamentoContext context)
        {
            _context = context;
        }

        public List<PagamentoPixModel> Listar()
        {
            return _context.PagPix.ToList();
        }

        public void CadastrarPix(PagamentoPixModel pix)
        {
            _context.PagPix.Add(pix);
            _context.SaveChanges();
        }

        public void AjustarValor(PagamentoPixModel pix, int id)
        {
           var buscarPix = _context.PagPix.Find(id);
           
           if (buscarPix != null )
           {
                buscarPix.Valor = pix.Valor;            
           }

           _context.PagPix.Update(buscarPix);
           _context.SaveChanges();
        }
    }
}