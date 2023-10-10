using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizationLibrary
{
    public delegate void CapitalizationHandler(string input);

    public class CapitalizationService
    {
        public event CapitalizationHandler Capitalize;

        public void PerformCapitalization(string input)
        {
            if (Capitalize != null)
            {
                string capitalized = char.ToUpper(input[0]) + input.Substring(1);
                Capitalize(capitalized);
            }
        }
    }
}
