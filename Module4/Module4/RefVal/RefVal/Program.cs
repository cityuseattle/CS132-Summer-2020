/********

**

** Name: Mckenzie, Fernando

** Class: CS 132

** Project: RefVal

** Date: 2020-08-03

** Description: explicit passing arguments by Ref.

**

********/

using System;

namespace RefVal
{
    class Program
    {
        static void Main(string[] args)
        {
            float house = 200000.0f;
            float salary = 75000.0f;

            //Explicitly pass variables by reference. 
            AdjustForInflation(ref house, ref salary);
            Console.WriteLine("** Values After Inflation Adjustment**");
            Console.WriteLine("Home: " + house);
            Console.WriteLine("Income:" + salary);
            Console.ReadLine();

        }
        // Receive arguments explicitly by reference.
        static void AdjustForInflation(ref float home, ref float income){   
            const float RATE = 1.03f;
            home *= RATE;
            income *= RATE;
        }
    }
}
