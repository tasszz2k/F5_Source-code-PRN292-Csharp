using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_EX2
{
    class Product
    {
        private int id;
        private String name;
        private int price;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
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

        public int Price
        {
            get => price;
            set => price = value;
        }
    }
}
