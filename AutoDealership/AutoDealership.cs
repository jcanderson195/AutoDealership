using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class AutoDealership : Vehicle
    {
       public List<Vehicle> VehiclesCreated = new List<Vehicle>();

        public Vehicle civic;
        public Vehicle cruze;
        public Vehicle maxima;
        public Vehicle navigator;
        public Vehicle escalade;
        public Vehicle h2;
        public Vehicle r8;
        
        public double dealershipWallet;

        public AutoDealership()
        {
            dealershipWallet = 12000.00;
        }

        public void OrderVehiclesFromManufacturer()
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
        } //good


        public void ManufactureVehicles()
        {

            civic = new Vehicle("Car", "Honda", "Civic", false,false, 5000.00);
            cruze = new Vehicle("Car", "Chevy", "Cruze", false,false, 7000.00);
            maxima = new Vehicle("Car", "Nissian", "Maxima", false,false, 6000.00);
            navigator = new Vehicle("SUV", "Lincoln", "Navigator", false,false, 11000.00);
            escalade = new Vehicle("Suv", "Cadillac", "Escalade", false,false, 12000.00);
            h2 = new Vehicle("Suv", "Hummer", "H2", false,false, 10000.00);
            r8 = new Vehicle("Sports Car", "Audi", "R8", false,false, 25000.00);
           

           
            VehiclesCreated.Add(civic);
            VehiclesCreated.Add(cruze);
            VehiclesCreated.Add(maxima);
            VehiclesCreated.Add(navigator);
            VehiclesCreated.Add(escalade);
            VehiclesCreated.Add(h2);
            VehiclesCreated.Add(r8);
            

            

        }   //good

        public void DisplayVehiclesOnLot()
        {
            foreach (Vehicle vehicle in VehiclesCreated)
            {
                Console.WriteLine("Brand: " + vehicle.brand + "| Model: " + vehicle.carName +"| Tested: "+vehicle.testedStatus+ "| Test Drive: " + vehicle.testDrive + "| Price: " + vehicle.carPrice);
            }
        }  //good

        public void TestVehicleOption()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Would you like to run tests on a vehicle?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("------------------------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                RunTestOnVehicle();
            }
        }  //good

        public void RunTestOnVehicle()
        {
            
            Console.WriteLine("------------------------------");
            DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle you would like to run tests on. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                civic.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                cruze.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Maxima")
            {
                maxima.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                navigator.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                escalade.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                h2.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                r8.testedStatus = true;
                Console.WriteLine("This vehicle has been successfully tested.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                RunTestOnVehicle();
            }
        }   //good

        public void SellVehicle()
        {
            Console.WriteLine("------------------------------");
            DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle that is being sold at this time. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                Console.WriteLine("You have sold this vehicle for "+civic.carPrice+" dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += civic.carPrice;
                VehiclesCreated.Remove(civic);
                Console.WriteLine("The balance of the dealership wallet is now "+dealershipWallet+" dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                Console.WriteLine("You have sold this vehicle for " + cruze.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += cruze.carPrice;
                VehiclesCreated.Remove(cruze);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Maxima")
            {
                Console.WriteLine("You have sold this vehicle for " + maxima.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += maxima.carPrice;
                VehiclesCreated.Remove(maxima);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                Console.WriteLine("You have sold this vehicle for " + navigator.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += navigator.carPrice;
                VehiclesCreated.Remove(navigator);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                Console.WriteLine("You have sold this vehicle for " + escalade.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += escalade.carPrice;
                VehiclesCreated.Remove(escalade);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                Console.WriteLine("You have sold this vehicle for " + h2.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += h2.carPrice;
                VehiclesCreated.Remove(h2);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                Console.WriteLine("You have sold this vehicle for " + r8.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                dealershipWallet += r8.carPrice;
                VehiclesCreated.Remove(r8);
                Console.WriteLine("The balance of the dealership wallet is now " + dealershipWallet + " dollars.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                SellVehicle();
            }
        }       //good

        public void RaisePrice()
        {
            Console.WriteLine("------------------------------");
            DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle you would like to raise the price on. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                civic.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                cruze.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Maxima")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                maxima.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                navigator.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                escalade.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                h2.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                Console.WriteLine("How much would you like to raise the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                r8.carPrice += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully increased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                RaisePrice();
            }
        }       //good

        public void LowerPrice()
        {
            Console.WriteLine("------------------------------");
            DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle you would like to lower the price on. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                civic.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                cruze.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Maxima")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                maxima.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                navigator.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                escalade.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                h2.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                Console.WriteLine("How much would you like to lower the price of this vehicle by?");
                Console.WriteLine("------------------------------");
                r8.carPrice -= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price of this vehicle has been successfully decreased.");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                LowerPrice();
            }
        }       //good

        public void SaleEvent()
        {
            Console.WriteLine("This will start the end of the year Sports sale event where our Audi R8's will be 20% off. Do you want to start this event?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("------------------------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                r8.carPrice = r8.carPrice - 5000.00;
                Console.WriteLine("------------------------------");
                Console.WriteLine("Audi R8's are now 20% off!!!!!");
                Console.WriteLine("------------------------------");
                DisplayVehiclesOnLot();
            }
        }      //good
    }
}
