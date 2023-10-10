using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalizationLibrary;

namespace Assignment6
{
    public class CapitalizationServiceMain
    {

        static void Main()
        {
            var capitalizationService = new CapitalizationLibrary.CapitalizationService();
            capitalizationService.Capitalize += CapitalizeFirstCharacter;

            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            capitalizationService.PerformCapitalization(inputString);

            Console.ReadLine();
        }

        static void CapitalizeFirstCharacter(string input)
        {
            Console.WriteLine($"Capitalized string: {input}");

        }
    }
}
