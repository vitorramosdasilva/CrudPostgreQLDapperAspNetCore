using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASPCoreSample.Repository;
using Dapper;
 
namespace ASPCoreSample.Models
{

    public partial class Itenspedidos: BaseEntity
    {
        
        [Key]
        public int Id { get; set; }
        
        [Required]        
        public int Idproduto { get; set; }

        
        public int Idpedido { get; set; }
        
        [Required]        
        public int Quantidade { get; set; }
        
                
        public Pedidos pedidos{ get; set; }
        public Produtos Produtos { get; set; }

        
     
    }
}