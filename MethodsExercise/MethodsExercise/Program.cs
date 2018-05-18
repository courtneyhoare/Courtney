using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string signChoice = "";

            Console.WriteLine("This program is going to complete simple arithmetic for you.");
            Console.WriteLine("This will only occur if you input two numbers and a sign,");
            Console.WriteLine("Please enter your first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your sign (+ - / *)");
            signChoice = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            switch (signChoice)
            {
                case "+":
                    total = AddNumbers(firstNum, secondNum);
                    break;
                case "-":
                    total = SubtractNumbers(firstNum, secondNum);
                    break;
                case "*":
                    total = TimesNumbers(firstNum, secondNum);
                    break;
                case "/":
                    total = DivideNumbers(firstNum, secondNum);
                    break;
                default:
                    break;
            }
            Console.WriteLine(total);
        }//end main

        static int AddNumbers(int first, int second)
        {
            int total = first + second;
            return total;
        }
        static int SubtractNumbers(int first, int second)
        {
            int total = first - second;
            return total;
        }
        static int TimesNumbers(int first, int second)
        {
            int total = first * second;
            return total;
        }
        static int DivideNumbers(int first, int second)
        {
            int total = first / second;
            return total;
        }//static
    } //class
        }//namespace

    

