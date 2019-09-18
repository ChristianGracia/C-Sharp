using System;

namespace constructors_inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
           : base(registrationNumber)
        {
            Console.WriteLine("car class is being initialized {0}", registrationNumber);
        }
    }
}