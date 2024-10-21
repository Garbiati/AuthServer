using AutoMapper;
using AuthServer.Application.DTO.Example;
using AuthServer.Domain.Entities;

namespace AuthServer.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Example
            CreateMap<ExampleDTO, Example>();
            CreateMap<Example, ExampleDTO>();

            CreateMap<ExampleCreateDTO, Example>();
            CreateMap<Example, ExampleCreateDTO>();

            CreateMap<ExampleUpdateDTO, Example>();
            CreateMap<Example, ExampleUpdateDTO>();

            // ExampleItem
            CreateMap<ExampleItemDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemDTO>();

            CreateMap<ExampleItemCreateDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemCreateDTO>();

            CreateMap<ExampleItemUpdateDTO, ExampleItem>();
            CreateMap<ExampleItem, ExampleItemUpdateDTO>();
        }
    }
}