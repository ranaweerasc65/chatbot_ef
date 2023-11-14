using System.ComponentModel.DataAnnotations;

namespace chatbot_ef.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        
        public int Category_ID { get; set; }  // Foreign key
        public Category? Category { get; set; }
        public ICollection<ShopProduct>? ShopProducts { get; set; }
    }
}

