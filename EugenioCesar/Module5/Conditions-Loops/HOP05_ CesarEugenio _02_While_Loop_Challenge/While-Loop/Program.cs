/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: While Loop
** Date: 2020-09-06
** Description: Compares input number by user with the variable defined by the prorgamer
**
********/


using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; // Variable to compare with user input.

            Console.WriteLine("Guess a number (1 - 10): "); // Print out a message.
            int userInput = Convert.ToInt32(Console.ReadLine()); //Receive user input and store in "userinput" variable.

            while (true) // Always will going into while cicle
            {

                if  (userInput > 0 && userInput <= 10) // If compare conditions userInput > 0 and <= 10.
                {
                    if (userInput == num) // If userinput is equal than variable then print out a message and exit
                    {
                        Console.WriteLine("Your guess was correct"); // Printing out a message
                        break; // Going out the program
                    }

                    if (userInput != num) // Compares if the number is diferent that variable.
                    {
                        Console.WriteLine("You guessed wrong. Guess again: "); // print out a message
                        userInput = Convert.ToInt32(Console.ReadLine()); // Convert to string the user input.
                    }
                }

                if (userInput < 0 || userInput > 10) // Compares if user input is less than zero or greather than ten.
                {

                    Console.WriteLine("Number must be between 1 - 10. Guess again: "); // Printing out a message.
                    userInput = Convert.ToInt32(Console.ReadLine()); // Convert to string the user input.
                }

            }
            

            
        }
    }
}
