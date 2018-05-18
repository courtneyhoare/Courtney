using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithoutReturnValueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name: ");
            string enteredName = Console.ReadLine();
            Message(enteredName);

        }// end Main
    static void Message(string name)
        {
            Console.WriteLine("Hello, " + name + ". How are you?");
        }

    }//end program 
}// end namespace 
