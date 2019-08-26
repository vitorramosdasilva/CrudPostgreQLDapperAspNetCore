using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreSample.Models
{
   
    public partial class Categorias: BaseEntity
    {
        internal Produtos categorias;

        [Key]
        public int Id { get; set; }

        [Required]       
        public string Descricao { get; set; }

        //public Produtos produtos { get; internal set; }
        //public Categorias categorias { get; internal set; }
    }
}