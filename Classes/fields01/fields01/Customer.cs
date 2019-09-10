using System.Collections.Generic;

namespace fields01
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this (id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //readonly makes this not allowed to happen
            //this would reset list otherwise
            Orders = new List<Order>();
        }
    }
}