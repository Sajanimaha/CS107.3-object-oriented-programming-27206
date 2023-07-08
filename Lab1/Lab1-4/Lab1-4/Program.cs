using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tax rate(in desimal form):");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double salaryAfterTax = salary * (1 - taxRate);

            Console.WriteLine("salary after tax:" + salaryAfterTax);

            Console.ReadLine();
        }
    }
}
