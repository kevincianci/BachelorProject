using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<LocationsController> _logger;

        public LocationsController(AppDbContext context, ILogger<LocationsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/locations/filter?whId={whId}&hallId={hallId}&aisleId={aisleId}&page={page}&pageSize={pageSize}
        [HttpGet("filter")]
        [Authorize]
        public async Task<IActionResult> GetFilteredLocations(
            [FromQuery] string? whId,
            [FromQuery] string? hallId,
            [FromQuery] string? aisleId,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            _logger.LogInformation("GetFilteredLocations called with parameters: whId={WhId}, hallId={HallId}, aisleId={AisleId}, page={Page}, pageSize={PageSize}", whId, hallId, aisleId, page, pageSize);

            var query = _context.Locations.AsQueryable();

            if (!string.IsNullOrEmpty(whId))
            {
                _logger.LogInformation("Filtering by WhId: {WhId}", whId);
                query = query.Where(loc => loc.WhId == whId);
            }

            if (!string.IsNullOrEmpty(hallId))
            {
                _logger.LogInformation("Filtering by HallId: {HallId}", hallId);
                query = query.Where(loc => loc.NmHallId == hallId);
            }

            if (!string.IsNullOrEmpty(aisleId))
            {
                _logger.LogInformation("Filtering by AisleId: {AisleId}", aisleId);
                query = query.Where(loc => loc.NmAisle == aisleId);
            }

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var result = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(loc => new
                {
                    loc.WhId,
                    loc.LocationId,
                    loc.ShortLocationId,
                    loc.NmHallId,
                    loc.NmAisle
                })
                .ToListAsync();

            _logger.LogInformation("Returning {Count} locations", result.Count);

            return Ok(new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Items = result
            });
        }

        // POST: api/locations/upload
        [HttpPost("upload")]
        [Authorize]
        public async Task<IActionResult> UploadLocation([FromBody] Location location)
        {
            if (location == null)
            {
                return BadRequest("Location data is null.");
            }

            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFilteredLocations), new { id = location.LocationId }, location);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            return Ok(locations);
        }
    }
}