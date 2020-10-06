using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal =  new  Animal("Mewwww");
            //Console.WriteLine(animal.ToString());
            //Cat cat = new Cat("Tom", 10, 10);
            //Console.WriteLine(cat.ToString());
            ////Cat cat2 = new Animal();
            //Animal tom2 =  new Cat("brother Tom", 1,20);
            
            //cat.Sleep();
            //tom2.Sleep();
            //tom2.Move();

            //Mouse jerry = new Mouse("Jerry", 1);
            //jerry.Sleep();
            //jerry.Move();

            //Animal mouse2 = new Mouse("bro Jerry", 1);
            //mouse2.Sleep();
            //mouse2.Move();

            run2();
        }

        static void run()
        {
            Expenditure expenditure = new Expenditure();
            expenditure.AcceptDetails();
            expenditure.DisplayDetail();

            Revenue revenue = new Revenue();
            revenue.AcceptDetails();
            revenue.DisplayDetail();
        }

        static void run2()
        {
           Worker worker = new Worker();
           worker.input();
           Console.WriteLine(worker.ToString());
        }
    }
}
