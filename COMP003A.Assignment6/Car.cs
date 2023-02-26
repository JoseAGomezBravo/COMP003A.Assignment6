using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Car extends the Vehicle class
    /// </summary>
    internal class Car : Vehicle
    {
        /***** Constructors section *****/
        // by default, a class has a default constructor that does not take any parameters
        // therefore, you do not have to explicitly create one


        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicles's definition for GetInfo()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information");
        }
    }
}
