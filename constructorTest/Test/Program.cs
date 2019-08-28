using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("yellow", "Mini");
            var car2 = new Car("black", "large");
     
            Console.WriteLine("car1 is " + car.color + "\ncar2 is "  + car2.color);

        }
    }
    public class Car
    {
        public Car (string _color, string _size){
            
                this.color = _color;
                this.size = _size; 
     }
        public string color { get; set; }
        public string size { get; set; }
    }
}
