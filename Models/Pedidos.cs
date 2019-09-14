using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASPCoreSample.Repository;
using Dapper;
 
namespace ASPCoreSample.Models
{

    public partial class Pedidos: BaseEntity
    {
        
        [Key]
        public int Id { get; set; }
        
               
        public int Idcliente { get; set; }

        
        public int Idformapag { get; set; }
        
        [Required]        
        public decimal Frete { get; set; }
        
        [Required]        
        public decimal Total { get; set; }


        public int Idstatus { get; set; }
            
        public DateTime Data{ get; set; }

        public Clientes clientes { get; set; }
        public Formapagamentos formapagamentos { get; set; }
        public Status status { get; set; }
     
        
     
    }
}