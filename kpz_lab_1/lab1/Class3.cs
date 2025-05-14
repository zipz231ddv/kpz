using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public class Warehouse
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product FindProductByName(string name)
        {
            return products.FirstOrDefault(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void ShowAllProducts()
        {
            if (!products.Any())
            {
                Console.WriteLine("the warehouse is empty");
                return;
            }
            Console.WriteLine("list of products:");
            foreach (var product in products)
            {
                product.Display();
            }
        }
    }
}