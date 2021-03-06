using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class InsertIntervalTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(IList<Interval> intervals, Interval newInterval, IList<Interval> output)
        {
            var result = Solution057.Insert(intervals, newInterval);
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
                IList<Interval> intervals = new List<Interval>{
                    new Interval(1, 3),
                    new Interval(6, 9)
                };
                Interval newInterval = new Interval(2, 5);
                IList<Interval> output = new List<Interval>{
                    new Interval(1, 5),
                    new Interval(6, 9)
                };
                driverData.Add(new object[] { intervals, newInterval, output });

                return driverData;
            }
        }
    }
}

