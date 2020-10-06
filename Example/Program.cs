using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            FahrenheitToCelsius();
        }


        static void FahrenheitToCelsius()
        {
            float degreeC, degreeF;
            Console.WriteLine("Enter degreeF: ");
            degreeF = float.Parse(Console.ReadLine());
            //Console.WriteLine(degreeF);
            degreeC = ((float)5 / 9) * (degreeF - 32);
            Console.WriteLine(degreeC);
        }
    }
}
