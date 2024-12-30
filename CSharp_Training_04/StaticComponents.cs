using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class StaticComponents
    {
        public static int x;
        public int y;

        public void zeroX()
        {
            x = 0;
        }

        public void increaseX()
        {
            x++;
        }

        public int getX()
        {
            return x;
        }

        public static int getX2()
        {
            // incorrect - cannot access non-static fields and methods from a static method code
            //y = 2;
            //return y; 
            //return getX();

            return x;
        }
    }
}
