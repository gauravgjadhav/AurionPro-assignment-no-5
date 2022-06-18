using System;
using ProductApp.Model;
class Program
{
    public static void Main(string[] args)
    {
        Product rice;
        rice = new Product();
        rice.id = 1001;
        rice.name = "Rice";
        rice.price = 86;
        rice.discountPercentage =20;

        Console.WriteLine("Product Id Is : " + rice.id);
        Console.WriteLine("Product Name Is : " + rice.name);
        Console.WriteLine("Product Price IS : "+rice.price+".Rs kg");
        Console.WriteLine("Discount is : "+ rice.discountPercentage+"%");
        Console.WriteLine("Product After Discount Price "+rice.DiscountCalculate()+".Rs");
        Console.WriteLine("_______________________________________");

        Product suger;
        suger = new Product();
        suger.id =1002;
        suger.name = "Suger";
        suger.price = 30;
        suger.discountPercentage =10;
        Console.WriteLine("Product Id Is : " + suger.id);
        Console.WriteLine("Product Name Is : " + suger.name);
        Console.WriteLine("Product Price IS : " + suger.price + ".Rs kg");
        Console.WriteLine("Discount is : " + suger.discountPercentage + "%");
        Console.WriteLine("Product After Discount Price " + suger.DiscountCalculate() + ".Rs");
        Console.WriteLine("_______________________________________");



    }
}