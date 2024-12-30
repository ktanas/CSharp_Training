using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class CarComputer
    {
        private int temperature;
        private int pressure;
        public CarComputer(int temp, int press)
        {
            temperature = temp;
            pressure = press;
        }
        public int GetTemperature()
        {
            return temperature;
        }
        public int GetPressure()
        {
            return pressure;
        }
    }
}
