using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiPagamento.Models
{
    public class PagamentoCartaoModel
    {   
        [Key]
        public int PagCartId { get; set; }
        public string NumeroCartao { get; set; }
        [DisplayFormat(DataFormatString ="MM/yyyy")]
        public DateTime DataValidade { get; set; }
        public string CodigoSeguranca {get; set;}
        
        
    }
}