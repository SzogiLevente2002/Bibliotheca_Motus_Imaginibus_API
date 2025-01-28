﻿using Bibliotheca_Motus_Imaginibus_API.Context;
using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    [Authorize(Roles ="Admin")]
    public async Task<ActionResult<Movie>> PostMovies(Movie movie)
    {
        if (movie == null)
        {
            return BadRequest("A film paraméterei nem lehetnek üresek.");
        }

        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();

        return Ok(movie.Id);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
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
        movieToUpdate.Director = updatedMovie.Director;
        movieToUpdate.Description = updatedMovie.Description;
        movieToUpdate.AddedAt = updatedMovie.AddedAt;

        await _context.SaveChangesAsync();
        return Ok("Sikeresen frissítve: " + movieToUpdate.Title);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
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

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Movie>>> SearchMovies([FromQuery] string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return BadRequest("A keresési kifejezés nem lehet üres.");
        }

        var movies = await _context.Movies
            .Where(m => m.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();

        if (!movies.Any())
        {
            return NotFound("Nincs találat a megadott kifejezésre.");
        }

        return Ok(movies);
    }

    [HttpGet("{id}/kep")]
    public async Task<IActionResult> GetMoviePoster(int id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        if (movie.Poster == null)
        {
            return NotFound();
        }

        var fileName = $"{movie.Title}.jpg";
        return File(movie.Poster, "image/jpg", fileName);
    }

    [HttpPut("{id}/kep")]
    [Authorize(Roles ="Admin")]
    public async Task<IActionResult> PutMoviePoster(int id, [FromForm] MoviePosterUpdateModel poster)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie == null)
        {
            return NotFound();
        }

        using (var memoryStream = new MemoryStream())
        {
            await poster.file.CopyToAsync(memoryStream);
            movie.Poster = memoryStream.ToArray();
        }

        await _context.SaveChangesAsync();
        return Ok("Poster sucesfully updated!");
    }

    public class MoviePosterUpdateModel
    {
        public required IFormFile file { get; set; }
    }

    [HttpDelete("{id}/kep")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteMoviePoster(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie == null)
        {
            return NotFound();
        }

        movie.Poster = null;

        await _context.SaveChangesAsync();
        return NoContent();
    }
}
