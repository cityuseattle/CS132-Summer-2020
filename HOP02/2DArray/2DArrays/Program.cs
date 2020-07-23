using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns]; //create a 2D array that is 3x3 (3 rows and 3 columns)
            table[0, 0] = 1; //assign value to each element, no specific value is provided, by default it's 0   100 is a close as ill get it for now take break.
            table[2, 1] = 8;
            table[1, 1] = 5;

            //loop through and print the whole 2D array
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write(table[x, y]);

                }
                Console.WriteLine(); //a new line is created after each row is iterated

            }
        }
    }
}