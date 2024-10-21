using AuthServer.Application.DTO.Example;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Entities;

public interface IExampleItemService : IServiceBase<ExampleItem, ExampleItemDTO, ExampleItemCreateDTO, ExampleItemUpdateDTO>
{

}