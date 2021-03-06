// Algo Expert https://www.algoexpert.io/questions/Largest%20Rectangle%20Under%20Skyline

/**********************************************************************************
Largest Rectangle Under Skyline

Write a function that takes in an array of positive integers representing the heights of adjacent buildings
and returns the area of the largest rectangle that can be created by any number of adjacent buildings,
including just one building. note that all buildings have the same width of 1 unit.
For example, given buildings = [2, 1, 2], the area of the largest rectangle that can be created is 3, suing 
all three buildings. Since the minimum height of the three buildings is 1, you can create a rectangle
that has a height of 1 and widhth of 3 (the number of buildings). You could also create rectangels of area 2
by using only the first building or the last building but these clearly would be the largest rectangles.

**********************************************************************************/

namespace Algorithms
{
    using System.Collections.Generic;
    using System;
    public class Program
    {
        //O(n) time | O(n) space where n is the number of buildings
        public int LargestRectangleUnderSkyline(List<int> buildings)
        {
            Stack<int> pillarIndices = new Stack<int>();
            int maxArea = 0;
            List<int> extendedBuildings = new List<int>(buildings);
            extendedBuildings.Add(0);
            for (int idx = 0; idx < extendedBuildings.Count; idx++)
            {
                int height = extendedBuildings[idx];
                while (pillarIndices.Count != 0 &&
                     extendedBuildings[pillarIndices.Peek()] >= height)
                {
                    int pillarHeight = extendedBuildings[pillarIndices.Pop()];
                    int width = (pillarIndices.Count == 0) ? idx : idx - pillarIndices.Peek() - 1;
                    maxArea = Math.Max(width * pillarHeight, maxArea);
                }
                pillarIndices.Push(idx);
            }
            return maxArea;
        }
    }
}