using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class MyGenericArray<T>
    {
        private int[] array;
        private T[] genericArray;

        public MyGenericArray(int size)
        {
            array = new int[size + 1];
            genericArray = new T[size + 1];
        }
        public int getItem(int index)
        {
            return array[index];
        }
        public T getGenericItem(int index)
        {
            return genericArray[index];
        }
        public void setValue(int index, int value)
        {
            array[index] = value;
        }
        public void setGenericValue(int index, T value)
        {
            genericArray[index] = value;
        }
    }
}
