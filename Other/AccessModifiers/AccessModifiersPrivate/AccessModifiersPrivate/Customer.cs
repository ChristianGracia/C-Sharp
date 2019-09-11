using System;

namespace AccessModifiersPrivate
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(ignoreOrder: true);

            Console.WriteLine(rating == 0 ? "promoted to customer level 1" : "promoted to customer level 2");
        }
        private int CalculateRating(bool ignoreOrder)
        {
            return 0;
        }
    }
}