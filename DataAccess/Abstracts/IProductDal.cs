using Core.DataAccess;
using Entity.Concretes;
using Entity.DTOs;

namespace Dao.Abstracts;

public interface IProductDal:IEntityRepository<Product>
{
    List<ProductDetailsDto> GetProductDetailsDto();
}