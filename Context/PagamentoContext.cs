using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPagamento.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPagamento.Context
{
    public class PagamentoContext : DbContext
    {
        public PagamentoContext()
        {
        }

        public PagamentoContext(DbContextOptions<PagamentoContext> options) : base(options)
        {
            
        }
        public DbSet<PagamentoCartaoModel> PagCartao {get;set;}
        public DbSet<PagamentoPixModel> PagPix {get;set;}

        
    }
}