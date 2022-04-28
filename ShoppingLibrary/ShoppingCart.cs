using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
       
        private double _total = 0;
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
            

            foreach (ShoppingCartItem item in _items)
            {
                _total += item.Price;
            }

            return _total;
        }
        public double Vat()
        {
              double vat = 0;
              vat = GetSubTotal() + GetSubTotal()*0.15;            
              return vat; 
        }


    }
}
