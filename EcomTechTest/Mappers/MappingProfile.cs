using AutoMapper;
using EcomTechTest.Entities;
using EcomTechTest.Modals;

namespace EcomTechTest.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CartItem, CartProduct>().
                ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name)).
                ForMember(dest => dest.ProductDescription, opt => opt.MapFrom(src => src.Product.Description)).
                ForMember(dest => dest.ProductID, opt => opt.MapFrom(src => src.ProductId)).
                ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));


           CreateMap<Product, ProductInfo>().
                ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description)).
                ForMember(dest => dest.InStock, opt => opt.MapFrom(src => (src.QuantityInStock > 0)));

            CreateMap<CartUpdate, CartItem>().
                 ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId)).
                 ForMember(dest => dest.CartId, opt => opt.MapFrom(src => src.CartId)).
                 ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quanitity));

        }
    }

}
