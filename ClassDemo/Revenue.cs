using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Revenue:Expenditure
    {
        private double totalIncome;
        private double difference;

        public Revenue():base()
        {
        }

        public Revenue(double totalIncome, double difference)
        {
            this.totalIncome = totalIncome;
            this.difference = difference;
        }


        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine();
            Console.Write("Enter the revenue earned annually: ");
            this.totalIncome = Convert.ToDouble(Console.ReadLine());
        }

        public override void DisplayDetail()
        {
            base.DisplayDetail();
            Console.WriteLine();
            Console.WriteLine("{0,-50} {1}", "Total income", this.totalIncome);
            Console.WriteLine();
            this.difference = totalIncome - base.TotalExpenses;
            Console.WriteLine("{0,-50} {1}", "Net Profit", this.difference);

        }
    }
}
