using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public static class SwapNumber
    {
        public static void SwapNumbers(ref int numA, ref int numB)
        {
            numA = (numA + numB) - (numB = numA);
        }
    }
}
