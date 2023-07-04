using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyJournalsAPI;
using MyJournalsAPI.Models;
using SQLitePCL;

namespace MyJournalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcerciseJournalsController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public ExcerciseJournalsController(MyJournalDbContext context)
        {
            _context = context;
        }

        // GET: api/ExcerciseJournals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExcerciseJournal>>> GetExerciseJournals()
        {
          if (_context.ExerciseJournals == null)
          {
              return NotFound();
          }
            return await _context.ExerciseJournals.ToListAsync();
        }

        // GET: api/ExcerciseJournals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExcerciseJournal>> GetExcerciseJournal(Guid id)
        {
          if (_context.ExerciseJournals == null)
          {
              return NotFound();
          }
            var excerciseJournal = await _context.ExerciseJournals.FindAsync(id);

            if (excerciseJournal == null)
            {
                return NotFound();
            }

            return excerciseJournal;
        }

        // PUT: api/ExcerciseJournals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExcerciseJournal(Guid id, ExcerciseJournal excerciseJournal)
        {
            if (id != excerciseJournal.Id)
            {
                return BadRequest();
            }

            _context.Entry(excerciseJournal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcerciseJournalExists(id))
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

        // POST: api/ExcerciseJournals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExcerciseJournal>> PostExcerciseJournal(ExcerciseJournal excerciseJournal)
        {
          if (_context.ExerciseJournals == null)
          {
              return Problem("Entity set 'MyJournalDbContext.ExerciseJournals'  is null.");
          }
            _context.ExerciseJournals.Add(excerciseJournal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExcerciseJournal", new { id = excerciseJournal.Id }, excerciseJournal);
        }

        // DELETE: api/ExcerciseJournals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExcerciseJournal(Guid id)
        {
            if (_context.ExerciseJournals == null)
            {
                return NotFound();
            }
            var excerciseJournal = await _context.ExerciseJournals.FindAsync(id);
            if (excerciseJournal == null)
            {
                return NotFound();
            }

            _context.ExerciseJournals.Remove(excerciseJournal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExcerciseJournalExists(Guid id)
        {
            return (_context.ExerciseJournals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
