using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class NumberOperations
    {
        public void exchange1(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void exchange2(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void getNumberOut(out int x)
        {
            int i = 123;
            x = i;
        }

        public void getTwoNumbersOut(out int x, out int y)
        {
            Console.WriteLine("Enter first number to get out:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number to get out:");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
