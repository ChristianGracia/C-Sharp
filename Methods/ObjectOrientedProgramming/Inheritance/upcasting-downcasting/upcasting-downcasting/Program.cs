using System;
using System.Globalization;

namespace upcasting_downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {

            // not to be compiled


            // upcasting    implicit   no conversion required
            // conversion from a derived class to a base

            Circle circle = new Circle();
            Shape shape = circle;

            // downcasting   explicit
            // conversion from a base class to a derived class

            Circle circle = new Circle();
            Shape shape = circle;

            Circle anotherCircle = (Circle) shape;


            // throws invalid cast exception

             Car car = (Car) shape;     //throws


             //as
             // if object cannot be converted to target type
             // as returns null instead of an exception

             Car car = (Car) obj;

             Car car = obj as Car;

             if(car != null)
                 // do something



             //is
             // check what type of object and returns true/false

                 if (obj is car)
                 {
                     Car car = (car) obj;
                 }

        }
    }


    public class Shape
    {

    }

    public class Circle : Shape
    {

    }


}
