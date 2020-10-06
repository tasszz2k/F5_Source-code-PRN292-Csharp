using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0,-10}{1,-10}{2,-10}{3,-10}", "N", "10 * N", "100 * N", "1000 * N"));
            for (int i = 1; i <= 5; i++)
            {
                String str = String.Format("{0,-10}{1,-10}{2,-10}{3,-10}", i, 10 * i, 100 * i, 1000 * i);
                Console.WriteLine(str);                
            }
        }
    }
}
