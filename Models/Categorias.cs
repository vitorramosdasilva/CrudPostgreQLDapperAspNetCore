using System.ComponentModel.DataAnnotations;
 
namespace ASPCoreSample.Models
{
   
    public partial class Categorias: BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]       
        public string Descricao { get; set; }
       
    }
}