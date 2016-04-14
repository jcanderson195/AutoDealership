using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class UserInterface
    {
        AutoDealership salesmen;
        Customer newCustomer;
        public UserInterface()
        {
            salesmen = new AutoDealership();
            newCustomer = new Customer();
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to DevCodeCamp Auto Dealership");
            Console.WriteLine("------------------------------");
            PathOptions();
            PathChoice();
        }               //good

        public void PathOptions()
        {
            Console.WriteLine("Are you a salesman or customer?");
            Console.WriteLine("1.Salesman");
            Console.WriteLine("2.Customer");
            Console.WriteLine("3.Exit");
            Console.WriteLine("------------------------------");
        }               //good

        public void PathChoice()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("------------------------------");
                SalesmenOptions();
            }
            else if (choice == 2)
            {
                Console.WriteLine("------------------------------");
                newCustomer.GatherCustomerInformation();
                CustomerOptions();
            }
            else if (choice == 3)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Thank you for visiting DevCodeCamp Auto Dealership. Please follow us on Facebook and Twitter for updates on vehicles we have available!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your decision and then press Enter!");
                Console.WriteLine("------------------------------");
                Introduction();
                
            }
        }                   //good

        public void SalesmenOptions()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1.Order Vehicles");
            Console.WriteLine("2.Run Tests On Vehicle");
            Console.WriteLine("3. Raise Price of Vehicle");
            Console.WriteLine("4.Lower Price of Vehicle");
            Console.WriteLine("5.Start End of the Year Sports Event");
            Console.WriteLine("6.Sell Vehicle");
            Console.WriteLine("------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                salesmen.OrderVehiclesFromManufacturer();
                salesmen.DisplayVehiclesOnLot();
                Console.WriteLine("------------------------------");
                Introduction();
            }
            else if (choice == 2)
            {
                salesmen.TestVehicleOption();
                Introduction();
            }
            else if (choice == 3)
            {
                salesmen.RaisePrice();
                Console.WriteLine("------------------------------");
                Introduction();
            }
            else if (choice == 4)
            {
                salesmen.LowerPrice();
                Console.WriteLine("------------------------------");
                Introduction();
            }
            else if (choice == 5)
            {
                salesmen.SaleEvent();
                Console.WriteLine("------------------------------");
                Introduction();
            }
            else if (choice == 6)
            {
                salesmen.SellVehicle();
                Console.WriteLine("------------------------------");
                Introduction();
            }
        }       //good

        public void CustomerOptions()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1.Test drive a vehicle");
            Console.WriteLine("2.Haggle Price of a vehicle");
            Console.WriteLine("3.Purchase Vehicle");
            Console.WriteLine("4.View cars on lot");
            Console.WriteLine("------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                newCustomer.TestDriveVehicle(salesmen);
                Console.WriteLine("------------------------------");
                CustomerOptions();

            }
            else if (choice == 2)
            {
                newCustomer.HagglePriceOption(salesmen);
                Console.WriteLine("------------------------------");
                CustomerOptions();
            }
            else if (choice == 3)
            {
                newCustomer.PurchaseVehicle(salesmen);
                Console.WriteLine("------------------------------");
                CustomerOptions();
            }
            else if (choice == 4)
            {
                salesmen.DisplayVehiclesOnLot();
                Console.WriteLine("------------------------------");
                CustomerOptions();

            }
        }       //good
    }
}
