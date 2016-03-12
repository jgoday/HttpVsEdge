using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestEdge
{
    public class Startup
    {
        private int _count = 0;

        public async Task<object> CreatePerson(string input)
        {
            var p = new Person(input);
            _count++;

            return await Task.FromResult(p);
        }
    }
}
