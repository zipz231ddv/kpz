using System;

namespace lab1
{
    public class Product
    {
        private string name;
        private string unit;
        private Money price;
        private int quantity;
        private DateTime lastDelivery;

        public Product() { }

        public Product(string name, string unit, Money price, int quantity, DateTime delivery)
        {
            SetName(name);
            SetUnit(unit);
            SetPrice(price);
            SetQuantity(quantity);
            SetLastDeliveryDate(delivery);
        }

        public string GetName() => name;
        public void SetName(string value) => name = value;
        public string GetUnit() => unit;
        public void SetUnit(string value) => unit = value;
        public Money GetPrice() => price;
        public void SetPrice(Money value) => price = value;
        public int GetQuantity() => quantity;
        public void SetQuantity(int value)
        {
            if (value < 0) throw new ArgumentException("the quantity is negative");
            quantity = value;
        }
        public DateTime GetLastDeliveryDate() => lastDelivery;
        public void SetLastDeliveryDate(DateTime date) => lastDelivery = date;
        public void AddStock(int amount, DateTime date)
        {
            if (amount <= 0) throw new ArgumentException("the quantity must be positive");
            quantity += amount;
            lastDelivery = date;
        }
        public void RemoveStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("the quantity must be positive");
            if (amount > quantity) throw new InvalidOperationException("not enough goods");
            quantity -= amount;
        }

        public void Display()
        {
            Console.WriteLine
                (
                $"name: {name}, " +
                $"price: {price.ToDecimal():F2} grn, " +
                $"unit: {unit}, " +
                $"quantity: {quantity}, " +
                $"last delivery: {lastDelivery.ToShortDateString()}"
                );
        }
    }
}