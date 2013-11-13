using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTray
{
    public static class StringExtensions
    {
        public static string FormatWith(this string formatString, params object[] args)
        {
            return string.Format(formatString, args);
        }
    }
}
