using AuthServer.Api.Controllers.Shared;
using AuthServer.Application.DTO.Example;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Entities;

namespace AuthServer.Api.Controllers.v1;
public class ExampleItemsController : ApiControllerBase<ExampleItem, ExampleItemDTO, ExampleItemCreateDTO, ExampleItemUpdateDTO>
{
    public ExampleItemsController(IServiceBase<ExampleItem, ExampleItemDTO, ExampleItemCreateDTO, ExampleItemUpdateDTO> service) : base(service)
    {
    }
}
