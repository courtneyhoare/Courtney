using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeachLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
         
            for (int i = 0 ; i < sevenDwarves.Length; i++) 
            {
                Console.WriteLine("Here is your dinner " + sevenDwarves[i]);
         }
            foreach (string drink in sevenDwarves )
            {
                Console.WriteLine("Here is your drink " + drink); // This will then display the seven dwarves names and with the text beforehand. the 'drink' part is the new variable needed which will now stand for the seven dwarves array
            }
            foreach (string meal in sevenDwarves)
            {
                Console.WriteLine("What would you like in your meal,  " + meal + "?");
                string action = Console.ReadLine();
                Console.WriteLine("So you would like " +  action +  meal);
            }
            } // static 
            } // class  
        }//namespace
    

