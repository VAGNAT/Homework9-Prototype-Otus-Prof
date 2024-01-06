using Homework9_Prototype_Otus_Prof.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Prototype_Otus_Prof
{
    /// <summary>
    /// The ElectricCar class inherits from Car and complements its characteristics.
    /// </summary>
    internal class ElectricCar : Car, IMyCloneable<ElectricCar>, ICloneable
    {
        internal int BatteryCapacity { get; set; }

        public ElectricCar(string brand, int year, int doors, string engineType, int batteryCapacity) : base(brand, year, doors, engineType)
        {
            BatteryCapacity = batteryCapacity;
        }

        private ElectricCar(ElectricCar other) : base(other.Brand, other.Year, other.Doors, other.EngineType)
        {
            BatteryCapacity = other.BatteryCapacity;
        }

        public override ElectricCar MyClone()
        {
            return new ElectricCar(this);
        }

        public override object Clone() => MyClone();
    }
}
