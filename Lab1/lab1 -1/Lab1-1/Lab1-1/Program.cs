using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            String name = Console.ReadLine();

            Console.Write("Enter your batch:");
            String batch = Console.ReadLine();

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Batch:" + batch);

            Console.ReadLine();
        }
    }
}
