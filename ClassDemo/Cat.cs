using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Cat:Animal
    {
        private int age;
        private int height;

        public Cat():base()
        {
            age = 0;
            height = 0;
            Console.WriteLine("-Cat()");
        }

        public Cat(int age, int height)
        {
            this.age = age;
            this.height = height;
            Console.WriteLine("- Cat(int, int");

        }

        public Cat(string name, int age, int height) : base(name)
        {
            this.age = age;
            this.height = height;
            Console.WriteLine("- Cat(String, int, int");
        }

        public void Say()
        {
            Console.WriteLine("Mewwww Mewwww");
        }

        public override void Move()
        {
            Console.WriteLine("Cat move....");
        }

        public  void Sleep()
        {
            Console.WriteLine("Cat Sleep...");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(age)}: {age}, {nameof(height)}: {height}";
        }
    }
}
