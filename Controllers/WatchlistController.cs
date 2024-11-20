using Bibliotheca_Motus_Imaginibus_API.Context;
using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WatchlistController : ControllerBase
    {
        private readonly MovieContext _context;
        private readonly UserManager<User> _userManager;

        public WatchlistController(MovieContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Watchlist>> GetUserWatchlist()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized("Felhasználó azonosító nem található.");

            var watchlist = await _context.Watchlists
                .Include(w => w.Movies)
                .FirstOrDefaultAsync(w => w.UserId == userId);

            if (watchlist == null) return NotFound("A figyelőlista nem található.");

            return Ok(watchlist);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWatchlistById(int id)
        {
            var watchlist = await _context.Watchlists
                .Include(w => w.Movies)
                .FirstOrDefaultAsync(w => w.Id == id);

            if (watchlist == null)
            {
                return NotFound("A nézési lista nem található.");
            }

            return Ok(watchlist);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddMovieToWatchlist(int movieId)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized("Felhasználó azonosító nem található.");

            var movie = await _context.Movies.FindAsync(movieId);
            if (movie == null) return NotFound("Film nem található.");

            var watchlist = await _context.Watchlists
                .Include(w => w.Movies)
                .FirstOrDefaultAsync(w => w.UserId == userId);

            if (watchlist == null)
            {
                watchlist = new Watchlist
                {
                    UserId = userId,
                    Movies = new List<Movie> { movie }
                };
                _context.Watchlists.Add(watchlist);
            }
            else
            {
                if (watchlist.Movies.Contains(movie)) return BadRequest("A film már szerepel a figyelőlistában.");
                watchlist.Movies.Add(movie);
            }

            await _context.SaveChangesAsync();
            return Ok("Film hozzáadva a figyelőlistához.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWatchlistById(int id, List<int> movieIds)
        {
            var watchlist = await _context.Watchlists
                .Include(w => w.Movies)
                .FirstOrDefaultAsync(w => w.Id == id);

            if (watchlist == null)
            {
                return NotFound("A nézési lista nem található.");
            }

            var movies = await _context.Movies
                .Where(m => movieIds.Contains(m.Id))
                .ToListAsync();

            watchlist.Movies = movies;

            await _context.SaveChangesAsync();
            return Ok("A nézési lista sikeresen frissítve.");
        }


        

        [HttpDelete("{movieId}")]
        [Authorize]
        public async Task<IActionResult> RemoveMovieFromWatchlist(int movieId)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized("Felhasználó azonosító nem található.");

            var watchlist = await _context.Watchlists
                .Include(w => w.Movies)
                .FirstOrDefaultAsync(w => w.UserId == userId);

            if (watchlist == null) return NotFound("A figyelőlista nem található.");

            var movie = watchlist.Movies.FirstOrDefault(m => m.Id == movieId);
            if (movie == null) return NotFound("A film nem található a figyelőlistában.");

            watchlist.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return Ok("Film eltávolítva a figyelőlistáról.");
        }
    }
}
