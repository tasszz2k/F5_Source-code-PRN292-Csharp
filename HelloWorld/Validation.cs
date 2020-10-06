using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Validation
    {
        public String GetString(int maxLength)
        {
            String str;
            while (true)
            {
                str = Console.ReadLine();
                if (str.Length <= maxLength)
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("Invalid value!\nEnter again:");
                }
            }
        }

        public DateTime GetDateTime()
        {
            String dobStr;
            while (true)
            {

                dobStr = Console.ReadLine();
                DateTime dob;
                if (DateTime.TryParseExact(dobStr,
                                              "dd/MM/yyyy",
                                              null,
                                              System.Globalization.DateTimeStyles.None,
                                              out dob))
                {
                    if (CheckAge(dob))
                    {
                        return dob;
                    }
                }
                Console.WriteLine("Invalid value!\nEnter again:");
            }

        }


        public int GetInt(int min, int max)
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

        bool CheckAge(DateTime dob)
        {
            if(DateTime.Now.Subtract(dob).TotalDays > 18 * 365)
            {
                return true;
            }
            return false;
        }
    }
}

