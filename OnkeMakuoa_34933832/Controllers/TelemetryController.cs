using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnkeMakuoa_34933832.Models;

[Route("api/[controller]")]
[ApiController]
public class TelemetryController : ControllerBase
{
    private readonly NwutechTrendsContext _context;

    public object ProjectID { get; private set; }

    public TelemetryController(NwutechTrendsContext context)
    {
        _context = context;
    }

    // GET: api/Telemetry
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobTelemetry>>> GetTelemetry()
    {
        return await _context.JobTelemetries.ToListAsync();
    }

    // GET: api/Telemetry/5
    [HttpGet("{id}")]
    public async Task<ActionResult<JobTelemetry>> GetTelemetry(int id)
    {
        var telemetry = await _context.JobTelemetries.FindAsync(id);

        if (telemetry == null)
        {
            return NotFound();
        }

        return telemetry;
    }

    // POST: api/Telemetry
    [HttpPost]
    public async Task<ActionResult<JobTelemetry>> PostTelemetry(JobTelemetry telemetry)
    {
        _context.JobTelemetries.Add(telemetry);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTelemetry", new { id = telemetry.Id }, telemetry);
    }

    // PATCH: api/Telemetry/5
    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchTelemetry(int id, JobTelemetry telemetry)
    {
        if (id != telemetry.Id)
        {
            return BadRequest();
        }

        _context.Entry(telemetry).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TelemetryExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Telemetry/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTelemetry(int id)
    {
        var telemetry = await _context.JobTelemetries.FindAsync(id);
        if (telemetry == null)
        {
            return NotFound();
        }

        _context.JobTelemetries.Remove(telemetry);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TelemetryExists(int id)
    {
        return _context.JobTelemetries.Any(e => e.Id == id);
    }
    [HttpGet("GetSavingsPerClient")]
    public async Task<ActionResult> GetSavingsPerClient(Guid clientId, DateTime startDate, DateTime endDate)
    {
        var telemetry = await _context.JobTelemetries
            .Where(t => t.Id == t.Id && t.EntryDate >= startDate && t.EntryDate <= endDate)
            .ToListAsync();

        var totalTimeSaved = telemetry.Sum(t => t.TimeSaved);
        var totalCostSaved = telemetry.Sum(t => t.CostSaved);

        return Ok(new { TotalTimeSaved = totalTimeSaved, TotalCostSaved = totalCostSaved });
    }
    [HttpGet("GetSavingsPerProject")]
    public IActionResult GetSavingsPerProject(Guid projectId, DateTime startDate, DateTime endDate)
    {
        // Example of simplified query
        var query = _context.JobTelemetries
            .AsEnumerable() // Switch to client-side evaluation
            .Where(j => j.ProjectID == ProjectID && j.EntryDate >= startDate && j.EntryDate <= endDate)
            .ToList(); // This will switch to client-side evaluation

        // Perform further operations on query results here

        return Ok(query); 
    }



}
