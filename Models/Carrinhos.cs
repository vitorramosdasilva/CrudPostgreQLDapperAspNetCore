using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASPCoreSample.Repository;
using Dapper;
 
namespace ASPCoreSample.Models
{

    public partial class Carrinhos: BaseEntity
    {
        
        [Key]
        public int Id { get; set; }
        
                
        public int Idproduto { get; set; }

        public string Nome { get; set; }
                
        public int Idcliente { get; set; }
        
         public decimal Preco { get; set; }
                
        public int Quantidade { get; set; }
                
        //public Pedidos pedidos{ get; set; }
        //public Produtos produtos{ get; set; }

       
    }
}