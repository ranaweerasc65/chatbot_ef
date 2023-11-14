namespace chatbot_ef.Models
{
    public class ShopProduct
    {
        public int ShopId { get; set; }
        public Shop? Shop { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }

}
