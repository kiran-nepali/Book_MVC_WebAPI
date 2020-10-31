using System.ComponentModel.DataAnnotations;

namespace MVCapi.Models{
    public class Book{
        [Key]
        public int Id{get;set;}
        
        
        [Required]
        [MaxLength(250)]
        public string Title{get;set;}
        
        [Required]
        public string Writer{get;set;}
    }
}