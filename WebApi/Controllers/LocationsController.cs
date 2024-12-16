using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;
using Microsoft.Extensions.Logging;

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

    // GET: api/locations/filter?whId={whId}&hallId={hallId}&aisleId={aisleId}
    [HttpGet("filter")]
    [Authorize]
    public async Task<IActionResult> GetFilteredLocations(
        [FromQuery] string? whId,
        [FromQuery] string? hallId,
        [FromQuery] string? aisleId)
    {
        _logger.LogInformation("GetFilteredLocations called with parameters: whId={WhId}, hallId={HallId}, aisleId={AisleId}", whId, hallId, aisleId);

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

        var result = await query.Select(loc => new
        {
            loc.WhId,
            loc.LocationId,
            loc.ShortLocationId,
            loc.NmHallId,
            loc.NmAisle
        }).ToListAsync();

        _logger.LogInformation("Returning {Count} locations", result.Count);

        return Ok(result);
    }

    // POST: api/locations/upload
    [HttpPost("upload")]
    [Authorize]
    public IActionResult UploadLocation([FromBody] Location location)
    {
        _context.Locations.Add(location);
        _context.SaveChanges();
        return Ok();
    }
}
