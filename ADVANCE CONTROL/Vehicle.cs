using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVANCE_CONTROL
{
    class Vehicle
    {
        private String name;
        private int numberWheeler;
        private String manufacturer;
        List<Option> listOptions;

        public Vehicle()
        {
        }

        public Vehicle(string name, int numberWheeler, String manufacturer)
        {
            this.name = name;
            this.numberWheeler = numberWheeler;
            this.manufacturer = manufacturer;
            listOptions = new List<Option>();
        }


        public int NumberWheeler
        {
            get => numberWheeler;
            set => numberWheeler = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Option> ListOptions
        {
            get => listOptions;
            set => listOptions = value;
        }

        public string Manufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
    }
}
