using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class CarsCatalog
    {
        public List<Car> all_cars { get; }

        public CarsCatalog(List<Car> cars)
        {
            all_cars = cars;
        }
        
        public string this[int index]
        {
            get
            {
                return all_cars[index].Name + " " + all_cars[index].Engine;
            }
        }
    }
}
