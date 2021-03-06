using AutoMapper;
using GeekShopping.CartAPI.Model;
using GeekShopping.CartAPI.ValueObjects;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeaders>().ReverseMap();
                config.CreateMap<CartDetailsVO, CartDetails>().ReverseMap();
                config.CreateMap<CartVO, Cart>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
