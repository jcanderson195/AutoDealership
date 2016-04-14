using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class Vehicle
    {
        public string type;
        public string brand;
        public string carName;
        public double carPrice;
        public bool testDrive;

        public Vehicle(string Type, string Brand, string CarName, bool TestDrive, double CarPrice)
        {
            type = Type;
            brand = Brand;
            carName = CarName;
            carPrice = CarPrice;
            testDrive = TestDrive;
        }

        public Vehicle ()
        {
            type = null;
            brand = null;
            carName = null;
        }
    }
}
