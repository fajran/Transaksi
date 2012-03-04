using System;
using System.Collections.Generic;
using System.Text;

namespace Transaksi
{
    public class Utils
    {
        public static bool IsNumeric(char ch)
        {
            return !char.IsControl(ch) && !char.IsDigit(ch);
        }

    }
}
