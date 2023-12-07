using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Rectangle
    {
        // Properties
        private float length;
        private float width;

        // Constructor
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        // Method to calculate and return the area of the rectangle
        public float CalculateArea()
        {
            return length * width;
        }
    }
}
