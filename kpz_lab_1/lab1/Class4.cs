using System;

namespace lab1
{
    public class Reporting
    {
        private Warehouse warehouse;
        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }
        public void RegisterIncome(string name, int quantity, Money price, string unit, string category)
        {
            var product = warehouse.FindProductByName(name);
            if (product != null)
            {
                product.AddStock(quantity, DateTime.Now);
                product.SetPrice(price);
                Console.WriteLine($"arrival of goods {name}, quantity {quantity} {unit}");
            }
            else
            {
                var newProduct = new Product(name, unit, price, quantity, DateTime.Now);
                warehouse.AddProduct(newProduct);
                Console.WriteLine($"a new product has been added: {name}, {quantity} {unit}");
            }
        }

        public void RegisterShipment(string name, int quantity)
        {
            var product = warehouse.FindProductByName(name);
            if (product != null)
            {
                try
                {
                    product.RemoveStock(quantity);
                    Console.WriteLine($"shipped {quantity} {product.GetUnit()} unit '{name}'");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"product '{name}' not found");
            }
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("\n balance report");
            warehouse.ShowAllProducts();
        }
    }
}