namespace chatbot_ef.Models
{
    public class ShopPlatform
    {
        public int ShopId { get; set; }
        public Shop? Shop { get; set; }

        public int PlatformId { get; set; }
        public Platform? Platform { get; set; }
    }
}
