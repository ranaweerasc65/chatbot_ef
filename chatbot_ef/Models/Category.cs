using System.ComponentModel.DataAnnotations;

namespace chatbot_ef.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}

