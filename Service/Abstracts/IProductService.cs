using Dao.Concretes;
using Entity.Concretes;
using Entity.DTOs;

namespace Service.Abstracts;

public interface IProductService
{
    List<Product> GetAll();
    List<ProductDetailsDto> GetProductDetails();
}