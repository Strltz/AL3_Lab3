using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class Car : IEquatable<Car>
    {
        public string Name { get; }
        public string Engine { get; }
        public int MaxSpeed { get; }

        public Car(string name, string engine, int speed)
        {
            Name = name;
            Engine = engine;
            MaxSpeed = speed;
        }

        public Car() { }

        public override string ToString()
        {
            return Name;
        }

        public bool Equals(Car other_car)
        {
            if (ReferenceEquals(null, other_car))
            {
                return false;
            }
            return (other_car.GetHashCode == this.GetHashCode &&
                other_car.Engine == Engine && other_car.MaxSpeed == MaxSpeed);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
