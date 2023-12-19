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

        public void cadastrarPix(PagamentoPixModel pix)
        {
            if (pix.ChavePix == "CPF")
            {
                if (pix.numeroPix.Length != 11 || !pix.numeroPix.All(char.IsDigit))
                {
                    throw new ArgumentException("CPF inválido");
                }
            }
            else if (pix.ChavePix == "Telefone")
            {
                if (pix.numeroPix.Length != 11 || !pix.numeroPix.All(char.IsDigit))
                {
                    throw new ArgumentException("Telefone inválido");
                }
            }
            else if (pix.ChavePix == "Email")
            {
                if (!pix.numeroPix.Contains('@'))
                {
                    throw new ArgumentException("Email inválido");
                }
            }
            else
            {
                throw new ArgumentException("Chave do Pix inválida");
            }

            // Se chegou até aqui, a chave do Pix é válida, então você pode adicionar ao contexto e salvar.
            _context.Add(pix);
            _context.SaveChanges();

        }
    }
}