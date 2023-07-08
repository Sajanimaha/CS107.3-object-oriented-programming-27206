using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lass ConvertValues
{
                public void KilometerToMeter()
                {
                    Console.Write("Enter a value in kilometers: ");
                    double kilometers = double.Parse(Console.ReadLine());

                    double meters = kilometers * 1000;

                    Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
                }
            }

class Program
        {
            static void Main(string[] args)
            {
                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter();

                Console.ReadLine();
            }
        }
    }
    }
}
