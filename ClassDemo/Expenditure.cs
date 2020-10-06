using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Expenditure
    {
        private string[] names = {"Maintainence", "Salary Paid", "Miscellaneous"};
        private double[] numberExpenses = {0,0,0};
        private double totalExpenses;

        public virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the expenditure for the following heads: ");
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write(names[i] +": ");
                numberExpenses[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public virtual void DisplayDetail()
        {
            Console.WriteLine("Expenditure Account");
            Console.WriteLine("{0,-50} {1}", "Expenditure Head", "Amount <$>");
            Console.WriteLine("---------------------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,-50} {1}", names[i], numberExpenses[i]);
                this.totalExpenses += numberExpenses[i];
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("{0,-50} {1}", "Total Expenditure", this.totalExpenses);

        }

        public double TotalExpenses
        {
            get => totalExpenses;
            set => totalExpenses = value;
        }
    }
}
