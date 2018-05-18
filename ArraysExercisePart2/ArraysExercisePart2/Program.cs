using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercisePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0; // This will allow the answer to be outputted as a decimal number if it needed to be a decimal 
            int[] numbers = { 1, 2, 3, 4, 5 }; // This is the start of the array, which states that there will be 5 numbers in this whole array 
            Console.WriteLine("Please enter 5 numbers to be averaged, ensuring you press the enter button after each number entered: "); // Will be displayed on the screen to the user 
            for (int i = 0; i < 5; i++) // This is the for loop for the first main part of the program
            {
                Console.WriteLine("Please enter a number: "); //  This will be displayed on the screen to the user 
                numbers[i] = Convert.ToInt32(Console.ReadLine()); // This then allows the system to understand that, the users input will have to be put into the system will have to be recognised as integers 
            }
            for (int i = 0; i < 5; i++) // This is the start of another for loop/the start of an array again
            {
                answer = answer + numbers[i]; // This is where the answer is getting saved and then it is added to the numbers array 
            }
            answer = answer / 5; // This is where the answers are then divided by 5 to get the average result, which was the purpose for the exercise.
            Console.WriteLine("The average of your 5 numbers is  " + answer); //  This is where the results for the exercise will be displayed, by using the already stated variables.
            }
        }
    }
