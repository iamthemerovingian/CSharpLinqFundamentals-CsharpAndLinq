using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndCSharpMili
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipCode = "678992";

            bool result1 = StringExtensions.IsValidPostalCode(zipCode);

            bool result2 = zipCode.IsValidPostalCode();
        }
    }
}
