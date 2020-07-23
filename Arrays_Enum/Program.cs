/********
**
** Name: Mckenzie, Fernando
** Class: CS 132
** Project: HOP02
** Date: 2020-07-22
** Description: Arrays and Enumeration.
** Include those aspects that would be relevant for someone
** viewing the project without any prior information about the project.
**
********/


using System;
using System.Globalization;

namespace Arrays_Enum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];  //creating a new array of type interger named 'numbers'
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            //print ou the whole array
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //
            //}

            foreach (int number in numbers)   
            {
                Console.Write(number + " "); 
            }
           
        }
    }
}
