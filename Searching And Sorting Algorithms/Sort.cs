using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_And_Sorting_Algorithms
{
    public static class Sort
    {
        public static int[] BubbleSort(int[] array, bool asc = true)
        {
            int length = array.Length;
            if (asc)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    for (int j = 0; j < length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int swap = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = swap;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < length - 1; i++)
                {
                    for (int j = 0; j < length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int swap = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = swap;
                        }
                    }
                }
            }
            return array;
        }
    }
}
