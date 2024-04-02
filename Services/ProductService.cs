
namespace WebApiVersioningDemo;

public class ProductService : IProductService
{
    private List<Product> products { get; }

    public ProductService()
    {
        products = new List<Product>
        {
            new Product {Id = 1, Name = "Product A", Price = 4.99M, IsAvailabile = true},
            new Product {Id = 2, Name = "Prodcut B", Price = 1.49M, IsAvailabile = false}
        };
    }
    public List<Product> GetAll()
    {
        return products;
    }
}
