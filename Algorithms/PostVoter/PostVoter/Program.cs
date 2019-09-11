using System;
using System.Dynamic;

namespace PostVoter
{
    public class Program
    {
        public static void Main()
        {
            var post = new Post("How to Cook", "some recipes", DateTime.Now );
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.Votes);
            post.DownVote();
            Console.WriteLine(post.Votes);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.Votes);
            post.DownVote();
            Console.WriteLine(post.Votes);
        }
    }

    public class Post
    {
        public string Description;
        public string Title;
     
        private int _votes = 0;
        public int Votes { get; private set; }
        public DateTime TimeCreated { get; private set; }

        public Post(string title, string description, DateTime timeCreated)
        {
            this.Title = title;
            this.Description = description;
            TimeCreated = timeCreated;
        }
        public void UpVote() => Votes += 1;
        public void DownVote() => Votes -= 1;
    }
}
