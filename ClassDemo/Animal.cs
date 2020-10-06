using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Animal
    {
        private String name;

        public Animal()
        {
            Console.WriteLine("- Animal()");
        }

        public Animal(string name)
        {
            this.name = name;
            Console.WriteLine("- Animal(String)");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal move");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}";
        }
    }
}
