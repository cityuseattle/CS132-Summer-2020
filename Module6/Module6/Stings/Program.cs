/*****
 **
 ** Name:Mckenzie,Fernando
 ** Class: CS132
 ** Project:HOP06 String Manipulation
 ** Date: 2020-08-10
 ** Description: Implement lesson learned from chapter 5
 **
 *****/


using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace Sting
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //string Welcome = "Welcome to ";
            //string CourseName = "CS132";
            //string message1 =  string.Concat(Welcome, CourseName); //concatenate strings using concat() built in method
            //string message2 = $"printing the strings for the second time: {Welcome} {CourseName}"; // string by substitutes values of varibles into place holders in a string 

            //WriteLine(message1);
            //WriteLine(message2);

            //string Welcome = "Welcome to ";
            ///string CourseName = "CS132";
            //string message = Welcome.ToUpper() + CourseName.ToLower();

            //Console.WriteLine(message);

            //string Welcome = "Welcome to ";
            //string CoursName = "CS132";

            //string message1 = string.Concat(Welcome, CoursName); //concatenate strings using concat() built in method
            //WriteLine(message1.Length); // count the numbers of characters in string " message1" including space

            //string Welcome = "Welcome to ";
            //string CourseName = "CS132";

            //WriteLine(Welcome[0]); //print the character at index 0 of string "welcome"
            //WriteLine(CourseName.Substring(CourseName.Length - 1)); //get and print the last character of string "CourseName"

            string Welcome = "Welcome to ";
            string CourseName = "CS132";
            string message = Welcome + CourseName;

            // the index starts at 0 and keeps iterating, as long as its in range of "message"
            for (int i = 2; i < message.Length; i++)
            {
                WriteLine(message[i]); //prints the value at the index of "message", starting at index 0
            }

        }
    }
}
