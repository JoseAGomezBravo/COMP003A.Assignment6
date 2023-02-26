using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Interface are contracts that the inheriting class has to implement.
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    internal interface IVehicle
    {
        /// <summary>
        /// This method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();
    }
}
