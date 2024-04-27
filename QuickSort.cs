using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgorithm
{
    public static class QuickSort
    {
        public static void Main()
        {
            int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            int[] sortedArr = SortArray(array, 0, array.Length-1);
            PrintArray(sortedArr);
        }
        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);

            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;
        }        

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
