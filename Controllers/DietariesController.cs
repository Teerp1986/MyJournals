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
    public class DietariesController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public DietariesController(MyJournalDbContext context)
        {
            _context = context;
        }

        // GET: api/Dietaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dietary>>> GetDietary()
        {
          if (_context.Dietary == null)
          {
              return NotFound();
          }
            return await _context.Dietary.ToListAsync();
        }

        // GET: api/Dietaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dietary>> GetDietary(Guid id)
        {
          if (_context.Dietary == null)
          {
              return NotFound();
          }
            var dietary = await _context.Dietary.FindAsync(id);

            if (dietary == null)
            {
                return NotFound();
            }

            return dietary;
        }

        // PUT: api/Dietaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDietary(Guid id, Dietary dietary)
        {
            if (id != dietary.Id)
            {
                return BadRequest();
            }

            _context.Entry(dietary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DietaryExists(id))
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

        // POST: api/Dietaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dietary>> PostDietary(Dietary dietary)
        {
          if (_context.Dietary == null)
          {
              return Problem("Entity set 'MyJournalDbContext.Dietary'  is null.");
          }
            _context.Dietary.Add(dietary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDietary", new { id = dietary.Id }, dietary);
        }

        // DELETE: api/Dietaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDietary(Guid id)
        {
            if (_context.Dietary == null)
            {
                return NotFound();
            }
            var dietary = await _context.Dietary.FindAsync(id);
            if (dietary == null)
            {
                return NotFound();
            }

            _context.Dietary.Remove(dietary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DietaryExists(Guid id)
        {
            return (_context.Dietary?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
