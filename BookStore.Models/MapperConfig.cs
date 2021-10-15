using AutoMapper;
using BookStore.Models.DTOs.VM;
using BookStore.Models.Entities;

namespace BookStore.Models
{
    public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<ProductType, ProductTypeVM>();
                  cfg.CreateMap<ProductTypeVM, ProductType>();


                  cfg.CreateMap<Product, ProductVM>();
                  cfg.CreateMap<ProductVM, Product>();

                  cfg.CreateMap<Feedback, FeedbackVM>();
                  cfg.CreateMap<FeedbackVM, Feedback>();

              });
            return config.CreateMapper();
        }
    }
}
