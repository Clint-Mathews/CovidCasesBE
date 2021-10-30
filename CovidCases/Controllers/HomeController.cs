using CovidCases.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CovidCases.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<CovidData> Get()
        {
            var rng = new CovidData();
            List<CovidData> data = new List<CovidData>();
            data.Add(rng);
            return data;
        }
    }
}
