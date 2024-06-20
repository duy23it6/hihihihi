using System;
using System.Collections;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

class ProductManager
{
    private ArrayList products;

    public ProductManager()
    {
        products = new ArrayList();
    }

    public void AddProduct()
    {
        Product newProduct = new Product();

        Console.Write("Enter product name: ");
        newProduct.Name = Console.ReadLine();

        Console.Write("Enter product description: ");
        newProduct.Description = Console.ReadLine();

        Console.Write("Enter product price: ");
        newProduct.Price = decimal.Parse(Console.ReadLine());

        products.Add(newProduct);
        Console.WriteLine("Product added successfully.");
    }

    public void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products found.");
            return;
        }

        Console.WriteLine("Product List:");
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Description: {product.Description}, Price: {product.Price:C}");
        }
    }

    public void SearchProduct()
    {
        Console.Write("Enter product name to search: ");
        string searchName = Console.ReadLine();

        bool found = false;
        foreach (Product product in products)
        {
            if (product.Name.ToLower().Contains(searchName.ToLower()))
            {
                Console.WriteLine($"Name: {product.Name}, Description: {product.Description}, Price: {product.Price:C}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No products found with the given name.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager();

        while (true)
        {
            Console.WriteLine("\nProduct Management Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Search Product");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    productManager.AddProduct();
                    break;
                case 2:
                    productManager.DisplayProducts();
                    break;
                case 3:
                    productManager.SearchProduct();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}