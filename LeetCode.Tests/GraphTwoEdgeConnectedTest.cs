using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class GraphTwoEdgeConnectedTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]

        public void GraphTwoEdgeTest(int[][] edges, bool output)
        {
            Assert.Equal(output, GraphTwoEdgeConnected.TwoEdgeConnectedGraph(edges));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[][] edges = System.Array.Empty<int[]>();
                bool output = true;
                driverData.Add(new object[] { edges, output });

                edges = new int[][]
                {
                    new int[] { 1, 2, 3, 5 },
                    new int[] { 0, 2 },
                    new int[] { 0, 1 },
                    new int[] { 0, 4, 5 },
                    new int[] { 3, 5 },
                    new int[] { 3, 4, 0 },
                };

                output = true;
                driverData.Add(new object[] { edges, output });

                edges = new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 0, 2 },
                    new int[] { 0, 1 },
                    new int[] { 0, 4, 5 },
                    new int[] { 3, 5 },
                    new int[] { 3, 4 },
                };

                output = false;
                driverData.Add(new object[] { edges, output });

                edges = new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 0, 2, 3 },
                    new int[] { 1, 3, 0 },
                    new int[] { 1, 2 },
                };

                output = true;
                driverData.Add(new object[] { edges, output });

                return driverData;
            }
        }
    }
}