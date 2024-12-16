using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using WebApi.Data;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

[Route("api/[controller]")]
[ApiController]
public class LocationsController : ControllerBase
{
    private readonly AppDbContext _context;

    public LocationsController(AppDbContext context)
    {
        _context = context;
    }

    // POST: api/locations/upload
    [HttpPost("upload")]
    public async Task<IActionResult> UploadLocations(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No file uploaded.");

        var locations = new List<Location>();

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // EPPlus license
        using (var stream = file.OpenReadStream())
        using (var package = new ExcelPackage(stream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // First sheet
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Start from row 2 to skip headers
            {
                var location = new Location
                {
                    WhId = worksheet.Cells[row, 1]?.Text,
                    LocationId = worksheet.Cells[row, 2]?.Text,
                    Description = worksheet.Cells[row, 3]?.Text,
                    ShortLocationId = worksheet.Cells[row, 4]?.Text,
                    Status = worksheet.Cells[row, 5]?.Text,
                    Zone = worksheet.Cells[row, 6]?.Text,
                    PickingFlow = double.TryParse(worksheet.Cells[row, 7]?.Text, out var pf) ? pf : (double?)null,
                    CapacityUom = worksheet.Cells[row, 8]?.Text,
                    CapacityQty = int.TryParse(worksheet.Cells[row, 9]?.Text, out var cq) ? cq : (int?)null,
                    StoredQty = int.TryParse(worksheet.Cells[row, 10]?.Text, out var sq) ? sq : (int?)null,
                    Type = worksheet.Cells[row, 11]?.Text,
                    FifoDate = DateTime.TryParse(worksheet.Cells[row, 12]?.Text, out var fd) ? fd : (DateTime?)null,
                    XCoordinate = double.TryParse(worksheet.Cells[row, 34]?.Text, out var x) ? x : (double?)null,
                    YCoordinate = double.TryParse(worksheet.Cells[row, 35]?.Text, out var y) ? y : (double?)null,
                    ZCoordinate = double.TryParse(worksheet.Cells[row, 36]?.Text, out var z) ? z : (double?)null,
                    Length = double.TryParse(worksheet.Cells[row, 20]?.Text, out var length) ? length : (double?)null,
                    Width = double.TryParse(worksheet.Cells[row, 21]?.Text, out var width) ? width : (double?)null,
                    Height = double.TryParse(worksheet.Cells[row, 22]?.Text, out var height) ? height : (double?)null,
                    SlotStatus = worksheet.Cells[row, 28]?.Text,
                    NmHighLift = worksheet.Cells[row, 49]?.Text == "1",
                    NmIsMezzanine = worksheet.Cells[row, 50]?.Text == "1",
                    NmIsBlockStack = worksheet.Cells[row, 51]?.Text == "1",
                    NmIsSelected = worksheet.Cells[row, 52]?.Text == "1",
                };

                locations.Add(location);
            }
        }

        // Save to database
        await _context.Locations.AddRangeAsync(locations);
        await _context.SaveChangesAsync();

        return Ok(new { Message = "File uploaded successfully", Records = locations.Count });
    }

     // GET: api/locations/filter?whId={whId}&hallId={hallId}
    [HttpGet("filter")]
    public async Task<IActionResult> GetFilteredLocations(
        [FromQuery] string? whId,
        [FromQuery] string? hallId,
        [FromQuery] string? aisleId)
    {
        // Query base with filtering
        var query = _context.Locations.AsQueryable();

        if (!string.IsNullOrEmpty(whId))
        {
            query = query.Where(loc => loc.WhId == whId);
        }

        if (!string.IsNullOrEmpty(hallId))
        {
            query = query.Where(loc => loc.NmHallId == hallId);
        }

        if (!string.IsNullOrEmpty(aisleId))
        {
            query = query.Where(loc => loc.NmAisle == aisleId);
        }

        // Project only the required fields
        var result = await query.Select(loc => new
        {
            loc.WhId,
            loc.LocationId,
            loc.ShortLocationId,
            loc.NmHallId,
            loc.NmAisle
        }).ToListAsync();

        return Ok(result);
    }
}
