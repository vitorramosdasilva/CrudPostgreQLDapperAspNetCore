using System.ComponentModel.DataAnnotations;
 
namespace ASPCoreSample.Models
{
   
    public partial class Cidades: BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        public string Nome { get; set; }

        [Required]        
        public string Estado { get; set; }
      
    }
}