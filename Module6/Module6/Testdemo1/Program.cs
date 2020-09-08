using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Testdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inpur your first name: ");
            string firstname = Console.ReadLine();
            string pattern = @"^[\p{L} \.\-]+$";
            Validate(firstname, pattern);
            while (!Regex.IsMatch(firstname, pattern);
            {
                Console.WriteLine("this is a valid name");
                Console.WriteLine()
            }
        }
    }
}
