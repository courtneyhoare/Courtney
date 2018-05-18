using System;
using System.IO;

namespace ErrorHandlingFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\student\Desktop\Courtney\mydata.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("and the program continues ... ");
        } // end main
    } // end class
} // end namespace
