using System.ComponentModel.DataAnnotations;
 
namespace ASPCoreSample.Models
{
    
    public partial class Administradores: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]        
        public string Nome { get; set; }

        [Required]        
        public string Login { get; set; }

        [Required]        
        public string Senha { get; set; }
    }
}