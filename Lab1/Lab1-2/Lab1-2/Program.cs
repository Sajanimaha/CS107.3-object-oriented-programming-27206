using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = CalculateCircleArea(radius);

            Console.WriteLine("The area of the circle is:");

            Console.ReadLine();
        }
        static double CalculateCircleArea(double radius)
        {
            double area = Math.PI * radius;
            return area;
        }
    }
}
