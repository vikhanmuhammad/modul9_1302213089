using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System;
using test3;
using modul9_1302213089;

namespace test3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MovieController : Controller
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie(
                "The Shawshank Redemption",
                "Frank Darabont",
                new List<string>(new[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }),
                "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion"
            ),
            new Movie
            (
                "The Godfather",
                "Francis Ford Coppola",
                new List<string>(new[]{ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" }),
                "The aging patriarch of an organized crime dynasty in postwar " +
                "New York City transfers control of his clandestine empire to his reluctant youngest son."
            ),
            new Movie
            (
                "The Dark Knight",
                " Christopher Nolan",
                new List<string>( new[] {"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" }),
                "When the menace known as the Joker wreaks havoc and chaos " +
                "on the people of Gotham, Batman must accept one of the greatest psychological " +
                "and physical tests of his ability to fight injustice."
            )
        };


        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie value)
        {
            movies[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}