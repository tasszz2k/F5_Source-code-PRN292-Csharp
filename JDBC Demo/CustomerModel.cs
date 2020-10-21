using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDBC_Demo
{
    class CustomerModel
    {
        private int id;
        private string name;
        private string address;
        private string city;
        private string country;
        private string phone;
        private string zipCode;

        public CustomerModel()
        {
        }

        public CustomerModel(int id, string name, string address, string city, string country, string phone, string zipCode)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.zipCode = zipCode;
        }

        public CustomerModel(string name, string address, string city, string country, string phone, string zipCode)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.zipCode = zipCode;
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

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        public string[] GetListViewItem()
        {
            return new string[] {id.ToString(),name, address, city, country, phone, zipCode };
        }
    }
}
