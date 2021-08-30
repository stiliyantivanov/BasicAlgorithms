using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_And_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 1, 2, 3, 4, 7, 6, 20, 15, 0, 19, 11, 12, 13, 14, 10, 17, 16, 18, 9, 5};
            int[] sortedArray = Sort.BubbleSort(array);
            Console.WriteLine(String.Join(", ", sortedArray));
        }
    }
}
