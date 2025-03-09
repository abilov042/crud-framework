using Dao.Concretes;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;

namespace WebApi.Controller;

[Route("/v1/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}