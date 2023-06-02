using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movies.Api.Movies
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/Movies
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new Movie[]
            {
                new Movie
                {
                    Id   = Guid.NewGuid(),
                    Title = "Nick of time",
                    YearOfRelease = 1995,
                    Genres = new []{ "Crime", "Thriller"}
                },
                new Movie
                {
                    Id   = Guid.NewGuid(),
                    Title = "Jurassic Park",
                    YearOfRelease = 1993,
                    Genres = new []{ "Adventure", "Sci-fi"}
                }
            };
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Movies
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
