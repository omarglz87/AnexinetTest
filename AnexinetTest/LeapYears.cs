using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public class LeapYears
    {
        public static int[] LeapYearList(int initYear, int quantity = 1)
        {
            int[] result = quantity > 0? new int[quantity] : new int[1];
            int firstLeapYear = GetNextLeapYear(initYear);

            result[0] = firstLeapYear;
            for (int i = 1; i < quantity ; i++)
            {
                result[i] = IsLeapYear(result[i-1] + 4) ? result[i - 1] + 4 : GetNextLeapYear(result[i - 1] + 4);
            }

            return result;
        }

        public static int GetNextLeapYear(int initYear)
        {
            while (true)
            {
                if(IsLeapYear(initYear))
                    return initYear;
                initYear++;
            }
        }

        public static bool IsLeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }
    }
}
