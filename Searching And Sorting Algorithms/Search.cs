using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_And_Sorting_Algorithms
{
    public static class Search
    {
        public static int BinarySearch(int[] array, int number, int start = 0, int end = -1)
        {
            if (end == -1) end = array.Length - 1;
            while(start<=end)
            {
                int index = (start + end) / 2;
                if (array[index] == number) return index;
                if (number < array[index]) end = index - 1;
                else start = index + 1;
            }
            return -1;
        }

        public static int JumpSearch(int[] array, int number)
        {
            int step = (int)Math.Floor(Math.Sqrt(array.Length));
            int i = 0, end = 0;
            while (i*step<array.Length)
            {
                if(array[step * i]>number)
                {
                    end = step * i;
                    break;
                }
                else if(array[step * i] == number) return step * i;
                i += 1;
            }
            if(i*step >= array.Length) end = array.Length - 1;
            for(int j=end; j>end - step; j--)
            {
                if (array[j] == number) return j;
            }
            return -1;
        }

        public static int InterpolationSearch(int[] array, int number)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start != end)
            {
                int position = Position(array, start, end, number);
                if (position <= end && position >= start)
                {
                    if (number == array[position]) return position;
                    else if (number < array[position]) end = position;
                    else start = position;
                }
                else return -1;
            }
            return -1;
        }

        public static int InterpolationSearchRecursive(int[] array, int number, int start= 0, int end = -1)
        {
            if (end == -1) end = array.Length - 1;
            if(start != end)
            {
                int position = Position(array, start, end, number);
                if (position <= end && position >= start)
                {
                    if (number == array[position]) return position;
                    else if (number < array[position]) return InterpolationSearchRecursive(array, start, position, number);
                    else return InterpolationSearchRecursive(array, position, end, number);
                }
            }
            return -1;
        }

        public static int ExponentialSearch(int[] array, int number)
        {
            int i = 1;
            while(i<array.Length && array[i - 1]<=number)
            {
                if (array[i - 1] == number) return i - 1;
                i *= 2;
            }
            if(i>=array.Length) return BinarySearch(array, number, i / 2, array.Length - 1);
            else return BinarySearch(array, number, i / 2, i - 1);
        }

        private static int Position(int[] array, int start, int end, int number)
        {
            return start + (number - array[start])*(end - start)/(array[end] - array[start]);
        }
    }
}
