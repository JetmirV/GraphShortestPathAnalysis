using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphShortestPathAnalysis.Helpers
{
    public class GraphGenerator
    {
        private int _initialPointsCount;
        private bool isStartingGraph = true;
        public List<List<int>> GenerateRandomGraph(int limit)
        {
            var initialPoints = new List<List<int>>();

            Random rnd = new Random();
            for (int i = 0; i < limit; i++)
            {
                var x = rnd.Next(-600, 900);
                var y = rnd.Next(-400, 400);
                var pairs = new List<int>();
                pairs.Add(x);
                pairs.Add(y);

                initialPoints.Add(pairs);

            }
            _initialPointsCount = initialPoints.Count();
            isStartingGraph = false;
            return initialPoints;
        }
        public List<string> GenerateEdges(bool isRequest)
        {
            if (!isRequest)
            {
                return GetDefaultEdges();
            }
            var edges = new List<string>();
            var pointsList = new List<string>();
            for (int i = 0; i < _initialPointsCount; i++)
            {

                pointsList.Add(((char)(i + 65)).ToString());
            }

            Random random = new Random();

            var firstPoint = string.Empty;
            var secondPoint = string.Empty;
            var counter = 1;

            while (true)
            {
                if (counter > _initialPointsCount)
                {
                    break;
                }

                firstPoint = pointsList[random.Next(_initialPointsCount)];
                secondPoint = pointsList[random.Next(_initialPointsCount)];

                if (firstPoint == secondPoint)
                {
                    continue;
                }

                var edge = $"{firstPoint}_{secondPoint}";
                edges.Add(edge);
                counter++;
            }
            return edges;
        }

        public List<List<int>> StartingGraph()
        {
            var points = new List<List<int>>
            {
                new List<int> { -150, 50 },
                new List<int> { -130, -150 },
                new List<int> { -10, -70 },
                new List<int> { 0, 80 },
                new List<int> { 80, -70 },
                new List<int> { 130, -130 }               
            };
            _initialPointsCount = points.Count();
            return points;
        }

        private List<string> GetDefaultEdges()
        {
            return new List<string> {
                    "A_B",
                    "A_C",
                    "A_D",
                    "B_F",
                    "C_B",
                    "C_E",
                    "C_D",
                    "D_E",
                    "E_F"};
        }
    }
}
