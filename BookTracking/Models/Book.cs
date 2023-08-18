using System.ComponentModel.DataAnnotations;

namespace Boo.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
