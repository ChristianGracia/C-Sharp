using System;

namespace constructors_inheritance
{
    public class Vehicle
    {
        private string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }

        public void Inherited()
        {
            Console.WriteLine("inherited");
        }

    }
}