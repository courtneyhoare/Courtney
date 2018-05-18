using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingBookExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 0;
            int result = 0;

            try
            {
                result = firstNumber / secondNumber; 
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("{0} divided by {1} equals {2}.", firstNumber, secondNumber, result);
            }
        }
    }
}
