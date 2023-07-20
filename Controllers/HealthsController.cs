using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyJournalsAPI;
using MyJournalsAPI.Models;

namespace MyJournalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthsController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public HealthsController(MyJournalDbContext context)
        {
            _context = context;
        }

        // GET: api/Healths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Health>>> GetHealth()
        {
          if (_context.Health == null)
          {
              return NotFound();
          }
            return await _context.Health.ToListAsync();
        }

        // GET: api/Healths/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Health>> GetHealth(Guid id)
        {
          if (_context.Health == null)
          {
              return NotFound();
          }
            var health = await _context.Health.FindAsync(id);

            if (health == null)
            {
                return NotFound();
            }

            return health;
        }

        // PUT: api/Healths/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHealth(Guid id, Health health)
        {
            if (id != health.Id)
            {
                return BadRequest();
            }

            _context.Entry(health).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthExists(id))
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

        // POST: api/Healths
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Health>> PostHealth(Health health)
        {
          if (_context.Health == null)
          {
              return Problem("Entity set 'MyJournalDbContext.Health'  is null.");
          }
            _context.Health.Add(health);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHealth", new { id = health.Id }, health);
        }

        // DELETE: api/Healths/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHealth(Guid id)
        {
            if (_context.Health == null)
            {
                return NotFound();
            }
            var health = await _context.Health.FindAsync(id);
            if (health == null)
            {
                return NotFound();
            }

            _context.Health.Remove(health);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HealthExists(Guid id)
        {
            return (_context.Health?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
