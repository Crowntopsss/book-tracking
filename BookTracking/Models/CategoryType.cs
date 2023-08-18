using System.ComponentModel.DataAnnotations;

namespace BookTracking.Models
{
    public class CategoryType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
