using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
       
        
        public void AddShoppingItem(ShoppingCartItem item)
        {
            _items.Add(item);
        }

        public List<ShoppingCartItem> CartList()
        {
            return _items;
        }

        public double GetSubTotal()
        {
            double subTotal = 0;
            foreach (ShoppingCartItem item in _items)
            {
                subTotal += item.Price;
            }

            return subTotal;
        }
        public double Vat()
        {
            double vat = 0;
            vat = (GetSubTotal() * 1.15);            
              return vat; 
        }


    }
}
