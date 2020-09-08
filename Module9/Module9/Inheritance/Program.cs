using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        class Shapes //Create class meand Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;
        }
        class Rectangle: Shapes // Rectangle class derived from Shapes base class  
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double Rectangle = l * w;
                WriteLine("Rectangle length is: " + length);
                WriteLine("Rectangle width is: " + width);
                string AreaRec = null;
                WriteLine("Recntangle Area is: " + AreaRec);

                
            }
        }   
        class Square : Shapes //Square class derived from shapes base class  
        {
            public void CalArea(double a) 
            {
                length = a;
                double SqArea = a * a;
                WriteLine("Square side length is : " + a);
                WriteLine("Square Area is: " + SqArea);
            }
        }
        class Circle : Shapes // Circle class derived from Shapes bas class
        {
            public void CalArea(double r) 
            {
                radius = r;
                double CirArea = 3.15 * r;
                WriteLine("Circle radius is: " + radius);
                WriteLine("Circle Area is: " + CirArea);
            }
        }
        static void Main(string[] args) 
        {
            Rectangle MyRec = new Rectangle(); //objec MyRec of class Rectangle
            Circle MyCir = new Circle(); //object MyCir of clas circle
            Square MySq = new Square(); //object MySq of class Square

            //usig obj to call properties of it classes. since all rectangle, Square and circle classes
            //are derived from base class shapes, all of those classes have accesss to shapes' properties
            //making their objects also able to access 
            //length, width and radius, which are the properties of base clas shapes
            WriteLine("Base length is " + MyRec.length);
            WriteLine("Base width is " + MyRec.width);
            WriteLine("Base radius is " + MyCir.radius);
            WriteLine("\n");

            MyRec.CalArea(3, 4);
            WriteLine("\n"); //jump to the next line

            MySq.CalArea(10);
            WriteLine("\n");

            MyCir.CalArea(8);
        }
    }

}
