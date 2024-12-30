using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class DelegateOnBoardComputerEvent
    {
        public delegate void CarComputerHandler(string info);
        public event CarComputerHandler CarComputerEventLog;
        public void LogProcess()
        {
            string information = "OK";
            CarComputer cc = new CarComputer(80, 12);
            int t = cc.GetTemperature();
            int p = cc.GetPressure();

            if (t > 70 || p > 15)
                information = "Do thorough review of the car!";

            OnCarsComputerEventLog("Writing information: \n");
            OnCarsComputerEventLog("Temperature: " + t + ", Pressure: " + p);
            OnCarsComputerEventLog("Information: " + information);
        }
        protected void OnCarsComputerEventLog(string information)
        {
            if (CarComputerEventLog != null)
                CarComputerEventLog(information);
        }
    }
}
