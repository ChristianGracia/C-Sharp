using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var cart = new Cart ();
            var dog = new Dog ();
        }
    }
    public class Object
    {
        public Object()
        {

        }
        public bool moves { get; set; }

        public string color { get; set; }

    }

    // class inherits properties
    public class Man : Object
    {
        public Man() {
        }
        public string name { get; set; }

    }
    public class Cart
    {
        public Cart()
        {

        }

    public string brand { get; set; }
    }

    public class Dog
    {
        public Dog()
        {

        }
        public string breed { get; set; }
    }



}



    //public class Car
    //{
    //  public Car (string _color, string _size){

    //this.color = _color;
    //this.size = _size; 
    //}
    //public string color { get; set; }
    //public string size { get; set; }
    //}

