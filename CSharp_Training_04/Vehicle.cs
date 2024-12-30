using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class Vehicle
    {
        protected int id;

        public virtual void startEngine()
        {
            Console.WriteLine("Starting engine of a vehicle: id = " + id);

        }
    }

    public class Airplane:Vehicle
    {
        public void setId(int x)
        {
            id = x;
        }

        //override
        public override void startEngine()
        {
            Console.WriteLine("Starting engine of a car: id = " + id);
        }
    }

    public class Motorcycle:Vehicle
    {
        public virtual void setId(int x)
        {
            id = x;
        }

    }

    public class Yamaha:Motorcycle
    {
        public override void setId(int x)
        {
            id = x+1;
        }
    }

    public class YZ450F:Yamaha
    {
        public void writeId()
        {
            Console.WriteLine("id=" + id);
        }
    }

}
