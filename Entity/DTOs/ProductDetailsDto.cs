using Core.Entity;

namespace Entity.DTOs;

public class ProductDetailsDto : IDto
{
    public string? ProductName { get; set; }
    public string? CategoryName { get; set; }
}