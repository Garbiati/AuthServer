using AuthServer.Application.DTO.Example;
using AuthServer.Domain.Entities;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Interfaces;
using AutoMapper;

namespace AuthServer.Application.Services;

public class ExampleItemService : ServiceBase<ExampleItem, ExampleItemDTO, ExampleItemCreateDTO, ExampleItemUpdateDTO>, IExampleItemService
{
    public ExampleItemService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }
}

