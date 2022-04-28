using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        double _vat = 0;
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
            double total = 0;

            foreach (ShoppingCartItem item in _items)
            {
                total += item.Price;
            }

            return total;
        }
        public double Vat()
        {
            
           
            _vat = GetSubTotal() + GetSubTotal()*0.15;
            
            return _vat; 
        }


    }
}
