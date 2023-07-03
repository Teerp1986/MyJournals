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
    public class JournalsController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public JournalsController(MyJournalDbContext context)
        {
            _context = context;
        }
        // GET: api/Journals
        // Using Asynchronus Programing see lines 27,38,57 & 88.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Journals>>> GetJournals()   
        {
          if (_context.Journals == null)
          {
              return NotFound();
          }
            return await _context.Journals.ToListAsync();
        }

        // GET: api/Journals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Journals>> GetJournals(Guid id)
        {
          if (_context.Journals == null)
          {
              return NotFound();
          }
            var journals = await _context.Journals.FindAsync(id);

            if (journals == null)
            {
                return NotFound();
            }

            return journals;
        }

        // PUT: api/Journals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournals(Guid id, Journals journals)
        {
            if (id != journals.Id)
            {
                return BadRequest();
            }

            _context.Entry(journals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalsExists(id))
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

        // POST: api/Journals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Journals>> PostJournals(Journals journals)
        {
          if (_context.Journals == null)
          {
              return Problem("Entity set 'MyJournalDbContext.Journals'  is null.");
          }
            _context.Journals.Add(journals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJournals", new { id = journals.Id }, journals);
        }

        // DELETE: api/Journals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJournals(Guid id)
        {
            if (_context.Journals == null)
            {
                return NotFound();
            }
            var journals = await _context.Journals.FindAsync(id);
            if (journals == null)
            {
                return NotFound();
            }

            _context.Journals.Remove(journals);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JournalsExists(Guid id)
        {
            return (_context.Journals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
