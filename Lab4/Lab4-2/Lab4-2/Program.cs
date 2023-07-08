using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues finder = new FindValues();
            double area = finder.FindArea(radius);
            double circumference = finder.FindCircumference(radius);

            Console.WriteLine("Area of the circle: {0}", area);
            Console.WriteLine("Circumference of the circle: {0}", circumference);

            Console.ReadLine();
        }
    }

    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
