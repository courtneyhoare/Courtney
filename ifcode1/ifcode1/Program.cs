using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifcode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            Random rndm = new Random();    // Random number generator
            int number = rndm.Next(6);  // Random number generator 
      
            do
            {
                Console.WriteLine("I am thinking of a number, between 1 and 10, take a guess and see whether you can get it.");
                response = Convert.ToInt32(Console.ReadLine());

                if (response == number)
                {
                    Console.WriteLine("Well done, that is correct!");
                }
                else if (response < number)
                {
                    Console.WriteLine(" Thats too small, try again..");
                }
                else if (response > number)
                {
                    Console.WriteLine("Thats too big, try again..");  
                }
            } while (response != number); //end loop 
                  Console.ReadLine();
            
        }//end main
    }//end class
}//end namespace
