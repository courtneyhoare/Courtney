using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = ""; // This declares that the answer given is going to be a string as the variable string has been declared and also the speech marks have been used
            List<string> bookList = new List<string>(); // This starts off the code knowing that there will be a list envolved 
            Console.WriteLine("Here is your book collection. To add a book, enter A; To exit, enter X."); // This will display to the user on the screen 
           answer = Console.ReadLine(); // This then saves the answer given by the user and it will be saved 
            do { // This is the start of the do while loop which states to keep looping the same part as long as the input from the user is "a" any other letter it will jump out of the loop 
                if (answer == "a") // This is the start of the if statement, which states that if the answer is a then to continue with the loop 
                {
                    Console.WriteLine("Please type the name of the book which you would like to enter: "); // This will be displayed to the user on the screen 
                    bookList.Add(Console.ReadLine()); // This is another part of the list code, which is where this then will recognise the users input and add it to the list when the user asks for the list to be displayed
                    Console.WriteLine("What would you like to do next: a or x."); // This will be displayed to the user on the screen 
                    answer = Console.ReadLine(); // The answer given by the user will then be saved into the system
                }
                } while (answer == "a"); // This the end of the DO WHILE loop, and states that the loop should continue as long as the answer from the user is always an 'a'

                foreach (string b in bookList) // This is the start of the foreach loop, which then tells the system that if another letter is inputted which is not an 'a', then the system should get the list 
                {
                    Console.WriteLine(b); // This then tells the system to display the list of books which the user has inputted into the system on the screen in a list fashion.
                }
        }
    }
}

