using System;

namespace constructors_inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
           //Console.WriteLine("vehicle class is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being initialized {0}", registrationNumber);
        }

    }
}