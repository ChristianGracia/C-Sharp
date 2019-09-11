using System;

namespace AccessModifiers2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(ignoreOrder: true);

            if (rating == 0)
                Console.WriteLine("promoted to customer level 1");
            else
            {
                Console.WriteLine("promoted to customer level 2");
            }

        }

        private int CalculateRating(bool ignoreOrder)
        {
            return 0;
        }
    }
}