using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class circle
    {
        public double radius;
        public void setRadius(double rad)
        {
            radius = rad;

        }
        public double getCircumference()
        {

            return radius * 2;
        }
        public double getArea()
        {

            return ((radius * radius) * Math.PI);
            
        }
    }


    class CircleApp
    {
        static void Main(string[] args)
        {

            circle circle1 = new circle();
            Console.WriteLine("enter the radius");
            double entry = double.Parse(Console.ReadLine());
            circle1.setRadius(entry);
            double circum = circle1.getCircumference();
            double area = circle1.getArea();
            Console.WriteLine("area:"+area);
            Console.WriteLine("Circumference:"+circum);
        }
    }
}
