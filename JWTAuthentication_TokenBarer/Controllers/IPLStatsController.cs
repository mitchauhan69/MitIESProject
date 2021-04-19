using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class IPLStatsController : ControllerBase
    {
        private readonly List<IPLStats> IPLStats = new List<IPLStats>()
        {
            new IPLStats { Id = 1, Team = "MI", Name = "Mumbai Indians", Wins = 5, Home = "Wankhede" },
            new IPLStats { Id = 2, Team = "CSK", Name = "Chennai Super Kings", Wins = 3, Home = "Chepauk" },
            new IPLStats { Id = 3, Team = "RR", Name = "Rajasthan Royals", Wins = 1, Home = "Sawai Mansingh" },
            new IPLStats { Id = 4, Team = "PBKS", Name = "Punjab Kings", Wins = 0, Home = "PCA" },
            new IPLStats { Id = 5, Team = "SRH", Name = "Sunrisers Hyderabad", Wins = 2, Home = "Rajiv Gandhi" },
            new IPLStats { Id = 6, Team = "DC", Name = "Delhi Capitals", Wins = 0, Home = "Feroz Shah Kotla" },
            new IPLStats { Id = 7, Team = "KKR", Name = "Kolkata Knight Riders", Wins = 2, Home = "Eden Gardens" },
            new IPLStats { Id = 8, Team = "RCB", Name = "Royal Challengers Bangalore", Wins = 0, Home = "M. Chinnaswamy" }
        };

        private readonly ILogger<IPLStatsController> _logger;

        public IPLStatsController(ILogger<IPLStatsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<IPLStats> GetAll()
        {
            return IPLStats;
        }

        [HttpGet("{Id:int}")]
        public IPLStats GetOne(int Id)
        {
            return IPLStats.SingleOrDefault(m => m.Id == Id);
        }
    }
}