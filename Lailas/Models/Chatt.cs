using System.ComponentModel.DataAnnotations;

namespace Lailas.Models
{
    public class Chatt
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Text { get; set; }
       
    }
}
