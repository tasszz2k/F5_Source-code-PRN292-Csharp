using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10_1
{
    class CustomerModel
    {
        private int id;
        private string name;
        private DateTime dob;
        private bool gender;
        private string address;

        public CustomerModel()
        {
        }

        public CustomerModel(int id, string name, DateTime dob, bool gender, string address)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
        }

        public CustomerModel(string name, DateTime dob, bool gender, string address)
        {
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Dob
        {
            get => dob;
            set => dob = value;
        }

        public bool Gender
        {
            get => gender;
            set => gender = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }
    }
}
