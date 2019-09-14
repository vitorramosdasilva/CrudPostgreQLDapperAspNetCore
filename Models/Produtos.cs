using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASPCoreSample.Repository;
using Dapper;
 
namespace ASPCoreSample.Models
{

    public partial class Produtos: BaseEntity
    {
        
        [Key]
        public int Id { get; set; }
        
        [Required]        
        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }
        
        [Required]        
        public string Imagem { get; set; }
        
        [Required]        
        public string Nome { get; set; }


        public int Idcategoria { get; set; }
            
        public Categorias categorias{ get; set; }
     

        //public virtual Lazy<Categorias> Categorias { get { return new Lazy<Categorias>(() => new CategoriasRepository.FindByID((int)IdCategoria)); } }
        //public virtual Lazy<IEnumerable<Categorias>> CategoriasList { get { return new Lazy<IEnumerable<Categorias>>(() => new Categorias().FindAll()); } }

        //public virtual Lazy<Customer> Customer { get { return new Lazy<Customer>(() => new Customer().FetchById((int)CustomerId)); } }
        //public virtual Lazy<IEnumerable<Customer>> CustomerList { get { return new Lazy<IEnumerable<Customer>>(() => new Customer().FetchAll()); } }
        
     
    }
}