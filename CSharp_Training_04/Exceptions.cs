using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class Exceptions
    {
        public int DivideByZero(int x)
        {
            try
            {
                return x / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            finally
            {
                Console.WriteLine("This is always written, regardless of possible exceptions");
            }
            return 0;
        }
    }

    class MyOwnException : ApplicationException
    {
        public MyOwnException(string text): base(text)
        {
        }
    }

    public class Age
    {
        int age = 0;

        public void checkAge(int age)
        {
            if (age < 0)
            {
                throw (new Exception("Age cannot be less than 0"));
            }
            else
            {
                Console.WriteLine("Age is correct: " + age);
            }
        }

        public void checkAge2(int age)
        {
            if (age < 0)
            {
                throw (new MyOwnException("Age cannot be less than 0"));
            }
            else
            {
                Console.WriteLine("Age is correct: " + age);
            }
        }
    }
}
