using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASPCoreSample.Repository;
using Dapper;
 
namespace ASPCoreSample.Models
{

    public partial class Clientes: BaseEntity
    {
        
        [Key]
        public int Id { get; set; }
       
         
        public int Idcidade { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]      
        public string Email { get; set; }

        [Required]        
        public string Cpf { get; set; }
      
        public int Rg { get; set; }
     
        public DateTime Datanasc { get; set; }
       
        public int Fone { get; set; }
        [Required]
        
        public string Login { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Senha { get; set; }
        
        [Required]
        public string Logradouro { get; set; }

        public int Cep { get; set; }
        [Required]

        public string Bairro { get; set; }

        public int? Numero { get; set; }

        
        public Cidades cidades { get; set; }
 
    }
}