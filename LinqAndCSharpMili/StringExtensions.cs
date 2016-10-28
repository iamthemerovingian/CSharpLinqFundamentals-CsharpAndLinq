using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndCSharpMili
{
    public static class StringExtensions
    {
        public static bool IsValidPostalCode(this string text)
        {
            if (text.Length == 5 || text.Length== 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
