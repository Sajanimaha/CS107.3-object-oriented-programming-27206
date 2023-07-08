using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the kilometer value:");
            double kilometer = Convert.ToDouble(Console.ReadLine());

            ConverValues converter = new ConverterValue();
            double meter = converter.kilometerToMeter(kilometer);

            Console.WriteLine("The equivalent meter value is:" + meter);

            Console.ReadLine();
        }
    }
}
