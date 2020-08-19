namespace API.Dtos
{
    public class OrderItemDto
    {
        public  int productId { get; set; }
        public  string productName { get; set; }
        public  string pictureUrl { get; set; }
        public decimal Price {get; set;}
        public int Quantity {get; set;}
    }
}