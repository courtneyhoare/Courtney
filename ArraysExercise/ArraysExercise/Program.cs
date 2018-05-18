using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0;
            Console.WriteLine("Please enter 5 numbers to be averaged, ensuring you press the enter button after each number entered: ");
            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            { 
                Console.WriteLine("Please enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            answer = ((double)(numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5);
            Console.WriteLine("The average of your 5 numbers is  " + answer);
            } 
        }
    }

