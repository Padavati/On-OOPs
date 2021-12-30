using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Shape
    {
        protected string Location="C:";
        public string ToString()
        {
            return string.Empty;
        }
        public double Area()
        {
            return 2.44;
        }
        public double Perimeter()
        {
            return 2.44;
        }
    }
    public class Rectangle:Shape
    {
        protected double side1, side2; 
    }
    public class Circle:Shape
    {
        protected double radius;
    }
    public class Location
    {
        private double x, y;
    }
}
