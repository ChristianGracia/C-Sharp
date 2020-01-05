using System;
using System.Net.WebSockets;

namespace Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "christian";
            Console.WriteLine(cookie["name"]);
        }
    }
}
