using Bibliotheca_Motus_Imaginibus_API.Context;
using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovie()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovies(Movie movie)
        {
            if (movie == null)
            {
                return BadRequest("A film paraméterei nem lehetnek üresek.");
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return Ok("Sikeresen létrehozva: " + movie.Title);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> UpdateMovie(int id, Movie updatedMovie)
        {
            if (updatedMovie == null)
            {
                return BadRequest("A frissítési adatok nem lehetnek üresek.");
            }

            var movieToUpdate = await _context.Movies.FindAsync(id);

            if (movieToUpdate == null)
            {
                return NotFound("A film nem található.");
            }

            movieToUpdate.Title = updatedMovie.Title;
            movieToUpdate.ReleasedDate = updatedMovie.ReleasedDate;
            movieToUpdate.Length = updatedMovie.Length;
            movieToUpdate.Genre = updatedMovie.Genre;

            await _context.SaveChangesAsync();
            return Ok("Sikeresen frissítve: " + movieToUpdate.Title);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound("A film nem található.");
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return Ok("Sikeresen törölve: " + movie.Title);
        }
    }
}
