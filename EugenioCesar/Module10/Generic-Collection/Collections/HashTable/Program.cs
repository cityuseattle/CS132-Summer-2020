/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Collections
** Date: 2020-09-11
** Description: Knowing the Hash Tables.
********/

using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myhashTable = new Hashtable() //Initialize a hash table using builf in library Collections.
            {
                {"Kim", 26}, //Key = Kim; value = 26.
                {"John", 77}, //Key = John; value = 77.
                {"Max", 50} //Key = Max; value = 50.
            };

            int HastableVal1 = (int)myhashTable["Kim"]; //Get the value of key "Kim", store in HashTableVal1
            int HastableVal2 = (int)myhashTable["John"]; //Get the value of key "John", store in HashTableVal2
            int HastableVal3 = (int)myhashTable["Max"]; //Get the value of key "Max", store in HashTableVal3

            Console.WriteLine(HastableVal1); //Print on screen.
            Console.WriteLine(HastableVal2); //Print on screen.
            Console.WriteLine(HastableVal3); //Print on screen.
        }
    }
}
