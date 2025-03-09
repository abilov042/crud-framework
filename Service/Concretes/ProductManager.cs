using Dao.Abstracts;
using Dao.Concretes;
using Entity.Concretes;
using Entity.DTOs;
using Service.Abstracts;

namespace Service.Concretes;

public class ProductManager:IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public List<ProductDetailsDto> GetProductDetails()
    {
        return _productDal.GetProductDetailsDto();
    }
}