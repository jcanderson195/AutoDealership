using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class AutoDealership : Vehicle
    {

        
        List<Vehicle> VehiclesCreated = new List<Vehicle>();

        public void OrderVehiclesFromManufacture()
        {
            Console.WriteLine("Would you like to order a new fleet of vehicles?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("------------------------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Thank you for your order of new vehicles!");
                Console.WriteLine("------------------------------");
                
                ManufactureVehicles();
            }
        }


        public void ManufactureVehicles()
        {

            Vehicle civic = new Vehicle("Car", "Honda", "Civic", false, 5000.00);
            Vehicle cruze = new Vehicle("Car", "Chevy", "Cruze", false, 7000.00);
            Vehicle maxima = new Vehicle("Car", "Nissian", "Maxima", false, 6000.00);
            Vehicle navigator = new Vehicle("SUV", "Lincoln", "Navigator", false, 11000.00);
            Vehicle escalade = new Vehicle("Suv", "Cadillac", "Escalade", false, 12000.00);
            Vehicle h2 = new Vehicle("Suv", "Hummer", "H2", false, 10000.00);
            Vehicle r8 = new Vehicle("Sports Car", "Audi", "R8", false, 25000.00);
            Vehicle gallardo = new Vehicle("Sports Car", "Lamborghini", "Gallardo", false, 60000.00);
            Vehicle bentley = new Vehicle("Luxury", "Bentley", "Continental GT", false, 85000.00);
            Vehicle phantom = new Vehicle("Luxury", "Rolls Royce", "Phantom", false, 90000.00);

           
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

            //foreach (Vehicle vehicle in VehiclesCreated)
            //{
            //    Console.WriteLine("Brand: " + vehicle.brand + "| Model: " + vehicle.carName + "| Test Drive: " + vehicle.testDrive + "| Price: " + vehicle.carPrice);
            //}

        }

        public void DisplayVehiclesOnLot()
        {
            foreach (Vehicle vehicle in VehiclesCreated)
            {
                Console.WriteLine("Brand: " + vehicle.brand + "| Model: " + vehicle.carName + "| Test Drive: " + vehicle.testDrive + "| Price: " + vehicle.carPrice);
            }
        }

        public void TestVehicle()
        {

        }

        public void SellVehicle()
        {

        }

        public void RaisePrice()
        {

        }

        public void LowerPrice()
        {

        }

        public void SaleEvent()
        {

        }
    }
}
