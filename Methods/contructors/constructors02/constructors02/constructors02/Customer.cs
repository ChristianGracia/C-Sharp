using System.Collections.Generic;

namespace constructors02
{
    public class Customer
    {
        public string Name;
        public int Id;

        public List<Order> Orders;

        //param-less constructor
        public Customer()
        {
            //make sure always initialized
            Orders = new List<Order>();
            
        }
        public Customer(int id)
  
            : this(){ this.Id = id; 
  

        }


        // passes constructor to next constructor
        public Customer(int id, string name)
        : this(id)
        {
    
            this.Name = name;
        }

    }

}