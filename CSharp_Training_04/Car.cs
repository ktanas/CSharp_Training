using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class Car
    {
        private string brand = "N.A";
        private string model = "N.A";
        private double capacity = 0.0;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public string Model { get { return model; } set { model = value; } }

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public override string ToString()
        {
            string returnedString = string.Format(
                                        "Brand: " + brand + 
                                        ", model: " + model + 
                                        ", capacity: " + capacity);
            return returnedString;
        }
    }

}
