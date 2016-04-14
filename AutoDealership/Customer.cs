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
        }


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

        }

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

        public void HagglePrice(AutoDealership salesmen)
        {

        }

       public void PurchaseVehicle(AutoDealership salesmen)
        {

        }

    }
}
