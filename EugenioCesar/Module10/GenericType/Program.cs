/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: xx
** Date: 2020-09-11
** Description: Program tha use Generic Types.
**
********/


using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything<T, U, Z> //Declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public Z var3 { set; get; }

        }

        static void Main(string[] args)
        {
            // Create a new object of StoreAnything class, passing string type
            StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> {var1 = "CS", var2 = 131, var3 = '!' };

            // Create a new object of StoreAnything class, passing int type
            //StoreAnything<int> MyVar2 = new StoreAnything<int> { };

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + MyVar1.var3); // Print new values of var1, var2, and var3.

        }
    }
}
