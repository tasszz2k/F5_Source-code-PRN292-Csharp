using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilmManagement
{
    class Validation
    {

        public String getString(int max)
        {
            while (true)
            {
                String str = Console.ReadLine();
                if (str.Length > max)
                {
                    Console.WriteLine("Invalid input!\nEnter again: ");
                }

                return str;
            }
        }

        public Double getDouble(Double min, Double max)
        {
            while (true)
            {
                try
                {
                    Double number = Convert.ToDouble(Console.ReadLine());
                    if (number < min || number > max)
                    {
                        throw new Exception();
                    }

                    return number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input!\nEnter again: ");
                }
            }
        }
    }
}
