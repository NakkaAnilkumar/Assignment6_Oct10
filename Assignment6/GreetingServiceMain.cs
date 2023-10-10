using GreetingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetingLibrary;

namespace Assignment6
{
    public class GreetingServiceMain
    {
        static void Main()
        {
            var greetingService = new GreetingService();
            greetingService.Greet += GreetUser;

            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            greetingService.PerformGreeting(userName);

            Console.ReadLine();


        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to the program.");
        }


    }
    
}
