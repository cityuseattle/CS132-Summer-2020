/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Class Object
** Date: 2020-09-07
** Description: Program that calc area of square, rectangle and circle.
**
********/


using System;

namespace Class_Object
{
    class Shapes // Create class named Shapes with below properties
    { 
       public double lenght;
       public double width;
       public double radius;

       public double CalArea(double l, double w) // Whe we make this method private, we can't access from the object.
       {
        lenght = l;
        width = w;
        double Area = w * l;
        return Area;
       }

        public double CalCircleArea(double r)
        {

            double A = (3.15) * r * r;
            return A;
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double CirclaRadius = 3;
            

            Shapes Rectangle = new Shapes(); // Create instance/object of class Shapes, named Rectangle.
            Shapes Square = new Shapes(); // Create instance/object of class Shapes, named Square.

            Console.WriteLine("The area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            Shapes circleArea = new Shapes();
            
            Console.WriteLine("The Area of circle is: {0:0.00}", circleArea.CalCircleArea(CirclaRadius));
            
        }
    }
}
