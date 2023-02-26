/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP003A
 * Purpose: Object-oriented programming concepts for week 6
 * 
 */

using System.Net.Security;
using System.Xml.Schema;

namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("vehicle1");
            //the line below is one way you can instantiate a class
            Vehicle vehicle1 = new Car();
            vehicle1.Brand = "Tesla"; //you can acess its properties to get/set its value by using the syntax <variable name>.<property>
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();


            PrintSeparator("vehicle2");
            // if the class you are instantiating has a constructor that does not take any parameters
            // then you can simplify the value assignment using the syntax below 
            Vehicle vehicle2 = new Car()
            {
                Brand = "Toyota",
                Model = "Supra",
                NumberOfWheels = 4
            };
            vehicle2.GetInfo();
            Console.WriteLine("But you can still access my Properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");
            
            PrintSeparator("vehicle3");
            // if the class you are instantiating has constructor that takes parameters
            // then you can simplify the value assignment by passing those values
            // using the syntax below
            Vehicle vehicle3 = new Truck("GMC", "Sierra 1500 AT4", 6, 5.5);
            vehicle3.GetInfo();

            PrintSeparator("vehicle4");
            // alternatively, you may use the syntax below, if for some reason your arguments are not in the specific sequence 
            // use the syntax below 
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckmodel: "F-150 Raptor", sizeOfTruckBed: 5.5);
            vehicle4.GetInfo();
        }

        /// <summary>
        /// Just a section separator
        /// </summary>
        /// <param name="sectionName"></param>
        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}