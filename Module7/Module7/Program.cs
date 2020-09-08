/********
** Name: Fernando, Mckenzie

** Class: CS 132

** Project:HOP7 Date_Time

** Date: 2020-08-22

** Description: Date time Handling and team learn.

** video games or calendars
** Almanacs 

** 

********/
using System;
using static System.Console;


namespace Date_Time
{
    class Program
    {
        void GetPersonalInfo() 
        {
            WriteLine(" get nmd?: ");
            var nmd = Convert.ToInt32(ReadLine());
            WriteLine("What is the current month: ");
            int month = Convert.ToInt32(ReadLine());
            WriteLine("Enter your name: ");
            string name = ReadLine();

            WriteLine("What year were you born?: ");
            int birthyear = Convert.ToInt32(ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthyear);
            
            WriteLine("Here are what we know from your inputs: ");
            WriteLine("your name: " + name);
            WriteLine("Today is: " + DateTime.Now.ToShortTimeString());
            WriteLine("your age: " + age);
            WriteLine("what is the current month:" + month);
            WriteLine("get nmd?: " + nmd);
        }
        static void Main() 
        {
            Program MyProgram = new Program();
            MyProgram.GetPersonalInfo();
        }

    }

}
