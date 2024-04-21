//BusinessLayer
//ProductManager.cs


using Model;


public class ProductManager
{
    ProductRepository productrepository = new ProductRepository();


    public List<Product> GetAllProducts()
    {
        return productrepository.GetAllProducts();
    }

    public void AddProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        productrepository.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        productrepository.UpdateProduct(product);
    }

    public void DeleteProduct(int productId)
    {
        if (productId <= 0)
            throw new ArgumentOutOfRangeException(nameof(productId), "Product ID must be greater than zero.");

        productrepository.DeleteProduct(productId);
    }
}