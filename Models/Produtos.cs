using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
 
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

        public IEnumerable<Categorias> CategoriasList { get; set; }
        public Categorias Idcategoria { get; set; }
     
    }
}