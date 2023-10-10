using StringLengthLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLengthLibrary;

namespace Assignment6
{
    public class lengthMain
    {
        static void Main()
        {

            // Create an instance of the StringHelper class from the library
            var stringHelper = new StringLengthLibrary.StringHelper();

            // Create a delegate instance pointing to the CalculateLength method
            FindLength findLength = stringHelper.CalculateLength;

            // Input string from the user
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            // Use the delegate to find the length of the string
            int length = findLength(inputString);

            // Display the result
            Console.WriteLine($"The length of the string is: {length}");
            Console.ReadLine();
        }
    }

}
