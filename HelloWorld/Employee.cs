using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Employee
    {
        //CTRL + R --> CTRL + E
        private int id;
        private string name;
        private string designation="";
        private DateTime birthDate;
        private char gender;
        private byte yearsServed;
        private double bonus=0, salary=0, taxAmount=0, netSalary=0;

        private Validation validation = new Validation();
        public Employee()
        {
        }

        public Employee(int id, string name, string designation, DateTime birthDate, char gender, byte yearsServed, double bonus, double salary, double taxAmount, double netSalary)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.YearsServed = yearsServed;
            this.Bonus = bonus;
            this.Salary = salary;
            this.TaxAmount = taxAmount;
            this.NetSalary = netSalary;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public char Gender { get => gender; set => gender = value; }
        public byte YearsServed { get => yearsServed; set => yearsServed = value; }
        public double Bonus { get => bonus; set => bonus = value; }
        public double Salary { get => salary; set => salary = value; }
        public double TaxAmount { get => taxAmount; set => taxAmount = value; }
        public double NetSalary { get => netSalary; set => netSalary = value; }

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(name)}: {name}, {nameof(designation)}: {designation}, {nameof(birthDate)}: {birthDate}, {nameof(gender)}: {gender}, {nameof(yearsServed)}: {yearsServed}, {nameof(bonus)}: {bonus}, {nameof(salary)}: {salary}, {nameof(taxAmount)}: {taxAmount}, {nameof(netSalary)}: {netSalary}, {nameof(validation)}: {validation}";
        }

        public void CreateNew()
        {
            Console.WriteLine("Input ID: ");
            this.id = validation.GetInt(0, 999999);
            Console.WriteLine("Input Name:");
            this.name = validation.GetString(40);
            Console.WriteLine("Input birth date:");
            this.birthDate = validation.GetDateTime();
            Console.WriteLine("Input Gender[F/M]:");
            this.gender = Console.ReadKey().KeyChar;
        }

    }
}
