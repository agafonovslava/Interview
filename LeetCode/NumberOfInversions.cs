//https://www.algoexpert.io/questions/Count%20Inversions
/**********************************************************************************
Write a function that takes in an array of integers and returns the number of inversions.
An inversion occurs if for any valid indices's i and j, i < j and array[i] > array[j]
For example, given array = 3, 4, 1, 2 there are 4 inversions. The following pairs of indices's
represent inversion: [0, 2], [0, 3], [1, 2], [1, 3]
Intuitively, the number of inversions is a measure of how unsorted the array is.
**********************************************************************************/

namespace Algorithms
{
    using System.Collections.Generic;

    public class NumberOfInversionsHelper
    {
        // O (nlogn) time | O(n) space where n is the length of the array
        // input: 2,3,3,1,9,5,6
        // output: 5
        // 0 inversions if array sorted
        public static int CountInversions(int[] array)
        {
            return countSubArrayInversions(array, 0, array.Length);
        }

        public static int countSubArrayInversions(int[] array, int start, int end)
        {
            if (end - start <= 1)
                return 0;
            int middle = start + (end - start) / 2;
            int leftInversions = countSubArrayInversions(array, start, middle);
            int rightInversions = countSubArrayInversions(array, middle, end);
            int mergedArrayInversions = mergeSortAndCountInversions(array, start, middle, end);
            return leftInversions + rightInversions + mergedArrayInversions;
        }

        public static int mergeSortAndCountInversions(int[] array, int start, int middle, int end)
        {
            List<int> sortedArray = new List<int>();
            int left = start;
            int right = middle;
            int inversions = 0;

            while (left < middle && right < end)
            {
                if (array[left] <= array[right])
                {
                    sortedArray.Add(array[left]);
                    left += 1;
                }
                else
                {
                    inversions += middle - left;
                    sortedArray.Add(array[right]);
                    right += 1;
                }
            }

            for (int idx = left; idx < middle; idx++)
                sortedArray.Add(array[idx]);

            for (int idx = right; idx < end; idx++)
                sortedArray.Add(array[idx]);

            for (int idx = 0; idx < sortedArray.Count; idx++)
            {
                int num = sortedArray[idx];
                array[start + idx] = num;
            }

            return inversions;
        }
    }
}