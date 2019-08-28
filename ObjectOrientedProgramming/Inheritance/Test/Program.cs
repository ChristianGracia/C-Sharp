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
            var woman = new Woman(); 
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

    public class Human : Object
    {
        public Human()
        {

        }
        public string name { get; set; }
    }

    // class inherits properties
    public class Man : Human
    {
        public Man() {
        }
     

    }
    public class Cart : Object
    {
        public Cart()
        {

        }

    public string brand { get; set; }
    }

    public class Dog : Object
    {
        public Dog()
        {

        }
        public string breed { get; set; }
    }

    public class Woman : Human
    {
        public Woman()
        {

        }
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

