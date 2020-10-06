using System;

namespace Exception_Handling
{
    public delegate void MyDelegate(); //declaring a delegate
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate del1 = UsaFormula;
            //Console.WriteLine(del1(10));
            //MyDelegate del2 = VietnamFormula;
            //Console.WriteLine(del2(10));
            //Delegate del3 = del1 + del2;

            MyDelegate del1 = Display;
            MyDelegate del2 = Display;
            del1();
            del1 += del2;
            del1();

        }

        public static int GetInt(int min, int max)
        {
            int num;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= min && num <= max)
                    {
                        return num;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid value!\nEnter again:");
                }
            }
        }

        public static void Display()
        {
            Console.WriteLine("hello");
        }

        public static float UsaFormula(float salary)
        {
            return 10 * salary / 100;
        }

        public static float VietnamFormula(float salary)
        {
            return 5 * salary / 100;
        }

        public static float DefaultFormula(float salary)
        {
            return 7 * salary / 100;
        }


    }
}
