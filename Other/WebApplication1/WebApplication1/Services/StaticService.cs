using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class StaticService
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "bob",
                "mary",
                "john",
                "jane"
            };
        }
    }
}
