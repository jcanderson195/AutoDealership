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

        
        public double EnterWalletBalance()
        {
            Console.WriteLine("How much money do you have to spend with us today?");
            Console.WriteLine("------------------------------");
            walletBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Alright lets get started then.");
            return walletBalance;
        }


       public void TestDriveVehicle()
        {

        }

        public void HagglePrice()
        {

        }

       public void PurchaseVehicle()
        {

        }

    }
}
