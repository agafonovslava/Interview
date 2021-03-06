using System.Collections.Generic;

namespace Algorithms.Utils
{
    /// <summary>
    /// Write a function that makes in an integer matrix of potentially unequal height and width, and
    /// returns the minimum of passes required to convert all negative integers in matrix to positive integers.
    /// An negative integer in matrix can only be converted to a positive int if one or more of its adjacent
    /// elements is positive. An adjacent element is an element that is to the left, to the right, above,
    /// or below the current element in the matrix. Converting a negative to a positive simply involves multiplying
    /// it by -1. Note that the 0 value is neither positive nor negative, meaning that a 0 cant convert an
    /// adjacent negative to a positive. A single pass through the matrix involves converting all the negative
    /// integers that can be converted at a particular point in time. For example:
    /// [
    ///     [0,-1,-3,2,0],
    ///     [1,-2,-5,-1,-3],
    ///     [3,0,0,-4,-1],
    /// ]
    /// Output: 3
    /// 
    /// https://www.algoexpert.io/questions/Minimum%20Passes%20Of%20Matrix
    /// </summary>
    public class MatrixMinimumPasses
    {
        //O (w * h) time | O(w * h) space - where w is the width of the matrix and h is the height
        public int MinimumPassesOfMatrix(int[][] matrix)
        {
            int passes = convertNegatives(matrix);
            return (!containsNegative(matrix)) ? passes - 1 : -1;
        }

        public int convertNegatives(int[][] matrix)
        {
            Queue<int[]> queue = getAllPositivePositions(matrix);
            int passes = 0;
            while (queue.Count != 0)
            {
                int currentSize = queue.Count;
                while (currentSize > 0)
                {
                    int[] vals = queue.Dequeue();
                    int currentRow = vals[0];
                    int currentCol = vals[1];

                    List<int[]> adjacentPositions = getAdjacentPositions(currentRow, currentCol, matrix);
                    foreach (var position in adjacentPositions)
                    {
                        int row = position[0];
                        int col = position[1];
                        int value = matrix[row][col];
                        if (value < 0)
                        {
                            matrix[row][col] *= -1;
                            queue.Enqueue(new int[] { row, col });
                        }
                    }
                    currentSize -= 1;
                }
                passes += 1;
            }
            return passes;
        }

        public Queue<int[]> getAllPositivePositions(int[][] matrix)
        {
            Queue<int[]> positivePositions = new Queue<int[]>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int value = matrix[row][col];
                    if (value > 0)
                    {
                        positivePositions.Enqueue(new int[] { row, col });
                    }
                }
            }
            return positivePositions;
        }

        public List<int[]> getAdjacentPositions(int row, int col, int[][] matrix)
        {
            List<int[]> adjacentPositions = new List<int[]>();

            if (row > 0)
            {
                adjacentPositions.Add(new int[] { row - 1, col });
            }

            if (row < matrix.Length - 1)
            {
                adjacentPositions.Add(new int[] { row + 1, col });
            }

            if (col > 0)
            {
                adjacentPositions.Add(new int[] { row, col - 1 });
            }

            if (col < (matrix[0].Length - 1))
            {
                adjacentPositions.Add(new int[] { row, col + 1 });
            }
            return adjacentPositions;
        }

        public bool containsNegative(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var value in row)
                {
                    if (value < 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}