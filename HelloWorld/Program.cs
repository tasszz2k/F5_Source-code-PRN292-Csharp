using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Employee employee = new Employee();
            employee.CreateNew();

            Validation validation = new Validation();
            //menu
            Console.WriteLine("Select designation <choose the number> :");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. System Analyst");
            Console.WriteLine("3. Developer");
            Console.WriteLine("4. Accountant");
            Console.WriteLine("Enter your choice: ");
            int choice = validation.GetInt(1, 4);
            switch (choice)
            {
                case 1:
                    employee.Designation = "Manager";
                    employee.Salary = 21346; ;
                    break;
                case 2:
                    employee.Designation = "System Analyst";
                    employee.Salary = 16729;
                    break;
                case 3:
                    employee.Designation = "Developer";
                    employee.Salary = 14525;
                    break;
                case 4:
                    employee.Designation = "Accountant";
                    employee.Salary = 13215;
                    break;

            }


            //-----------------------------------------//
            Console.WriteLine("Enter the tenure in years: ");
            employee.YearsServed = (byte)validation.GetInt(0, 99);
            //salary
          
            if (employee.YearsServed >= 3)
            {
                if (employee.Salary > 20000)
                {
                    employee.Bonus = employee.Salary * 0.09;
                }
                else if (employee.Salary > 14000 && employee.Salary <= 20000)
                {

                    employee.Bonus = employee.Salary * 0.05;
                }
                else
                {
                    employee.Bonus = employee.Salary * 0.02; ;
                }
            }

            employee.TaxAmount = employee.Salary * 33 / 100;
            employee.NetSalary = employee.Salary - employee.TaxAmount;

            //---------------- display -----------//
            Console.WriteLine(employee.ToString());
        }
    }
}
