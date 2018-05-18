using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndFieldsExercise
{
    public class Car
    {
        public string model = "";
        public string make = "";
        public int price;
        public bool sold;

        public static int numberOfCars;
    }
    
          
    
    class Program
    {
        static void Main(string[] args)
        {
            Car.numberOfCars = 0;

            Car car1 = new Car();
            car1.make = "Ford";
            car1.model = "Fiesta";
            car1.price = 13350 ;
            car1.sold = false;
            Car.numberOfCars++;
            Car car2 = new Car();
            car2.make = "Vauxhall";
            car2.model = "Corsa 1.2";
            car2.price = 1200;
            car2.sold = true;
            Car.numberOfCars++;
            Car car3 = new Car();
            car3.make = "Honda";
            car3.model = "Civic";
            car3.price = 2500;
            car3.sold = false;
            Car.numberOfCars++;

            Console.WriteLine("The details of this car are: ");
            Console.WriteLine(" Make: " + car1.make);
            Console.WriteLine(" Model: " + car1.model);
            Console.WriteLine(" Price: " + car1.price);
            Console.WriteLine(" Sold? " + car1.sold);
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make: " + car2.make + " Model: " + car2.model + " Price: " + car2.price + " Sold? " + car2.sold);
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make: " + car3.make + " Model: " + car3.model + " Price: " + car3.price + " Sold? " + car3.sold);
        }
       
    }//class
}//namespace
