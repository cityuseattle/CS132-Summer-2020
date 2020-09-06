/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Strings
** Date: 2020-09-26
** Description: Program that find even position in a string and print it.
**
********/


using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName; // Concatenate two strings;
            

            for (int i = 0; i < message.Length; i++) // Loop through the text string
            {
                if ((i % 2) == 0) // // Check it is odd or even (Means character position).
                {
                    Console.WriteLine(message[i]); // Print out the character at even index. 
                }
            }
        }

    }
}
