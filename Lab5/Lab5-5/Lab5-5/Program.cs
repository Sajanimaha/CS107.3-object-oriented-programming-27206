using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class ArrayOperations
        {
            public static void PerformArrayOperations(int[] array)
            {
                int min = array[0];
                int max = array[0];
                int sum = 0;

                // Finding minimum, maximum, and sum of the array
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                        min = array[i];

                    if (array[i] > max)
                        max = array[i];

                    sum += array[i];
                }

                double average = (double)sum / array.Length;

                // Reversing the order of values in the array
                Array.Reverse(array);

                // Printing the results
                Console.WriteLine("Minimum value: " + min);
                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Average value: " + average);
                Console.WriteLine("Reversed order of values: ");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                int[] array = new int[10];
                Console.WriteLine("Enter 10 values for the array:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Value {0}: ", i + 1);
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Performing array operations...");
                ArrayOperations.PerformArrayOperations(array);
            }
    }
}
