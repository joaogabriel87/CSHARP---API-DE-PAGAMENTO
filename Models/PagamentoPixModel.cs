using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPagamento.Models
{
    public class PagamentoPixModel
    {
        [Key]
        public int Id { get; set; }
        public string ChavePix {get;set;}
        public decimal Valor {get;set;}
    }
}