using System;

namespace ComputesEX
{
    class Program
    {
        static void Main(string[] args)
        {
            double ex = 0, E = 0.00000000001, num1 = 1.0,num2 = 1.0;
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; num1 > E; i++)
            {
                ex += num1;
                num2 = num1 * ((double)x / i);
                num1 = num2;
            }
           

            Console.WriteLine(ex);
        }
    }
}
