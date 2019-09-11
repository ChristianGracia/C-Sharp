using System;
using System.Dynamic;

namespace PostVoter
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post("How to Cook", "some recipes", DateTime.Now );
        }
    }

    class Post
    {
        private int _vote;
        public string Description;
        public string Title;
        public DateTime TimeCreated { get; private set; }

        public Post(string title, string description, DateTime timeCreated)
        {
            this.Title = title;
            this.Description = description;
            TimeCreated = timeCreated;
            _vote = 0;
        }

 



    }
}
