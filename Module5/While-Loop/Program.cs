/*****
 **
 ** Name:Mckenzie,Fernando
 ** Class: CS132
 ** Project:HOP05 Conditional Structures and loops/ challenge
 ** Date: 2020-08-05
 ** Description: Implement lesson learned from chapter 5
 **
 *****/


using System;
using static System.Console;

namespace While_Loop
{
    class Program
    {
        static void Main()
        {
            int num = 1;
            WriteLine("Guess a number (1 - 10):");
            int userInput = Convert.ToInt32(ReadLine());  //Receive user input and store in "userINput" variable

            while (true)
            {
                if (userInput <  0 || userInput >=  10)
                {
                    if(userInput == num)
                    {
                        WriteLine("Your guess was correct!");
                        break;
                    }
                    else if(userInput >= 10)
                    {
                        WriteLine("you guessed wrong. Guess again:");
                        userInput = Convert.ToInt32(ReadLine());
                    }
                    else if (userInput < 0)
                    {
                        WriteLine("number must be between 1 - 10. Guess again");
                    }


                }
            }
        }
    }
}
