using System;
using System.Security.Cryptography;

namespace nested_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //see classes for nested conditionals refactor examples
            //take conditionals and extract method
        }
    }


    //Cancel method below was simplified from 6+ conditionals to be much more readable

    public class Customer
    {
        public int LoyaltyPoints { get; set; }

        public bool IsGoldCustomer()
        {
            return LoyaltyPoints > 100;
        }
    }

    public class Reservation
    {
        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        private bool IsCancellationPeriodOver()
        {
            return (Customer.IsGoldCustomer() && LessThan(24)) ||
                   !Customer.IsGoldCustomer() && LessThan(48);
        }

        private bool LessThan(int maxHours)
        {
            return (From - DateTime.Now).TotalHours < maxHours;
        }
    }
}
