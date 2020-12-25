// ALl necessary namspaces have already been used.
// Consider the following piece of code:

using System;


namespace ConsoleApplication2
{

    class Program
    {
        static void Main()
        {
            int x = 42;
            int y = 12;
            int w;
            object o;
            o = x;
            w = y * (int)o;
            Console.WriteLine(w);
            string z = (string)o;
            Console.WriteLine(z);
        }
    }
}

//Which of the following statements is correct