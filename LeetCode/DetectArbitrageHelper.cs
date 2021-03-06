namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    //Problem: Detect Arbitrage
    //You are given a two dimensional array(a matrix) of equal height and width
    //that represents the exchange rates of arbitrary currencies. The length of the 
    //array is the number of currencies, and every currency can be converted to every other
    //currency. Each currency is represented by a row in the array, where values in that
    //row are the floating-point exchange rates between the rows currency and all other
    //currencies, as in the example below
    //			0:USD	1:CAD	2:GBP
    //0:USD [1.0,		1.27,	0.718]
    //1:CAD [0.74,	1.0,	0.56]
    //2:GBP [1.39,	1.77,	1.0]
    //In the matrix above you can see that row 0 represents USD which means that row 0
    //contains exchange rates for 1 USD to all other currencies. SInce row 1 represents CAD,
    //index 1 in the USD row contains the exchange for 1 USD to CAD.
    //Write a function that returns a boolean representing whether an arbitrage opportunity exists
    //with the given exchange rates. An arbitrage occurs if you can start with C units
    //of one currency and execute a series of exchanges that lead you to having more than C
    //units of the same currency you started with
    //NOTE: currency exchange rates won't represent real world exchange rates, and there 
    //might be multiple ways to generate an arbitrage.

    //Input: [[1.0,0.8631,0.5903],[1.1586,1.0,0.6849],[1.6939,1.46,1.0]]
    //Output: true

    //Solution:
    //Finding a cycle whose edges multiply to more than 1, finding cycle whose
    //edges add up to a negative value (a negative weight cycle) is common.
    //We could change all edges in the graph to be their negative logarithm.
    //In other words, create a new matrix of exchange rates, where very value
    //is the negative logarithm of the original exchange rate. Once this is done,
    ///we can use the Bellman Ford algorithm to detect the presence of a negative weight
    //cycle in the graph. If you detect a negative weight cycle then an arbitrage exists.
    //log(a * b) = log(a) + log(b)
    public class DetectArbitrageHelper
    {

        //O(n^3) time | O(n^2) space where n is the number of currencies
        public bool DetectArbitrage(List<List<double>> exchangeRates)
        {
            //To use exchange rates as edge weights, we must be able to add them.
            //Since log (a * b)  = log(a) + log(b) we can convert all rates to 
            //-log10(rate) to use them as edge weights.
            List<List<double>> newMatrix = new List<List<double>>();
            for (int row = 0; row < exchangeRates.Count; row++)
            {
                List<double> rates = exchangeRates[row];
                newMatrix.Add(new List<double>());

                foreach (var rate in rates)
                    newMatrix[row].Add(-Math.Log10(rate));
            }

            //A negative weight cycle indicates an arbitrage
            double[] distancesFromStart = new double[newMatrix.Count];
            Array.Fill(distancesFromStart, double.MaxValue);
            distancesFromStart[0] = 0;
            for (int unused = 0; unused < newMatrix.Count; unused++)
            {
                //if no update occurs, that means there is no negative cycle
                if (!relaxEdgesAndUpdateDistances(newMatrix, distancesFromStart))
                    return false;
            }

            return relaxEdgesAndUpdateDistances(newMatrix, distancesFromStart);
        }

        //Returns true if any distance was updated
        public bool relaxEdgesAndUpdateDistances(List<List<double>> graph, double[] distances)
        {
            bool updated = false;
            for (int sourcesIdx = 0; sourcesIdx < graph.Count; sourcesIdx++)
            {
                List<double> edges = graph[sourcesIdx];
                for (int destinationIdx = 0; destinationIdx < edges.Count; destinationIdx++)
                {
                    double edgeWeight = edges[destinationIdx];
                    double newDistanceToDistination = distances[sourcesIdx] + edgeWeight;

                    if (newDistanceToDistination < distances[destinationIdx])
                    {
                        updated = true;
                        distances[destinationIdx] = newDistanceToDistination;
                    }
                }
            }
            return updated;
        }
    }
}