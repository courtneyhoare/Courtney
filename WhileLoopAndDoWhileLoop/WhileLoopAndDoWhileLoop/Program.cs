using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopAndDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string answer = "a stamp";
            Console.WriteLine("I have got a riddle for you,"); //This will display as text on the screen
            Console.WriteLine("I travel all around the world, but always stay in my corner, What am I?"); // This will display as text on the screen 
            string answer1 = Console.ReadLine(); // This will save the users input as variable Answer1

            while (answer1 != "a stamp") // States that any answer other than a stamp will be incorrect
            { // This is then the start of the loop
                Console.WriteLine("Try Again?"); // If the incorrect answer is inputted then it will display Try Again
                Console.WriteLine("I travel all around the world, but always stay in my corner, What am I?"); // This will then display the question again if they get the answer wrong 
                answer1 = Console.ReadLine(); // This will then save and display the answer which is given by the user 
            } // This is the end of the loop, but they can only get out of the loop if they get the answer correct
            Console.WriteLine("Well Done, that is correct!"); // Still in the While loop, if they then get the answer correct, this will then display well done when they get the answer correct 
            //string response = "a bed"
            Console.WriteLine("I have another riddle for you,");//This will display as text on the screen
            string response1 = ""; // This sets the system to state that their response is going to be a string 
            do // Start of the Do While Loop 
            {
                Console.WriteLine("What has one head, one foot and four legs?");// This will display as text on the screen 
                response1 = Console.ReadLine();// This will then save and display the answer which is given by the user 
            } while (response1 != "a bed"); // This states that response1 must be a bed or the response will be incorrect
            Console.WriteLine("Well Done, that is also correct!");// Still in the While loop, if they then get the answer correct, this will then display well done when they get the answer correct 
        } // static void
              } // class
        } //namespace

