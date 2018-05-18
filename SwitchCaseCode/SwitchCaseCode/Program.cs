using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my favourite football team?");
            Console.WriteLine(" Arsenal");
            Console.WriteLine(" Manchester United");
            Console.WriteLine(" West Ham");
            Console.WriteLine(" West Brom");
            string response = Console.ReadLine();
            switch (response)  
            {
                case "Arsenal":
                    Console.WriteLine("Nope, they're rubbish,");
                    break;
                case "Manchester United":
                    Console.WriteLine("Nope, they're rubbish,");
                    break;
                case "West Ham":
                    Console.WriteLine("Congrats, you are correct, good choice,");
                    break;
                case "West Brom":
                    Console.WriteLine("Nope, they're rubbish,");
                    break;
                default:
                    break;
            }
        }
    }
}
