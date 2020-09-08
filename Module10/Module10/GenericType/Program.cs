using System;
using static System.Console;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T, U, H> // declare class StoreAnything using generic type
        {
            public T var1  {set; get;}
            public U var2  {set; get;}
            public H var3  {set; get;}
        }
        static void Main(string[] args)
        {
            //create new object of StoreAnything class, passing string type
            StoreAnything<string, int,char> Myvar1 = new StoreAnything<string, int,char> { var1 = "CS", var2 = 132, var3 = '!' };
           

            WriteLine(Myvar1.var1 + " " + Myvar1.var2 + Myvar1.var3); //print new values of var1
        }    
    }
}
