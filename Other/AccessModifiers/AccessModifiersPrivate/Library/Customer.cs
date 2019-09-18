using System;

namespace Library
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("promote logic changed");
        }
        private int CalculateRating(bool ignoreOrder)
        {
            return 0;
        }
    }
}