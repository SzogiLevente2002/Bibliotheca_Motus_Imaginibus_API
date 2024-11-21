using System.Security.Claims;
using Bibliotheca_Motus_Imaginibus_API.Context;
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

        // GET: api/Ratings/{id}
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Ratings>> GetById(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound("Az értékelés nem található.");
            }

            return Ok(rating);
        }

        // POST: api/Ratings
        [HttpPost]
        [Authorize]
        
        public async Task<ActionResult<Ratings>> CreateRating([FromBody] Ratings newRating)
        {
            if (newRating == null)
            {
                return BadRequest("Az értékelés adatai nem lehetnek üresek.");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // A bejelentkezett felhasználó ID-ja
            newRating.UserId = userId; // Állítsuk be az UserId-t

            // Ellenőrizd, hogy a film létezik-e
            var movie = await _context.Movies.FindAsync(newRating.MovieId);
            if (movie == null)
            {
                return NotFound("A megadott film nem található.");
            }

            _context.Ratings.Add(newRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = newRating.Id }, newRating);
        }


        // PUT: api/Ratings/{id}
        [HttpPut("{id}")]
        [Authorize]
        
        public async Task<IActionResult> UpdateRating(int id, [FromBody] Ratings updatedRating)
        {
            if (updatedRating == null)
            {
                return BadRequest("Az értékelés adatai nem lehetnek üresek.");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized("Felhasználói azonosító nem található.");
            }

            var existingRating = await _context.Ratings.FindAsync(id);
            if (existingRating == null)
            {
                return NotFound("Az értékelés nem található.");
            }

            if (existingRating.UserId != userId)
            {
                return Forbid("Nem módosíthatod más felhasználó értékelését.");
            }

            existingRating.RatingNumber = updatedRating.RatingNumber;
            existingRating.Comment = updatedRating.Comment;

            await _context.SaveChangesAsync();
            return Ok("Az értékelés sikeresen frissítve.");
        }

        // DELETE: api/Ratings/{id}
        [HttpDelete("{id}")]
        [Authorize]
        
        public async Task<IActionResult> DeleteRating(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized("Felhasználói azonosító nem található.");
            }

            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound("Az értékelés nem található.");
            }

            if (rating.UserId != userId)
            {
                return Forbid("Nem törölheted más felhasználó értékelését.");
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return Ok("Az értékelés sikeresen törölve.");
        }
    }
}
