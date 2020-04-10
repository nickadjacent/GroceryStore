using System;
using System.Collections.Generic;

namespace GroceryShoppingOOP
{
    public class GroceryStore
    {
        public string Name;
        private List<Shopper> _shoppers = new List<Shopper>();
        // Will a shopper be able to accesss these products if they are in the _shoppers list?
        private List<Product> _products = new List<Product>();



        public GroceryStore(string name)
        {
            Name = name;
            _products = new List<Product>
            {
                new Product("Milk", 4.99m),
                new Product("Royal Jelly", 10.96m),
                new Product("Healing Crystal", 66.60m),
                new Product("Cactus Jerkey", 5.95m),
                new Product("Fruit Flavored Fruitless Chews", 1.50m),
            };
        }

        public void ShopperEntering(Shopper shopper)
        {
            _shoppers.Add(shopper);
            DisplayShoppers();
        }

        private void DisplayShoppers()
        {
            Console.WriteLine(string.Join(",", _shoppers));
        }

        public void DisplayAvailableProducts()
        {
            Console.WriteLine(string.Join(",", _products));
        }
    }
}