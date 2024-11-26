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

        // GET: api/Ratings
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Watchlist>>> GetAllWatchlists()
        {
            return await _context.Watchlists.ToListAsync();
        }

        [HttpGet("{id}")]

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

        public async Task<ActionResult<Watchlist>> PostWatchlists(Watchlist watchlist)
        {
            if (watchlist == null)
            {
                return BadRequest("A ratings paraméterei nem lehetnek üresek.");
            }

            _context.Watchlists.Add(watchlist);
            await _context.SaveChangesAsync();

            return Ok("Sikeresen létrehozva: " + watchlist.UserId);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Watchlist>> UpdateWatchlists(int id, Watchlist updatedWatchlist)
        {
            if (updatedWatchlist == null)
            {
                return BadRequest("A frissítési adatok nem lehetnek üresek.");
            }

            var watchlistToUpdate = await _context.Watchlists.FindAsync(id);

            if (watchlistToUpdate == null)
            {
                return NotFound("A értékelés nem található.");
            }

            watchlistToUpdate.UserId = updatedWatchlist.UserId;
            watchlistToUpdate.User = updatedWatchlist.User;
            watchlistToUpdate.AddedDate = updatedWatchlist.AddedDate;
            watchlistToUpdate.MovieId = updatedWatchlist.MovieId;

            await _context.SaveChangesAsync();
            return Ok("Sikeresen frissítve: " + watchlistToUpdate.UserId);
        }

        [HttpDelete("{id}")]

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
