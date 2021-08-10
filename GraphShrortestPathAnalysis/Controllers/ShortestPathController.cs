﻿using GraphShortestPathAnalysis.Helpers;
using GraphShortestPathAnalysis.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphShrortestPathAnalysis.Controllers
{
    public class ShortestPathController : Controller
    {
        private static GraphGenerator _graphGenerator = new GraphGenerator();
        public IActionResult Index()
        {
            var graphModel = new GraphModel();
            graphModel.InitialPoints = _graphGenerator.GenerateRandomGraph();
            graphModel.Connections = _graphGenerator.GenerateEdges();
            return View(graphModel);
        }
        [HttpGet]
        public IActionResult GenerateRandoGraph()
        {
            var data = string.Empty;
            return Json(data);
        }
    }
}