using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace core_k8s_favorites_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly List<Movie> movies = new List<Movie>
        {
            new Movie { ReleaseDate=DateTime.Parse("03/31/1995"), Title="Tommy Boy", Category="Comedy"},
            new Movie { ReleaseDate=DateTime.Parse("06/18/2004"), Title="Dodgeball", Category="Comedy"},
            new Movie { ReleaseDate=DateTime.Parse("03/27/1952"), Title="Singing in the Rain", Category="Musial"}
        };

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }
    }
}
