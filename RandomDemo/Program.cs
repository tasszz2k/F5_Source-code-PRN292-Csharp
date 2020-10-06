using System;

namespace RandomDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] colors = { "white", "blue" };

            Random random =  new Random();
            int index = random.Next(colors.Length);
            Console.WriteLine("Buy bottle color: " + colors[index]);
            Console.ReadKey();
        }
    }
}
