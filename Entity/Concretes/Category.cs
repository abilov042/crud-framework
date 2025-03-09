using System.ComponentModel.DataAnnotations.Schema;
using Core.Entity;

namespace Entity.Concretes;

[Table("categories")]
public class Category : IEntity
{
    [Column("category_id")]
    public int CategoryId { get; set; }

    [Column("category_name")]
    public string? CategoryName { get; set; }    
}