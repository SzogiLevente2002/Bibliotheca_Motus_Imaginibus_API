using Bibliotheca_Motus_Imaginibus_API.Context;
using Bibliotheca_Motus_Imaginibus_API.DTOs;
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

        // GET: api/Ratings
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Watchlist>>> GetAllWatchlists()
        {
            return await _context.Watchlists.ToListAsync();
        }

        [HttpGet("{id}")]
        [Authorize]


        public async Task<ActionResult<Watchlist>> GetById(int id)
        {
            var watchlist = await _context.Watchlists.FindAsync(id);

            if (watchlist == null)
            {
                return NotFound();
            }

            return Ok(watchlist);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostWatchlist(WatchlistDTO watchlistDto)
        {
            var user = await _context.Users.FindAsync(watchlistDto.UserId);
            if (user == null)
            {
                return NotFound("Felhasználó nem található.");
            }

            var movie = await _context.Movies.FindAsync(watchlistDto.MovieId);
            if (movie == null)
            {
                return NotFound("Film nem található.");
            }

            var watchlist = new Watchlist
            {
                UserId = watchlistDto.UserId,
                MovieId = watchlistDto.MovieId,
                AddedDate = DateTime.Now
            };

            _context.Watchlists.Add(watchlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = watchlist.Id }, watchlist);
        }


        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateWatchlist(int id, WatchlistDTO watchlistDto)
        {
            var watchlist = await _context.Watchlists.FindAsync(id);
            if (watchlist == null)
            {
                return NotFound("Watchlist nem található.");
            }

            var movie = await _context.Movies.FindAsync(watchlistDto.MovieId);
            var user = await _context.Users.FindAsync(watchlistDto.UserId);
            if (movie == null || user == null)
            {
                return NotFound("Film vagy felhasználó nem található.");
            }

            watchlist.MovieId = watchlistDto.MovieId;
            watchlist.UserId = watchlistDto.UserId;

            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        [Authorize]

        public async Task<IActionResult> DeleteWatchlists(int id)
        {
            var watchlist = await _context.Watchlists.FindAsync(id);

            if (watchlist == null)
            {
                return NotFound("A watchlist nem található.");
            }

            _context.Watchlists.Remove(watchlist);
            await _context.SaveChangesAsync();

            return Ok("Sikeresen törölve: " + watchlist.UserId);
        }

    }
}
