using System;

namespace ProduceCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var carSuv = new Suv(2);
        
            Console.WriteLine("Car 1\nNumber of seats: " + carSuv.numberOfSeats);

            var CarSuv1 = new Suv(3, "Nissan");

            Console.WriteLine("\nCar2\nBrand: " + CarSuv1.brand + "\nNumber of seats: " + CarSuv1.numberOfSeats);

            var carSuv2 = new Suv(4, "purple", "Ford");

            Console.WriteLine("\ncar3\nColor: " + carSuv2.color + "\nBrand: " + carSuv2.brand + "\nNumber of seats: " + carSuv2.numberOfSeats);

        }


    }

    public class Car
    {
        public Car()
        {
      
        }
        public string color { get; set; }
        public string brand { get; set; }
    }

    public class Suv : Car
    {
        public Suv(int numberOfSeats) {
            this.numberOfSeats = numberOfSeats;
        }

        public Suv(int numberOfSeats, string brand)
        {
            this.numberOfSeats = numberOfSeats;
            this.brand = brand;
        }

        public Suv(int numberOfSeats, string color, string brand)
        {
            this.numberOfSeats = numberOfSeats;
            this.color = color;
            this.brand = brand;

        }
        public int numberOfSeats { get; set; }
    }
}
