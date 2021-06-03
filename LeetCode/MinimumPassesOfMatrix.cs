namespace Algorithms.Utils
{
    using System.Collections.Generic;
    public class AlgoExpertMinimumPassesOfMatrix
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
                    int[] values = queue.Dequeue();
                    int currentRow = values[0];
                    int currentCol = values[1];

                    List<int[]> adjacentPositions = getAdjacentPositions(currentRow, currentCol, matrix);
                    for (int i = 0; i < adjacentPositions.Count; i++)
                    {
                        int[] position = adjacentPositions[i];
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
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int value = matrix[row][col];
                    if (value > 0)
                    {
                        positivePositions.Enqueue(new int[] { row, col });
                    }
                }
            return positivePositions;
        }

        public List<int[]> getAdjacentPositions(int row, int col, int[][] matrix)
        {
            List<int[]> adjacentPositions = new List<int[]>();
            if (row > 0) adjacentPositions.Add(new int[] { row - 1, col });
            if (row < matrix.Length - 1) adjacentPositions.Add(new int[] { row + 1, col });
            if (col > 0) adjacentPositions.Add(new int[] { row, col - 1 });
            if (col < (matrix[0].Length - 1)) adjacentPositions.Add(new int[] { row, col + 1 });
            return adjacentPositions;
        }

        public bool containsNegative(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    int value = row[i];
                    if (value < 0)
                        return true;
                }
            }

            return false;
        }
    }
}