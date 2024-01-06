using Homework9_Prototype_Otus_Prof.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Prototype_Otus_Prof
{
    /// <summary>
    /// Basic vehicle class.
    /// </summary>
    internal class Vehicle : IMyCloneable<Vehicle>, ICloneable
    {
        internal string Brand { get; set; }
        internal int Year { get; set; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        private Vehicle(Vehicle other)
        {
            Brand = other.Brand;
            Year = other.Year;
        }

        public virtual Vehicle MyClone()
        {
            return new Vehicle(this);
        }

        public virtual object Clone() => MyClone();
    }
}
