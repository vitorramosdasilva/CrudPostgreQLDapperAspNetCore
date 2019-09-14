using System.ComponentModel.DataAnnotations;
 
namespace ASPCoreSample.Models
{
   
    public partial class Status: BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        public string Situacao { get; set; }

    }
}