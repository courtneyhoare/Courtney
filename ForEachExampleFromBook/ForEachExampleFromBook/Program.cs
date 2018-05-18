using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachExampleFromBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int variableName in arrayOfNumbers)
            {
                Console.WriteLine("The value of your variable is:" + variableName);
            }
        }
    }
}
