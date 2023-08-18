using System.ComponentModel.DataAnnotations;

namespace BookTracking.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string NameToken { get; set; }
        public int TypeId { get; set; }
        public CategoryType Type { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
