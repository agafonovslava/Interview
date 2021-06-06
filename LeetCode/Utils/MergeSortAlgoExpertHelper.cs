namespace Algorithms.Utils
{
    using System.Linq;

    /// <summary>
    /// Write a function that takes in an array of integers and returns a sorted version of that array.
    /// Use the Merge Sort algorithm to sort the array. 
    /// </summary>
    public class MergeSortAlgoExpertHelper
    {
        //Best: O(nlog(n)) time | O(n) space
        //Average: O(nlog(n)) time | O(n) space
        //Worst: O(nlog(n)) time | O(n) space
        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int[] auxiliaryArray = (int[])array.Clone();
            MergeSort(array, 0, array.Length - 1, auxiliaryArray);
            return array;
        }

        public static void MergeSort(int[] mainArray, int startIdx, int endIdx, int[] auxiliaryArray)
        {
            if (startIdx == endIdx)
                return;
            int middleIdx = (startIdx + endIdx) / 2;
            MergeSort(auxiliaryArray, startIdx, middleIdx, mainArray);
            MergeSort(auxiliaryArray, middleIdx + 1, endIdx, mainArray);
            int k = startIdx;
            int i = startIdx;
            int j = middleIdx + 1;
            while (i <= middleIdx && j <= endIdx)
            {
                if (auxiliaryArray[i] <= auxiliaryArray[j])
                    mainArray[k++] = auxiliaryArray[i++];
                else
                    mainArray[k++] = auxiliaryArray[j++];
            }
            while (i <= middleIdx)
                mainArray[k++] = auxiliaryArray[i++];
            while (j <= endIdx)
                mainArray[k++] = auxiliaryArray[j++];
        }

        //Best: O(nlog(n)) time | O(nlog(n)) space
        //Average: O(nlog(n)) time | O(nlog(n)) space
        //Worst: O(nlog(n)) time | O(nlog(n)) space
        public static int[] MergeSort2(int[] array)
        {
            if (array.Length <= 1)
                return array;
            int middleIdx = array.Length / 2;
            int[] leftHalf = array.Take(middleIdx).ToArray();
            int[] rightHalf = array.Skip(middleIdx).ToArray();
            return mergeSortedArrays(MergeSort(leftHalf), MergeSort(rightHalf));
        }

        public static int[] mergeSortedArrays(int[] leftHalf, int[] rightHalf)
        {
            int[] sortedArray = new int[leftHalf.Length + rightHalf.Length];
            int k = 0;
            int i = 0;
            int j = 0;
            while (i < leftHalf.Length && j < rightHalf.Length)
            {
                if (leftHalf[i] <= rightHalf[j])
                    sortedArray[k++] = leftHalf[i++];
                else
                    sortedArray[k++] = rightHalf[j++];
            }
            while (i < leftHalf.Length)
                sortedArray[k++] = leftHalf[i++];
            while (j < rightHalf.Length)
                sortedArray[k++] = rightHalf[j++];
            return sortedArray;
        }
    }
}