using System.ComponentModel.DataAnnotations.Schema;
using Core.Entity;

namespace Entity.Concretes;


[Table("products")]
public class Product : IEntity
{
    [Column("product_id")]
    public int ProductId { get; set; }
    [Column("product_name")]
    public string? ProductName { get; set; }

    [Column("category_id")]
    public int CategoryId { get; set; }
}