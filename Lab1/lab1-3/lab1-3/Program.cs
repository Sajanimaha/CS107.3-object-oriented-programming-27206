using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine("the sum of number is:" + sum);

            Console.ReadLine();
        }
    }
}
