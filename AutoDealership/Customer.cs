using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class Customer
    {
        public string name;
        public int id;
        private double walletBalance;



        public double WalletBalance
        {
            get
            {
                return walletBalance;
            }

            set
            {
                walletBalance = value;
            }
        }

        public Customer(string Name,int ID)
        {
            name = Name;
            id = ID;
        }

        public Customer()
        {
            name = null;
           
        }
        
        public double EnterWalletBalance()
        {
            Console.WriteLine("How much money do you have to spend with us today?");
            Console.WriteLine("------------------------------");
            walletBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Alright lets get started then.");
            return walletBalance;
        }   //good


        public void GatherCustomerInformation()
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("------------------------------");
            name = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Create a 4 digit ID for yourself using numbers.");
            id = Convert.ToInt32(Console.ReadLine());
            Customer newCustomer = new Customer(name, id);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome "+newCustomer.name+", What can we help you with today?");
            Console.WriteLine("------------------------------");

        } //good

       public void TestDriveVehicle(AutoDealership salesmen)
        {
            Console.WriteLine("------------------------------");
            salesmen.DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle you would like to test drive. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                salesmen.civic.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                salesmen.cruze.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Maxima")
            {
                salesmen.maxima.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                salesmen.navigator.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                salesmen.escalade.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                salesmen.h2.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                salesmen.r8.testDrive = true;
                Console.WriteLine("This vehicle has been successfully test driven.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                TestDriveVehicle(salesmen);
            }

        } //good

        public void HagglePriceOption(AutoDealership salesmen)
        {
            Console.WriteLine("So you would like to negotiate a possible price change for a vehicle.");
            Console.WriteLine("------------------------------");
            salesmen.DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            HagglePriceOperation(salesmen);
        }

        public void HagglePriceOperation(AutoDealership salesmen)
        {
            Console.WriteLine("Please enter the model name of the vehicle you would like to negotiate on. The name is case sensitive!");
            string choice = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("How much are you willing to pay for this vehicle?");

            double wager = Convert.ToDouble(Console.ReadLine());

            if (wager <= 4000 && choice == "Civic")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 4001 && choice == "Civic")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.civic.carPrice = wager;
                Console.WriteLine("This vehicle is now "+salesmen.civic.carPrice+" dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (wager <= 5000 && choice == "Cruze")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 5001 && choice == "Cruze")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.cruze.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.cruze.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (wager <= 5000 && choice == "Maxima")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 5001 && choice == "Maxima")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.maxima.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.maxima.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (wager <= 8000 && choice == "Navigator")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 8001 && choice == "Navigator")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.navigator.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.navigator.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (wager <= 9000 && choice == "Escalade")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 9001 && choice == "Escalade")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.escalade.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.escalade.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (wager <= 7000 && choice == "H2")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 7001 && choice == "H2")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.h2.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.h2.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (salesmen.r8.carPrice == 20000)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("This vehicle is a part of our end of the year Sports event. It's already at discounted price. Please choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager <= 22000 && choice == "R8")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("I'm sorry. I can't make that deal. Please try again or choose another vehicle to negotiate over.");
                Console.WriteLine("------------------------------");
                HagglePriceOperation(salesmen);
            }
            else if (wager >= 22001 && choice == "R8")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("You've got yourself a deal.");
                salesmen.r8.carPrice = wager;
                Console.WriteLine("This vehicle is now " + salesmen.r8.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                HagglePriceOperation(salesmen);
            }
        } //good


        public void PurchaseVehicle(AutoDealership salesmen)
        {
            Console.WriteLine("------------------------------");
            salesmen.DisplayVehiclesOnLot();
            Console.WriteLine("------------------------------");
            EnterWalletBalance();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter the model name of the vehicle that you would like to purchase at this time. The name is case sensitive!");
            Console.WriteLine("------------------------------");

            string choice = Console.ReadLine();

            if (choice == "Civic")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.civic.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.civic.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.civic);
                Console.WriteLine("The balance of your wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Cruze")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.cruze.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.cruze.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.cruze);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();
            }
            else if (choice == "Maxima")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.maxima.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.maxima.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.maxima);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Navigator")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.navigator.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.navigator.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.navigator);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "Escalade")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.escalade.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.escalade.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.escalade);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "H2")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.h2.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.h2.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.h2);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else if (choice == "R8")
            {
                Console.WriteLine("You have purchased this vehicle for " + salesmen.r8.carPrice + " dollars.");
                Console.WriteLine("------------------------------");
                WalletBalance = walletBalance - salesmen.r8.carPrice;
                salesmen.VehiclesCreated.Remove(salesmen.r8);
                Console.WriteLine("The balance of the dealership wallet is now " + walletBalance + " dollars.");
                Console.WriteLine("------------------------------");
                salesmen.DisplayVehiclesOnLot();

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry that vehicle is not a part of our fleet. Please choose a vehicle among the list of vehicles available!");
                PurchaseVehicle(salesmen);
            }
        }  //good

    }
}
