using negotium.API.Dtos;

namespace API.Dtos
{
    public class OrderDto
    {
        public string basketId { get; set; }
        public int deliveryMethodId { get; set; }
        public AddressDto ShipToAddress { get; set; }
    }
}