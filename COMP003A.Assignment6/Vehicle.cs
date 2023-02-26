using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstract describe a contract but does not provide a full implemenation of the contract
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    abstract class Vehicle : IVehicle 
    {
        /***** Fields section *****/
        // note: in almost all programming languages, you would typically pair a field with a property
        // this is not a requirement in C# because it offers auto-property
        private string _brand;
        private string _model;
        private int _numberOfWheels;


        /***** Constructors section *****/
        /// <summary>
        /// Default Constructor 
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor that takes three parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name="brand">String input for brand name</param>
        /// <param name="model">String input for model name</param>
        /// <param name="numberOfWheels">Integer input for number of wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }


        /***** Properties Section *****/

        /// <summary>
        /// Retrieve/Store Brand Information
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/Store Model Information
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retrieve/Store Number of Wheels Information
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        /// <summary>
        /// Prints the Brand, Model, and Number of Wheels information
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }
}
