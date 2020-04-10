using System;
using System.Collections.Generic;

namespace GroceryShoppingOOP
{
    public class Shopper
    {
        public string Name { get; set; }
        // _budget -> underscore is naming convention for private info
        private decimal _budget;

        public Shopper(string name, decimal budget)
        {
            // uses 'this' keyword when you dont put it. Not needed.
            // this.Name = name;
            Name = name;
            _budget = budget;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}