// #56 : https://leetcode.com/problems/merge-intervals/ 
/**********************************************************************************
* Given a collection of intervals, merge all overlapping intervals.
* For example,
* Given [1,3],[2,6],[8,10],[15,18],
* return [1,6],[8,10],[15,18].
Example 1:
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:
Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
Constraints:
1 <= intervals.length <= 10^4
intervals[i].length == 2
0 <= starti <= endi <= 10^4
**********************************************************************************/

using Algorithms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms
{
    /**
     * Definition for an interval.
     * public class Interval {
     *     public int start;
     *     public int end;
     *     public Interval() { start = 0; end = 0; }
     *     public Interval(int s, int e) { start = s; end = e; }
     * }
     */
    public class Solution056
    {
        public static IList<Interval> Merge(IList<Interval> intervals)
        {
            var lstResult = new List<Interval>();
            if (intervals == null || intervals.Count == 0) return lstResult;
            intervals = intervals.OrderBy(x => x.start).ToList();
            var start = intervals[0].start;
            var end = intervals[0].end;
            for (var i = 1; i < intervals.Count; i++)
            {
                if (intervals[i].start > end)
                {
                    lstResult.Add(new Interval(start, end));
                    start = intervals[i].start;
                    end = intervals[i].end;
                }
                else if (intervals[i].end > end)
                {
                    end = intervals[i].end;
                }
            }
            lstResult.Add(new Interval(start, end));
            return lstResult;
        }
        public static IList<Interval> Merge2(IList<Interval> intervals)
        {
            IList<Interval> res = new List<Interval>();
            if (intervals == null || intervals.Count == 0) return intervals;
            Comparison<Interval> compare = (i1, i2) =>
            {
                return i1.start == i2.start ?
                    Comparer<int>.Default.Compare(i1.end, i2.end) :
                    Comparer<int>.Default.Compare(i1.start, i2.start);
            };
            intervals.Sort(compare);
            res.Add(intervals[0]);

            for (int i = 1; i < intervals.Count; i++)
            {
                if (res[res.Count - 1].end >= intervals[i].start)
                {
                    res[res.Count - 1].end = Math.Max(res[res.Count - 1].end, intervals[i].end);
                }
                else
                {
                    res.Add(intervals[i]);
                }
            }
            return res;
        }
    }
}

