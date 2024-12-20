using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrinterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PrinterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("printjob")]
        [Authorize]
        public async Task<IActionResult> CreatePrintJob([FromBody] PrintJob printJob)
        {
            if (printJob == null) return BadRequest("Invalid print job data.");

            _context.PrintJobs.Add(printJob);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Print job created successfully." });
        }

        [HttpGet("printqueue")]
        [Authorize]
        public async Task<IActionResult> GetPrintQueue()
        {
            var printQueue = await _context.PrintJobs
                .Where(pj => pj.Status == "Pending")
                .ToListAsync();
            return Ok(printQueue);
        }

        [HttpDelete("printjob/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePrintJob(int id)
        {
            var printJob = await _context.PrintJobs.FindAsync(id);
            if (printJob == null) return NotFound("Print job not found.");

            _context.PrintJobs.Remove(printJob);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Print job deleted successfully." });
        }
    }
}