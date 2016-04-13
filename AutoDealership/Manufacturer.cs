using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class Manufacturer : Vehicle
    {

        List<Vehicle> VehiclesCreated;

        public Manufacturer()
        {
            VehiclesCreated = new List<Vehicle>();
        }

        public void CreateVehicles()
        {

            Vehicle civic = new Vehicle("Car", "Honda", "Civic", 5000.00);
            Vehicle cruze = new Vehicle("Car", "Chevy", "Cruze", 7000.00);
            Vehicle maxima = new Vehicle("Car", "Nissian", "Maxima", 6000.00);
            Vehicle navigator = new Vehicle("SUV", "Lincoln", "Navigator", 11000.00);
            Vehicle escalade = new Vehicle("Suv", "Cadillac", "Escalade", 12000.00);
            Vehicle h2 = new Vehicle("Suv", "Hummer", "H2", 10000.00);
            Vehicle r8 = new Vehicle("Sports Car", "Audi", "R8", 25000.00);
            Vehicle gallardo = new Vehicle("Sports Car", "Lamborghini", "Gallardo", 60000.00);
            Vehicle bentley = new Vehicle("Luxury", "Bentley", "Continental GT", 85000.00);
            Vehicle phantom = new Vehicle("Luxury", "Rolls Royce", "Phantom", 90000.00);

            VehiclesCreated.Add(civic);
            VehiclesCreated.Add(cruze);
            VehiclesCreated.Add(maxima);
            VehiclesCreated.Add(navigator);
            VehiclesCreated.Add(escalade);
            VehiclesCreated.Add(h2);
            VehiclesCreated.Add(r8);
            VehiclesCreated.Add(gallardo);
            VehiclesCreated.Add(bentley);
            VehiclesCreated.Add(phantom);

        }

        public void DisplayCreatedVehicles()
        {
            CreateVehicles();

            foreach (Vehicle vehicle in VehiclesCreated)
            {
                Console.WriteLine("Brand: "+ vehicle.brand+"| Model: "+vehicle.carName+"| Price: "+vehicle.carPrice);
            }
        }
       
    }
}
