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
        public async Task<IActionResult> CreateRating([FromBody] RatingsDTO ratingsDto)
        {
            if (ratingsDto == null)
            {
                return BadRequest("Invalid rating data.");
            }

            var movie = await _context.Movies.FindAsync(ratingsDto.MovieId);
            var user = await _context.Users.FindAsync(ratingsDto.UserId);

            if (movie == null || user == null)
            {
                return NotFound("Movie or User not found.");
            }

            var rating = new Ratings
            {
                RatingNumber = ratingsDto.RatingNumber,
                MovieId = ratingsDto.MovieId,
                UserId = ratingsDto.UserId,
                Comment = ratingsDto.Comment
            };

            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<Movie>> UpdateRatings(int id, Ratings updatedRating)
        {
            if (updatedRating == null)
            {
                return BadRequest("A frissítési adatok nem lehetnek üresek.");
            }

            var ratingToUpdate = await _context.Ratings.FindAsync(id);

            if (ratingToUpdate == null)
            {
                return NotFound("A értékelés nem található.");
            }

            ratingToUpdate.RatingNumber = updatedRating.RatingNumber;
            ratingToUpdate.MovieId = updatedRating.MovieId;
            ratingToUpdate.UserId = updatedRating.UserId;
            ratingToUpdate.Comment = updatedRating.Comment;

            await _context.SaveChangesAsync();
            return Ok("Sikeresen frissítve: " + ratingToUpdate.UserId);
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
