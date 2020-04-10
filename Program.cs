using System;

namespace GroceryShoppingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Create a few grocery stores
                2. Create a few shoppers with a shopping list
                3. Have shoppers enter stores of their choosing
                    - when shopper enters store, store should print a greeting
                4. Have store print list of shoppers
                5. Add items from their list to their cart
                    - print shopping cart items
                6. Shopper checkout and pay
                    - shopper must have enough money
                        -shopper says they got to many items if not enough money
                    - shopper exits store after checkout
                    - store prints goodbye to shopper
                    - store should print list of remaining shopper names
            */

            GroceryStore albertAndHisSons = new GroceryStore("Albertsons");
            GroceryStore ralphStore = new GroceryStore("Ralphs");


            Shopper shopper1 = new Shopper("Scott", 10000);
            Shopper shopper2 = new Shopper("Quang", 1000);
            Shopper shopper3 = new Shopper("Gaku", 100);
            Shopper shopper4 = new Shopper("Bruno", 10);


            albertAndHisSons.ShopperEntering(shopper1);
            albertAndHisSons.ShopperEntering(shopper3);
            ralphStore.ShopperEntering(shopper4);
        }
    }
}
