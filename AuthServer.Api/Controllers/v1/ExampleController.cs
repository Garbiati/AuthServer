using AuthServer.Api.Controllers.Shared;
using AuthServer.Application.DTO.Example;
using AuthServer.Application.Interfaces;
using AuthServer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ExampleController : ApiControllerBase<Example, ExampleDTO, ExampleCreateDTO, ExampleUpdateDTO>
    {
        public ExampleController(IServiceBase<Example, ExampleDTO, ExampleCreateDTO, ExampleUpdateDTO> service) : base(service)
        {
        }
    }
}