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
    public class ExcercisesController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public ExcercisesController(MyJournalDbContext context)
        {
            _context = context;
        }

        // GET: api/Excercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Excercise>>> GetExercise()
        {
          if (_context.Exercise == null)
          {
              return NotFound();
          }
            return await _context.Exercise.ToListAsync();
        }

        // GET: api/Excercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Excercise>> GetExcercise(Guid id)
        {
          if (_context.Exercise == null)
          {
              return NotFound();
          }
            var excercise = await _context.Exercise.FindAsync(id);

            if (excercise == null)
            {
                return NotFound();
            }

            return excercise;
        }

        // PUT: api/Excercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExcercise(Guid id, Excercise excercise)
        {
            if (id != excercise.Id)
            {
                return BadRequest();
            }

            _context.Entry(excercise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcerciseExists(id))
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

        // POST: api/Excercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Excercise>> PostExcercise(Excercise excercise)
        {
          if (_context.Exercise == null)
          {
              return Problem("Entity set 'MyJournalDbContext.Exercise'  is null.");
          }
            _context.Exercise.Add(excercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExcercise", new { id = excercise.Id }, excercise);
        }

        // DELETE: api/Excercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExcercise(Guid id)
        {
            if (_context.Exercise == null)
            {
                return NotFound();
            }
            var excercise = await _context.Exercise.FindAsync(id);
            if (excercise == null)
            {
                return NotFound();
            }

            _context.Exercise.Remove(excercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExcerciseExists(Guid id)
        {
            return (_context.Exercise?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
