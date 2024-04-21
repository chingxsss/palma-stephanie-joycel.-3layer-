//UserInterface
//ConsoleUI.cs


using Model;

public class ConsoleUI
{
    private ProductManager productManager;

    public ConsoleUI()
    {
        productManager = new ProductManager();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. View Products");
        Console.WriteLine("2. Add Product");
        Console.WriteLine("3. Update Product");
        Console.WriteLine("4. Delete Product");
        Console.WriteLine("5. Exit");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewProducts();
                    break;
                case "2":
                    AddProduct();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    DeleteProduct();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void ViewProducts()
    {
        Console.WriteLine("List of Products:");
        var products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }

    private void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter product price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Product product = new Product { Name = name, Price = price };
            productManager.AddProduct(product);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid price format. Please enter a valid price.");
        }
    }

    private void UpdateProduct()
    {
        Console.Write("Enter product ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            var product = productManager.GetAllProducts().FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Console.Write("Enter new product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter new product price: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    product.Name = name;
                    product.Price = price;
                    productManager.UpdateProduct(product);
                    Console.WriteLine("Product updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid price format. Please enter a valid price.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid product ID format. Please enter a valid ID.");
        }
    }

    private void DeleteProduct()
    {
        Console.Write("Enter product ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            productManager.DeleteProduct(productId);
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid product ID format. Please enter a valid ID.");
        }
    }
}

class Program
{
    static void Main()
    {
        ConsoleUI consoleUI = new ConsoleUI();
        consoleUI.Run();
    }
}