using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        public int id = 0;
        public string name = null;
        public int price = 0;
        public double discountPercentage =0;
        public double discontPrice=0;
        public double calculatePrice=0;
        
        public double DiscountCalculate()
        {
            discountPercentage = discountPercentage / 100;
            discontPrice = price * discountPercentage;
            calculatePrice = price - discontPrice;
            return calculatePrice;

        }
    }
}
