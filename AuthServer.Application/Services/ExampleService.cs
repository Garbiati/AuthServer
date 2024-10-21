using AuthServer.Application.DTO.Example;
using AuthServer.Domain.Entities;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Interfaces;
using AutoMapper;

namespace AuthServer.Application.Services;

public class ExampleService : ServiceBase<Example, ExampleDTO, ExampleCreateDTO, ExampleUpdateDTO>, IExampleService
{
    public ExampleService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }
}

