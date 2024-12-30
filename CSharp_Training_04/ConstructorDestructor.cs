using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class ConstructorDestructor
    {
        private int number;

        public ConstructorDestructor(int x)
        {
            number = x;
            Console.WriteLine("Constructor, nuber = " + number);
        }

        ~ConstructorDestructor()
        {
            Console.WriteLine("Destructor");
        }

        public void getNumber()
        {
            Console.WriteLine("Number:" + number);
        }
        public void setNumber(int i)
        {
            number = i;
            Console.WriteLine("Number has been set to " + number);
        }
    }
}
