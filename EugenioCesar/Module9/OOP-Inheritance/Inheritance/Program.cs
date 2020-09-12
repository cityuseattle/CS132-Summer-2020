/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Inheritance
** Date: 2020-09-11
** Description: Program that calc areas.
**
********/


using System;

namespace Inheritance
{
    class Program
    {

        class Shapes // Create class named Shapes with below properties
        {
            public double lenght;
            public double width;
            public double radius;
            

           public void PrintPropertiesOnScreen()
            {
                Console.WriteLine("Base length is: " + lenght);
                Console.WriteLine("Base width is: " + width);

            }
        }

        class Rectangle : Shapes // Rectangle class derived from Shapes base class.
        {

            public void CalArea(double l, double w) // Whe we make this method private, we can't access from the object.
            {
                lenght = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle legth is: " + lenght);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes
        {
            public void CalArea(double a)
            {
                lenght = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {

            Rectangle myRec = new Rectangle(); // Object myRec of class Rectangle.

            Circle myCir = new Circle(); // Object myCir of class Circle.

            Square mySq = new Square(); // Object mySq of class Square.

            //Console.WriteLine("Base lenght is: " + myRec.radius);
            //Console.WriteLine("Base width is: " + myRec.width);
            //Console.WriteLine("Base radius is: " + myCir.radius);

            myRec.CalArea(3, 4);
            Console.WriteLine("\n");

            mySq.CalArea(10);
            Console.WriteLine("\n");

            myCir.CalArea(8);
            Console.WriteLine("\n");

            myRec.PrintPropertiesOnScreen();

        }
    }
}
