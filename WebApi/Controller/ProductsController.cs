using Dao.Concretes;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;

namespace WebApi.Controller;

[Route("/v1/products")]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public List<Product> GetAll()
    {
        return productService.GetAll();
    }
}