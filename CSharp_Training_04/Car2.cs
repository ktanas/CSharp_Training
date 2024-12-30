using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    abstract class Car2
    {
        private string brand = "N.A";
        private string model = "N.A";
        private double capacity = 0.0;

        public abstract string Brand
        {
            get;
            set;
        }
        public abstract string Model
        {
            get;
            set;
        }
        public abstract double Capacity
        {
            get;
            set;
        }
    }
    class SuperCar2: Car2
    {
        private string brand;
        private string model;
        private double capacity;

        public override string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public override string Model
        {
            get { return model; }
            set { model = value; }
        }
        public override double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public override string ToString()
        {
            string returnedString = string.Format("Brand: {0}, Model: {1}, Capacity: {2}", brand, model, capacity);
            return returnedString;
        }
    }
}
