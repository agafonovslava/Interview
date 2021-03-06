using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeIntervalsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(IList<Interval> intervals, IList<Interval> output)
        {
            var result = Solution056.Merge2(intervals);
            for (int i = 0; i < output.Count; i++)
            {
                Assert.Equal(output[i].start, result[i].start);
                Assert.Equal(output[i].end, result[i].end);
            }
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                IList<Interval> intervals = new List<Interval>() {
                    new Interval(1,4),
                    new Interval(0,4)
                };
                IList<Interval> output = new List<Interval>() {
                    new Interval(0,4)
                };
                driverData.Add(new object[] { intervals, output });
                intervals = new List<Interval>() {
                    new Interval(8,10),
                    new Interval(1,3),
                    new Interval(2,6),
                    new Interval(15,18),
                };
                output = new List<Interval>() {
                    new Interval(1,6),
                    new Interval(8,10),
                    new Interval(15,18),
                };
                driverData.Add(new object[] { intervals, output });

                return driverData;
            }
        }
    }
}

