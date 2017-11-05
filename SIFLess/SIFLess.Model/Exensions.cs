using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model
{
    public static class Exensions
    {
        public static string EnsureEndsWith(this string input, string check)
        {
            if (!input.EndsWith(check))
                return input + check;

            return input;
        }
    }
}
