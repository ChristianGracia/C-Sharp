namespace constructors_inheritance
{
    public class Car : Vehicle
    {
        // using base to reuse constructor from the Vehicle class
        // for the Car class to inherit
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            // init fields specific to car class here
        }
    }
}