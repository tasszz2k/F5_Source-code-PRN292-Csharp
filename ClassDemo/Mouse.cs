using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Mouse: Animal
    {
        private int weight;

        public Mouse():this(100)
        {
        }

        public Mouse(int weight)
        {
            this.weight = weight;
        }


        public Mouse(string name, int weight) : base(name)
        {
            this.weight = weight;
        }

        public override void Move()
        {
            Console.WriteLine("Mouse move...");
        }

        public void Sleep()
        {
            Console.WriteLine("Mouse Sleep...");
        }
    }
}
