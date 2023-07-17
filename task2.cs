using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}

public static class InventoryManagement
{
    public static List<Product> SortProducts(List<Product> products, string sortKey, bool ascending = true)
    {
        switch (sortKey)
        {
            case "name":
                return ascending ? products.OrderBy(p => p.Name).ToList() : products.OrderByDescending(p => p.Name).ToList();
            case "price":
                return ascending ? products.OrderBy(p => p.Price).ToList() : products.OrderByDescending(p => p.Price).ToList();
            case "stock":
                return ascending ? products.OrderBy(p => p.Stock).ToList() : products.OrderByDescending(p => p.Stock).ToList();
            default:
                throw new ArgumentException("Invalid sort key.");
        }
    }
}

List<Product> products = new List<Product>
{
    new Product { Name = "Product A", Price = 100, Stock = 5 },
    new Product { Name = "Product B", Price = 200, Stock = 3 },
    new Product { Name = "Product C", Price = 50, Stock = 10 }
};

string sortKey = "price";
bool ascending = false;

List<Product> sortedProducts = InventoryManagement.SortProducts(products, sortKey, ascending);

foreach (Product product in sortedProducts)
{
    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
}
