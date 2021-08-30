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
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int number = int.Parse(Console.ReadLine());
            int result = Search.ExponentialSearch(array, number);
            Console.WriteLine(result);
        }
    }
}
