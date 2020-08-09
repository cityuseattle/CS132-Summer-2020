/*****
 **
 ** Name:Mckenzie,Fernando
 ** Class: CS132
 ** Project:HOP05 Conditional Structures and loops
 ** Date: 2020-08-05
 ** Description: Implement lesson learned from chapter 5
 **
 *****/

using System;
using System.ComponentModel;
using static System.Console;

namespace Conditional_Statements
{
    class Program
    {
        static void Main()
        {
            int num = 6;
            Console.WriteLine("Guess a number (1-10):");
            int userInput = Convert.ToInt32(ReadLine());  // receive user input and store in "userInput"  variable
            
            if(userInput == num)
            {
                WriteLine("your guess was correct");
             
            }
            else if (userInput >= num)
            {
                WriteLine("must be 1 - 10!!!");
            }      
            else if (userInput != num)
            {
                WriteLine("you guessed wrong. Goodluck next time!");
            }
        }  
    }
}
