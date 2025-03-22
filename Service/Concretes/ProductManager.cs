using Dao.Abstracts;
using Dao.Concretes;
using Entity.Concretes;
using Entity.DTOs;
using Service.Abstracts;

namespace Service.Concretes;

public class ProductManager(IProductDal productDal):IProductService
{
    public List<Product> GetAll()
    {
        return productDal.GetAll();
    }

    public List<ProductDetailsDto> GetProductDetails()
    {
        return productDal.GetProductDetailsDto();
    }
}