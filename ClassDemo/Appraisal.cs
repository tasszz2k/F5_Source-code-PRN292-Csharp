using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Appraisal
    {
        private string desination;
        private int tenure;
        private double salary;
        private double bonus;

        public Appraisal()
        {
        }

        public Appraisal(string desination, int tenure, double salary)
        {
            this.desination = desination;
            this.tenure = tenure;
            this.salary = salary;
        }

        public double calculate(string desination, int tenure, double salary)
        {
            if (desination.Equals("Engineer")) {
                if (tenure < 5) {
                    this.bonus = salary * 1.5;
                }
                else {
                    this.bonus = salary * 2;
                }
            }else if (desination.Equals("Technician")) {
                if (tenure < 3) {
                    this.bonus = salary * 0.25;
                }
                else if (tenure < 5) {
                    this.bonus = salary * 0.5;
                }
                else {
                    this.bonus = salary * 2;
                }
            }

            return this.bonus;

        }


        public string Desination {
            get => desination;
            set => desination = value;
        }

        public int Tenure {
            get => tenure;
            set => tenure = value;
        }

        public double Salary {
            get => salary;
            set => salary = value;
        }

        public double Bonus {
            get => bonus;
            set => bonus = value;
        }
    }
}
