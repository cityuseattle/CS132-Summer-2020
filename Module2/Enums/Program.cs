/*****
 **
 ** Name:Mckenzie,Fernando
 ** Class: CS132
 ** Project:HOP02 Enums
 ** Date: 2020-08-10
 ** Description: Implement lesson learned from chapter 2
 **
 *****/



using System;
using static System.Console;


namespace Enums
{
    enum Gender {Male, Female, Other};
    enum Age { Young, Middlem, Old};
    enum Hair {Long, Short, Bald};
    enum Height {Tall, Short};
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I am a " + Gender.Male);
            WriteLine("My Age is " + Age.Young);
            WriteLine("My Hair is " + Hair.Bald);
            WriteLine("My Height is " + Height.Tall);

        }
    }
}
