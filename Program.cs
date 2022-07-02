using System;
using ProductApp.Model;
class Program
{
    public static void Main(string[] args)
    {
        Product rice;
        rice = new Product();
        rice.Id=1001;
        rice.Name = "Rice";
        rice.Price=30;
        rice.DiscountPercentage = 2;
        PrintDetails(rice); 

        Product suger;
        suger = new Product();
        suger.Id=1002;
        suger.Name = "Suger";
        suger.Price = 30;
        suger.DiscountPercentage =10;
        PrintDetails(suger);
    }
    public static  void PrintDetails(Product productPrint)
    {
        Console.WriteLine("Product Id Is : " + productPrint.Id);
        Console.WriteLine("Product Name Is : " + productPrint.Name);
        Console.WriteLine("Product Price IS : " + productPrint.Price + ".Rs kg");
        Console.WriteLine("Discount is : " + productPrint.DiscountPercentage + "%");
        Console.WriteLine("Product After Discount Price " + productPrint.DiscountCalculate() + ".Rs");
        Console.WriteLine("_______________________________________");

    }
}