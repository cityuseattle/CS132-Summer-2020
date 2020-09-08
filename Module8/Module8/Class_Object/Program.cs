/********
** Name: Fernando, Mckenzie

** Class: CS 132

** Project:HOP8 Object Oriented programming: Class, Object, Encapsulation

** Date: 2020-08-22

** Description: Encapsulation is enable through classes
** 
**  Class Shapes

** 

********/




using System;
using static System.Console;


namespace Class_Object
{
    class Shapes //Create class named Shapes with below properties
    {
        public double lenght;
        public double width;
        public double radius;
        public double pi;

        private double CalArea(double l,double w)
        {
            lenght = l;
            width = w;
            double Area = w * l;
            return Area;
        }
        public double CalCircleArea(double r, double p) 
        {
            radius = r;
            pi = p;
            double total = r * p;
            return total;
        }    
    }
    class Program 
    {
        static void Main()
        {
            double RecWidth = 7;
            double RecLengh = 8;
            double SqWidth = 2;
            double cirA = 3 * 3;
            double pi = 3.15;

            Shapes Rectangle = new Shapes();
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes();

            WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLengh, RecWidth));
            WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));
            WriteLine("Area of Circle is: " + Circle.CalCircleArea(cirA, pi));

        }    
    }
}

