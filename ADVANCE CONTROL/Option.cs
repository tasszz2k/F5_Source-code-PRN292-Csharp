using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVANCE_CONTROL
{
    class Option
    {
       
        private int number;
        private int engineCapacity;
        private int price;


        public Option()
        {
        }

        public Option( int number, int engineCapacity, int price)
        {
       
            this.number = number;
            this.engineCapacity = engineCapacity;
            this.price = price;
           
        }


        public int Number
        {
            get => number;
            set => number = value;
        }

        public int EngineCapacity
        {
            get => engineCapacity;
            set => engineCapacity = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }


    }
}
