using System;
using System.Linq;

namespace sorting_algorithm
{
    public class Program
    {
        public static string GetForm(string query)
        {
            return query
                .Split(new [] { ' ' })
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate((x, y) => x + " " + y);
        }
    }
}
