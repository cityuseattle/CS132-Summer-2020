/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Arraylist
** Date: 2020-09-11
** Description: Program that print on screen the ListArray data.
**
********/


using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Array List using built library method
            ArrayList myArrList = new ArrayList();
           

            //Add values to Array list using Add() method.
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            // Add values to Array List using AddRange() method
            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            //Remove array list elements using RemoveRange() and RemoveAt() and remove() methods
            myArrList.Remove(10); //parameters is element value, in this case remove elements with value 10
            //now this array list has total of 5 elemnts.

            myArrList.RemoveAt(0); //Parameter is index number, in this case remove element at index 0, wich is now 11.5

            myArrList.RemoveRange(1, 2); //Parameter is index numbers, in this case remove elements from index 1 to before 2

            //Print each value in the array list using foreach() method.
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }


            
        }
    }
}
