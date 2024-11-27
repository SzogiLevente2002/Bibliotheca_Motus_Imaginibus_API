using System.Security.Claims;
using Bibliotheca_Motus_Imaginibus_API.Context;
using Bibliotheca_Motus_Imaginibus_API.DTOs;
using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly MovieContext _context;

        public RatingsController(MovieContext context)
        {
            _context = context;
        }

        // GET: api/Ratings
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Ratings>>> GetAllRatings()
        {
            return await _context.Ratings.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Ratings>> GetById(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }

        [HttpPost]
        public async Task<IActionResult> PostRating(RatingsDTO ratingDto)
        {
            // Ellenőrizzük, hogy a film létezik-e
            var movie = await _context.Movies.FindAsync(ratingDto.MovieId);
            if (movie == null)
            {
                return NotFound("Film nem található.");
            }

            // Ellenőrizzük, hogy a felhasználó létezik-e
            var user = await _context.Users.FindAsync(ratingDto.UserId);
            if (user == null)
            {
                return NotFound("Felhasználó nem található.");
            }

            // Új értékelés létrehozása
            var rating = new Ratings
            {
                MovieId = ratingDto.MovieId,
                UserId = ratingDto.UserId,
                RatingNumber = ratingDto.RatingNumber,
                Comment = ratingDto.Comment
            };

            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllRatings), new { id = rating.Id }, rating);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRatings(int id, RatingsDTO ratingDto)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound("Az értékelés nem található.");
            }

            // Frissítjük az értékelést
            rating.RatingNumber = ratingDto.RatingNumber;
            rating.Comment = ratingDto.Comment;

            // Ellenőrizzük a film és felhasználó létezését
            var movie = await _context.Movies.FindAsync(ratingDto.MovieId);
            var user = await _context.Users.FindAsync(ratingDto.UserId);
            if (movie == null || user == null)
            {
                return NotFound("Film vagy felhasználó nem található.");
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteRatings(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound("Az értékelés  nem található.");
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return Ok("Sikeresen törölve: " + rating.UserId);
        }


    }
}
