using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqAndCSharp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidPostalCode(this string value)
        {
            return value.Length == 5 || value.Length == 9;
        }
    }
}
