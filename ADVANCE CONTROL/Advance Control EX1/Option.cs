using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Control_EX1
{
    class Option
    {
       
        private int make;
        private int engineCapacity;
        private int price;


        public Option()
        {
        }

        public Option( int make, int engineCapacity, int price)
        {
       
            this.make = make;
            this.engineCapacity = engineCapacity;
            this.price = price;
           
        }


        public int Make
        {
            get => make;
            set => make = value;
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
