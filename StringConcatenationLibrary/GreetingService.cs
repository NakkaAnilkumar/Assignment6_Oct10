using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingLibrary
{
    public delegate void GreetingHandler(string name);

    public class GreetingService
    {
        public event GreetingHandler Greet;

        public void PerformGreeting(string name)
        {
            if (Greet != null)
            {
                Greet(name);
            }
        }
    }
}
