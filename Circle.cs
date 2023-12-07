using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Circle: Shape
    {
        // Properties
        private float radius;

        // Constructor
        public Circle(float radius)
        {
            this.radius = radius;
        }

        // Override the CalculateArea method to calculate and return the area of a circle
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }
    }
}
