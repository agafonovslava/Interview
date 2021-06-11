using System;

namespace Algorithms.Utils
{
    /// <summary>
    /// https://www.algoexpert.io/questions/Two-Edge-Connected%20Graph
    /// </summary>
    public class GraphTwoEdgeConnected
    {
        //you are given a list of edges representing and unweighted and undirected graph.
        //Write a function that returns a boolean representing whether the given graph is two-edge-connected.
        //A graph is connected if for every pair of vertices's in the graph, there are a path of 
        //one or more edges connecting the given vertices's.
        //A graph that is not connected is said to be disconnected.
        //A graph is two-edge-connected if, for every one of its edges, the edge's removal from the graph
        //does not cause the graph to become disconnected. If the removal of any single edge disconnects the graph,
        //then it is not two edge connected. If the given graph is already disconnected, 
        //then it also is not two-edge-connected. An empty graph is considered two-edge-connected.
        //The input list is what's called an adjacency list, and it represents a graph. The number of vertices's in the
        //graph is equal to the length of edges, where each index i in edges contains vertex i outbound edges,
        //in no particular order. Each outbound edge is represented by a positive integer that denotes and index
        //(a destination vertex) in the list that this vertex is connected to. Note that these edges are undirected,
        //meaning that you can travel from a particular vertex to its destination and from the destination back to that vertex.
        //Since these edges are undirected, if vertex i has an outbound edge to vertex j, then vertex j is 
        //guaranteed to have an outbound edge to vertex i. For example, and undirected graph with two
        //vertices's and one edge would be represented by the following adjacency list edges = [[1], [0]].
        //Note that the input graph will never contain parallel edges 
        //(edges that share the same sources and destination vertices's). In other words, there will never be more than one edge
        //that connected the same two vertices's to each other.


        //O(v + e) time | O(v) space where v is the number of vertices's
        //and e is the number of edges in the graph
        public static bool TwoEdgeConnectedGraph(int[][] edges)
        {
            if (edges.Length == 0)
                return true;

            //store all arrival times as -1
            int[] arrivalTimes = new int[edges.Length];
            Array.Fill(arrivalTimes, -1);
            int startVertex = 0;

            //DFS with minimum arrival time, if -1 then we found a bridge
            if (getMinimumArrivalTimeOfAcestors(startVertex, -1, 0, arrivalTimes, edges) == -1)
                return false;

            return areAllVerticesVisited(arrivalTimes);
        }

        private static bool areAllVerticesVisited(int[] arrivalTimes)
        {
            foreach (var time in arrivalTimes)
                if (time == -1)
                    return false;
            return true;
        }

        private static int getMinimumArrivalTimeOfAcestors(
            int currentVertex,
            int parent,
            int currentTime,
            int[] arrivalTimes,
            int[][] edges)
        {
            arrivalTimes[currentVertex] = currentTime;
            int minimumArrivalTime = currentTime;

            foreach (int destination in edges[currentVertex])
            {
                if (arrivalTimes[destination] == -1)
                {
                    minimumArrivalTime = Math.Min(
                        minimumArrivalTime,
                        getMinimumArrivalTimeOfAcestors(
                            destination,
                            currentVertex,
                            currentTime + 1,
                            arrivalTimes,
                            edges));
                }
                else if (destination != parent)
                    minimumArrivalTime = Math.Min(minimumArrivalTime, arrivalTimes[destination]);
            }

            // A bridge was detected which means the graph is not two edge connected
            if (minimumArrivalTime == currentTime &&
                 parent != -1)
                return -1;

            return minimumArrivalTime;
        }
    }
}