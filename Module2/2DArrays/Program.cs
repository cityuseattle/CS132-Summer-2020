
/*****
 **
 ** Name:Mckenzie,Fernando
 ** Class: CS132
 ** Project:HOP02 2DArrays
 ** Date: 2020-08-10
 ** Description: Implement lesson learned from chapter 2
 **
 *****/
using System;
using static System.Console;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns]; // create a 2D array that is 3x3(3 rows and 3 columns)
            table[0, 1] = 1; // assign value to each array element, no specific value is provide, by default its 0
            table[1, 1] = 8;
            table[2, 1] = 5;

            //loop through and print the whole 2D array
            for(int x = 0; x < rows; x++)
            {
                for(int y = 0; y < columns; y++)
                {
                    Write(table[x, y]);
                }
                WriteLine();  // a new line is created aftr each row is iteraded         
            }
            
        }
    }
}
