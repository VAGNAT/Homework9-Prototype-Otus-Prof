using Homework9_Prototype_Otus_Prof.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Prototype_Otus_Prof
{
    /// <summary>
    /// The Car class inherits from Vehicle and adds its characteristics.
    /// </summary>
    internal class Car : Vehicle, IMyCloneable<Car>, ICloneable
    {
        internal int Doors { get; set; }
        internal string EngineType { get; set; }

        public Car(string brand, int year, int doors, string engineType) : base(brand, year)
        {
            EngineType = engineType;
            Doors = doors;
        }

        private Car(Car other) : base(other.Brand, other.Year)
        {
            Doors = other.Doors;
            EngineType = other.EngineType;
        }

        public override Car MyClone()
        {
            return new Car(this);
        }

        public override object Clone() => MyClone();
    }
}
