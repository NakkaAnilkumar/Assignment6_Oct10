using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringConcatenationLibrary;





namespace Assignment6
{
    public class Program
    {

        static void Main()
        {
     

            Console.Write("Enter the first string: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string input2 = Console.ReadLine();

            StringConcatenationLibrary.StringConcatenator concatenator = new StringConcatenationLibrary.StringConcatenator();

            StringConcatenationLibrary.AttachStringToEachOther concatDelegate = concatenator.ConcatStrings;

            string result = concatDelegate(input1, input2);

            Console.WriteLine("Concatenated result: " + result);
            Console.ReadLine();

            





        }

    }
}
