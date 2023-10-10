using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StringLengthLibrary
{
    // Create a delegate for finding the length of a string
    public delegate int FindLength(string s);

    public class StringHelper
    {
        public int CalculateLength(string s)
        {
            return s.Length;
        }
    }
}
