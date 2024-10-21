using AutoMapper;
using AuthServer.Application.DTO.Example;
using AuthServer.Domain.Entities;

namespace AuthServer.Application.Mappings
{
    public class ExampleItemMappingProfile : Profile
    {
        public ExampleItemMappingProfile()
        {
            CreateMap<ExampleItemDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemDTO>();

            CreateMap<ExampleItemCreateDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemCreateDTO>();

            CreateMap<ExampleItemUpdateDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemUpdateDTO>();
        }
    }
}