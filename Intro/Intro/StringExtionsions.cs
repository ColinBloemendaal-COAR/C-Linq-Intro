using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public static class StringExtensions
    {
        public static string FormattedPhoneNumber(this string phone,
        string separator)
        {
            return phone.Substring(0, 3) + separator
            + phone.Substring(3, 3) + separator
            + phone.Substring(6, 4);
        }
    }

}
