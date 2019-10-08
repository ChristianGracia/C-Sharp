using System;
using System.Linq;

namespace sorting_algorithm
{
    public class Program
    {
        public static string GetForm(string query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            return query
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate((x, y) => x + " " + y)
                .Trim();
        }
    }
}
