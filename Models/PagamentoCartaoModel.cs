using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPagamento.Models
{
    public class PagamentoCartaoModel
    {   
        [Key]
        public int PagCartId { get; set; }
        public string NumeroCartao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        public string DataValidade { get; set; }
        public string CodigoSeguranca {get; set;}

       
    }
}