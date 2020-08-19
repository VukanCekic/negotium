using AutoMapper;
using Core.Entities;
using negotium.API.Dtos;
using Address2 = Core.Entities.OrderAggregate.Address;
using Address = Core.Entities.Identity.Address;
using API.Dtos;
using Core.Entities.OrderAggregate;
using API.Helpers;

namespace negotium.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product,ProductToReturnDto>()
              .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
              .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
              .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
              CreateMap<Address, AddressDto>().ReverseMap();
              CreateMap<CustomerBasketDto,CustomerBasket>();
              CreateMap<BasketItemDto,BasketItem>();
              CreateMap<AddressDto, Address2>();

              CreateMap<Order,OrderToReturnDto>()
              .ForMember(d => d.DeliveryMethod, o => o.MapFrom(s => s.DeliveryMethod.ShortName))
              .ForMember(d => d.shippingPrice, o => o.MapFrom(s => s.DeliveryMethod.Price));

              CreateMap<OrderItem,OrderItemDto>()
              .ForMember(d => d.productId, o => o.MapFrom(s => s.itemOrdered.ProductItemId))
              .ForMember(d => d.productName, o => o.MapFrom(s => s.itemOrdered.ProductName))
              .ForMember(d => d.pictureUrl, o => o.MapFrom(s => s.itemOrdered.PictureUrl))
              .ForMember(d => d.pictureUrl, o => o.MapFrom<OrderItemUrlResolver>());
              
        }
    }
}