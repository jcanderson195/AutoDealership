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
        public UserInterface()
        {
            salesmen = new AutoDealership();
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to DevCodeCamp Auto Dealership");
            Console.WriteLine("------------------------------");
            PathOptions();
            PathChoice();
        }

        public void PathOptions()
        {
            Console.WriteLine("Are you a salesman or customer?");
            Console.WriteLine("1.Salesman");
            Console.WriteLine("2.Customer");
            Console.WriteLine("3.Exit");
            Console.WriteLine("------------------------------");
        }

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
                //insert customer functions
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
        }

        public void SalesmenOptions()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1.Order vehicles");
            Console.WriteLine("2.Test Drive Vehicle");
            Console.WriteLine("3. Raise Price of Vehicle");
            Console.WriteLine("4.Lower Price of Vehicle");
            Console.WriteLine("------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                salesmen.OrderVehiclesFromManufacture();
                salesmen.DisplayVehiclesOnLot();
                Console.WriteLine("------------------------------");
                Introduction();
            }
            else if (choice == 2)
            {
                //insert function to test vehicle
            }
            else if (choice == 3)
            {
                //insert function to raise price of vehicle
            }
            else if (choice == 4)
            {
                //insert function to lower price of vehicle
            }
        }

    }
}
