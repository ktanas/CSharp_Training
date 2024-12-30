using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class EventTesting
    {
        public int value;
        public delegate void NumberManipulationhandler();
        public event NumberManipulationhandler ChangeNumber;

        protected virtual void OnNumberChanged()
        {
            if (ChangeNumber != null)
                ChangeNumber();
            else
                Console.WriteLine("Event has happened!");
        }
        public EventTesting(int i)
        {
            SetValue(i);
        }
        public void SetValue(int i)
        {
            if (value != i)
            {
                value = i;
                OnNumberChanged();
            }
        }
    }
}
