using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public static class CommonItems
    {
        public static int[] CommonItemsInArrays(int[][] elementsLists)
        {
            if (elementsLists.Length > 0)
            {
                for (int i = 0; i < elementsLists.Length; i++)
                    Array.Sort(elementsLists[i]);

                int count = 0;
                int position = MinLengthArrayPosition(elementsLists);
                int[] minLengthArray = elementsLists[position];

                int[] commonItems = new int[minLengthArray.Length];
                for (int x = 0; x < minLengthArray.Length; x++)
                {
                    bool isCommon = true;
                    int current = minLengthArray[x];
                    for (int i = 0; i < elementsLists.Length; i++)
                    {
                        if (current != elementsLists[i][x])
                        {
                            isCommon = false;
                            break;
                        }
                    }
                    if (isCommon)
                    {
                        commonItems[x] = current;
                        count++;
                    }
                }

                return commonItems.SubArray(0, count);
            } else
            {
                return new int[0];
            }
        }

        public static int MinArrayLength(int[][] elementsLists)
        {
            int minLength = elementsLists[0].Length;
            for (int i = 0; i < elementsLists.Length; i++)
            {
                if(elementsLists[i].Length < minLength)
                    minLength = elementsLists[i].Length;
            }
            return minLength;
        }

        public static int MinLengthArrayPosition(int[][] elementsLists)
        {
            int minLength = elementsLists[0].Length, postition = 0;
            for (int i = 0; i < elementsLists.Length; i++)
            {
                if (elementsLists[i].Length < minLength)
                {
                    minLength = elementsLists[i].Length;
                    postition = i;
                }
            }
            return postition;
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
