﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    [DebugInfo(473, "Jan Kowalski", "10/11/2024", message = "Unassigned value")]
    //[DebugInfo(5601, "Jan Kowalski", "08/11/2024", message = "Wrong returned type")]
    class Rectangle2
    {
        protected double length;
        protected double width;
        public Rectangle2(double l, double w)
        {
            length = l;
            width = w;
        }
        [DebugInfo(1, "Anna Nowak", "05/04/2022", message = "Wrong returned type")]
        public double getArea()
        {
            return length * width;
        }
    }
}
