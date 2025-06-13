using Microsoft.AspNetCore.Mvc;
using modul9_NIM.Models;
using System.Collections.Generic;

namespace modul9_NIM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Mahasiswa> Movies = new List<Mahasiswa>
        {
            new Mahasiswa
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Mahasiswa
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Mahasiswa
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman battles the Joker to save Gotham City."
            }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get() => Movies;

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            return Movies[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa movie)
        {
            Movies.Add(movie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            Movies.RemoveAt(id);
            return Ok();
        }
    }
}
