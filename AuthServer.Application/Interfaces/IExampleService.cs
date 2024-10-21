using AuthServer.Application.DTO.Example;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Entities;

public interface IExampleService : IServiceBase<Example, ExampleDTO, ExampleCreateDTO, ExampleUpdateDTO>
{

}