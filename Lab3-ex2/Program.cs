using System;

namespace Lab3_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            object objProductID, objProductName, objPrice, objQuantity;

            Console.WriteLine("Product Details:");
            Console.Write("Product ID: ");
            objProductID = Console.ReadLine(); 
            Console.Write("Product Name: ");
            objProductName = Console.ReadLine(); 
            Console.Write("Price: $");
            objPrice = Console.ReadLine();
            Console.Write("Quantity: ");
            objQuantity = Console.ReadLine();
            int ProductID = Convert.ToInt32(objProductID);
            string ProductName = Convert.ToString(objProductName);
            double Price = Convert.ToDouble(objPrice);
            int Quantity = Convert.ToInt32(objQuantity);

            double amtPayable = Quantity * Price;

            Console.WriteLine("Amt Payble " + String.Format("{0:0.00}", amtPayable));

        }
    }
}
