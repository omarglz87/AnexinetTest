using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public static class AddNumbers
    {
        public static int Sum(int numA, int numB)
        {
            // Iterate till there is no carry
            while (numB != 0)
            {
                // carry now contains common set bits of numA and numB
                int carry = numA & numB;

                // Sum of bits of numA and numB where at least one of the bits is not set
                numA = numA ^ numB;

                // Carry is shifted by one so that adding it to numA gives the required sum
                numB = carry << 1;
            }
            return numA;
        }
    }
}
