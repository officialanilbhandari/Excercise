using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car (string carbrand, int caryear, float carprice)
        {
            brand = carbrand;
            year = caryear;
            price = carprice;

        }
        public void Display()
        {
            Console.WriteLine($"Brand:{brand}");
            Console.WriteLine($"Brand:{year}");
            Console.WriteLine($"Brand:{price}");
        }
    }
}
