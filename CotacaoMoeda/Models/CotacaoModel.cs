using System;
using System.ComponentModel.DataAnnotations;
using CotacaoMoeda.Entidades;

namespace CotacaoMoeda.Models
{
    public class CotacaoModel 

    {
        public long Id { get; set; }    
        [Required]
        public decimal Valor { get; set; }

        [Required]
        public DateTime Data { get; set; }

    }
}
