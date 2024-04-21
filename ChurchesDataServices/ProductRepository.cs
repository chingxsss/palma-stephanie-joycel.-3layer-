//DataLayer
//ProductRepository.cs


using Model;

public class ProductRepository
{
    private List<Product> products;

    public ProductRepository()
    {
        products = new List<Product>
        {
            new Product { Id = 1, Name = "Bond Paper", Price = 175 },
            new Product { Id = 2, Name = "Colored Paper", Price = 10 },
            new Product { Id = 3, Name = "Crayons", Price = 25 },
            new Product { Id = 4, Name = "Glue", Price = 18 },
            new Product { Id = 5, Name = "Ballpen", Price = 15 },

        };
    }



    public List<Product> GetAllProducts()
    {
        return products;
    }

    public void AddProduct(Product product)
    {
        product.Id = products.Count + 1;
        products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
        }
    }

    public void DeleteProduct(int productId)
    {
        var productToRemove = products.FirstOrDefault(p => p.Id == productId);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
        }
    }
}