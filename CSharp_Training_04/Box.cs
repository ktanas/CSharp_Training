using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
        public double getHeight()
        {
            return height;
        }

        public void setLength(double l)
        {
            length = l;
        }

        public void setWidth(double w)
        {
            width = w;
        }

        public void setHeight(double h)
        {
            height = h;
        }

        public double getVolume()
        {
            return length * width * height;
        }

        public static Box operator+(Box box1, Box box2)
        {
            Box b = new Box();
            b.length = box1.length + box2.length;
            b.width = box1.width + box2.width;
            b.height = box1.height + box2.height;
            return b;
        }

        public static bool operator == (Box a, Box b)
        {
            if (a.length == b.length && a.width == b.width && a.height == b.height)
                return true;
            return false;
        }

        public static bool operator != (Box a, Box b)
        {
            if (a.length != b.length || a.width != b.width || a.height != b.height)
                return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", length, width, height);
        }
    }
}
