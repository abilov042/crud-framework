using Core.DataAccess;
using Dao.Abstracts;
using Entity.Concretes;
using Entity.DTOs;

namespace Dao.Concretes;

public class EfProductDal:EfEntityRepository<Product, NorthwindDbContext>,IProductDal
{
    public List<ProductDetailsDto> GetProductDetailsDto()
    {
        using (var context = new NorthwindDbContext())
        {
            var result = from p in context.Products
                    join c in context.Categories 
                    on p.CategoryId equals c.CategoryId 
                    select new ProductDetailsDto(){ProductName = p.ProductName, CategoryName = c.CategoryName};
            return result.ToList();
        }
    }
}