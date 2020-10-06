using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Worker
    {
        private string name;
        private int id;
        private string designation;
        private double salary;
        private double amount;
        private int tenure;
        Appraisal appraisal = new Appraisal();

        public Worker()
        {
        }

        public bool input()
        {
            try {
                Console.Write("Enter the worker name: ");
                this.name = Console.ReadLine();
                Console.Write("Enter the worker id: ");
                this.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Select the designation <1-3>: ");
                Console.WriteLine("1 - Manager");
                Console.WriteLine("2 - Engineer");
                Console.WriteLine("3 - Technician");
                Console.Write("Enter the choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the years of service: ");
                this.tenure = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice) {
                    case 1:
                        this.designation = "Manager";
                        this.salary = 2000;
                        break;
                    case 2:
                        this.designation = "Engineer";
                        this.salary = 1500;
                        break;
                    case 3:
                        this.designation = "Technician";
                        this.salary = 1000;
                        break;
                }

                this.amount = this.salary + appraisal.calculate(designation, tenure, salary);

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name} \n" +
                   $" {nameof(id)}: {id}\n " +
                   $"{nameof(designation)}: {designation}\n " +
                   $"{nameof(salary)}: {salary}\n " +
                   "Bonus: " + appraisal.calculate(designation, tenure, salary) + "\n" +
                   $"{nameof(amount)}: {amount}\n ";
                ;
        }

        public string Name {
            get => name;
            set => name = value;
        }

        public int Id {
            get => id;
            set => id = value;
        }

        public string Designation {
            get => designation;
            set => designation = value;
        }

        public double Salary {
            get => salary;
            set => salary = value;
        }

        public double Amount {
            get => amount;
            set => amount = value;
        }

        public int Tenure {
            get => tenure;
            set => tenure = value;
        }

        public Appraisal Appraisal {
            get => appraisal;
            set => appraisal = value;
        }
    }
}
