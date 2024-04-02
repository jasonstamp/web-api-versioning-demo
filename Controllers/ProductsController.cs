using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioningDemo;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService productService;

    public ProductsController(IProductService productService)
    {
        this.productService = productService;
    }

    [HttpGet]
    public ActionResult GetProducts()
    {
        return Ok(productService.GetAll()); 
    }
}
