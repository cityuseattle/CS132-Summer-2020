
/********
** Name: Fernando, Mckenzie

** Class: CS 132

** Project:HOP3 

** Date: 2020-08-22

** Description: Numeric Operators and Routines 

** 
**  

** 

********/
using System;
using static System.Console;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;
            // the first is sum, second subtract, third multiply, fourth divide, last modulus. 
            float sum = num1 + num2 + num3;
            int subtract = num2 - num1;
            int multiply = num1 * num2;
            float divide = num1 / num3;
            int modulus = num2 % num1;
            // console will output text and the num operators
            WriteLine("Sum of 3 numbers is: " + sum);
            WriteLine("77- 20 is: " + subtract);
            WriteLine("20 * 77 is: " + multiply);
            WriteLine("20 / 5.2 is: " + divide);
            WriteLine("77 % 20 is: " + modulus);
        }
    }
}
