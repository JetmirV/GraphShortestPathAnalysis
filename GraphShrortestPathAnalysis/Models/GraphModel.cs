using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphShortestPathAnalysis.Models
{
    public class GraphModel
    {
        public List<List<int>> InitialPoints { get; set; }
        public List<string> Connections { get; set; }
    }
}
