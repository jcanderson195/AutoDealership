﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership
{
    class Program
    {
        static void Main(string[] args)
        {

            Manufacturer test = new Manufacturer();
            test.DisplayCreatedVehicles();
            Console.ReadKey();

        }
    }
}
