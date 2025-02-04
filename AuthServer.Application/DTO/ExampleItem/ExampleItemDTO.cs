using System.ComponentModel.DataAnnotations;

namespace AuthServer.Application.DTO.Example;
public class ExampleItemDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
}