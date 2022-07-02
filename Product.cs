using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        private int _id = 0;
        private string _name = null;
        private int _price = 0;
        private double _discountPercentage =0;
        public double discontPrice=0;
        public double calculatePrice=0;

        public int Id 
        { 
            get 
            { 
                return _id; 
            } 
            set 
            { 
                _id = value; 
            }
        }
        public string Name
        {
            get
            { 
                return _name;
            }
            set 
            { 
                _name = value;
            }
        }
        public int Price
        {
            get 
            { 
                return _price; 
            }
            set 
            { 
                _price = value;
            }
        }
        public double DiscountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set 
            {
                _discountPercentage = value;
            }
        }
        
        public double DiscountCalculate()
        {
            _discountPercentage = _discountPercentage / 100;
            discontPrice = _price * _discountPercentage;
            calculatePrice = _price - discontPrice;
            return calculatePrice;

        }
    }
}
