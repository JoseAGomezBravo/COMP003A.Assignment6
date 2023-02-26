using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Truck extends the Vehicle class
    /// </summary>
    internal class Truck : Vehicle
    {
        /***** fields section *****/
        private double _sizeOfTruckbed;


        /***** constructors section *****/
        /// <summary>
        /// Constructors that takes 4 parameters; truckBrand, truckModel, truckNumberOfWheels, and sizeOfTruckBed
        /// It reuses the base class (Vehicle)'s constructor that takes 3 parameters; brand, model, and numberOfWheels
        /// </summary>
        /// <param name="truckBrand">truckBrand</param>
        /// <param name="truckmodel">truckModel</param>
        /// <param name="truckNumberOfWheels">truckNumberOfWheels</param>
        /// <param name="sizeOfTruckBed">sizeOfTruckBed</param>
        public Truck(string truckBrand, string truckmodel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckmodel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        /***** properties section *****/
        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckbed; }
            set { _sizeOfTruckbed = value; }
        }

        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInfo()
        /// Calls the base Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }
    }
}
