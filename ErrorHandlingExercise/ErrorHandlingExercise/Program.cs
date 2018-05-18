using System;
using System.IO;

namespace ErrorHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = { 1,  2,  3 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    // Convert.ToInt32(Console.ReadLine());
                    total += numbers[i];
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" Error Message:");
            }
            Console.WriteLine("works");
            }
        }
    }

