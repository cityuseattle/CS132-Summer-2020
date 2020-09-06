/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: String Manipulation
** Date: 2020-09-06
** Description: Print string characters.
**
********/


using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";

            Console.WriteLine(Welcome[0]); //Print the character at index 0 of the string "Welcome".
            Console.WriteLine(CourseName.Substring(CourseName.Length -1));

            /* string message = Welcome + CourseName;// Concatenate strings.

            string message1 = string.Concat(Welcome, CourseName); // Concat string by substitution values of variables.
            string message2 = $"Printing the string for the second time: {Welcome} {CourseName}";

            Console.WriteLine(message1); 

            string message = Welcome.ToUpper() + CourseName.ToLower(); // Concatenate strings.
            
            string message1 = string.Concat(Welcome, CourseName); // Concatenate string using concat() built method. */

        }
    }
}
