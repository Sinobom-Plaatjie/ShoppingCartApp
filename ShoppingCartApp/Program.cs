using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            ShoppingCartItem item = new ShoppingCartItem(" Rice", 109.00);
            cart.AddShoppingItem(item);


         
            item = new ShoppingCartItem("Sugar", 56.69);
            cart.AddShoppingItem(item);


            item = new ShoppingCartItem("Flour", 95.00);
            cart.AddShoppingItem(item);



            List<ShoppingCartItem> items = cart.CartList();
            foreach(ShoppingCartItem shoppingItem in items)
            {
                Console.WriteLine(shoppingItem.ItemName + "          R" + shoppingItem.Price);
            }
            
            
            
            Console.WriteLine("Sub Total     R" + cart.GetSubTotal());
            Console.WriteLine("With VAT      R" + cart.Vat());


            // ShoppingCartItem test1 = new ShoppingCartItem();
            // Console.WriteLine(test);
            // Console.WriteLine(test1);
        }
    }
}
