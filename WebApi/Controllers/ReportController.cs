using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("generate")]
        [Authorize(Roles = "Admin")]
        public IActionResult GenerateReport()
        {
            // Placeholder for report generation logic
            return Ok(new { Message = "Report generation started." });
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetReports()
        {
            // Placeholder for fetching reports
            return Ok(new { Message = "List of reports." });
        }
    }
}