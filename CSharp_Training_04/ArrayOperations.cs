using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class ArrayOperations
    {
        public double computeAverage(int[] arr)
        {
            int i = arr.Count();
            int sum = 0;
            double avg;

            foreach (var x in arr)
                sum += x;

            avg = sum / i;
            return avg;
        }

        public int parametricSum(params int[] arr)
        {
            int result = 0;
            foreach (var element in arr)
                result += element;

            return result;
        }
    }
}
