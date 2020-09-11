/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Date Time
** Date: 2020-09-07
** Description: Program that display your birthday current day of the month and 
*  number of days of the month. 
********/


using System;

namespace Date_Time
{
    class Program
    {
         void GetPersonalInfo()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?:");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);

            Console.WriteLine("Here are what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);
        }

        /* void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapYear = DateTime.IsLeapYear(2020);

            Console.WriteLine(currentDate);
            Console.WriteLine("2020 is a leapYear? " + leapYear);
            //Console.WriteLine(leapYear); 
        } */
    

        static void Main(string[] args)
        {
          Program myProgram = new Program();
          //myProgram.ShowTime();
            myProgram.GetPersonalInfo();
            DateTime dt = DateTime.Now;
            Console.WriteLine("The current month number is: " + dt.Month);
            int num_days = DateTime.DaysInMonth(2018, 8);
            Console.WriteLine("Number of days of this month: " + num_days);

        }
    }

}
