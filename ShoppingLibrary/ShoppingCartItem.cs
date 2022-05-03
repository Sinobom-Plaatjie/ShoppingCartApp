using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    
    public class ShoppingCartItem 
    {
        private double _price;
        private string _itemName;

        public ShoppingCartItem(string itemName, double price) 
        {
            _price = price;
            _itemName = itemName;
        }
     

        public double Price
        { 
         get {
                return _price;
              } 

         set  { 
                _price = value;
              } 
        }

        public string ItemName
        { 
            get {
                return _itemName; 
              }

          set { 
                _itemName = value; 
              }
          
        }

       
    }
}
