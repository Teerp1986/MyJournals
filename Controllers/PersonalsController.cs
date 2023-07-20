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
    public class PersonalsController : ControllerBase
    {
        private readonly MyJournalDbContext _context;

        public PersonalsController(MyJournalDbContext context)
        {
            _context = context;
        }

        // GET: api/Personals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personal>>> GetPersonal()
        {
          if (_context.Personal == null)
          {
              return NotFound();
          }
            return await _context.Personal.ToListAsync();
        }

        // GET: api/Personals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personal>> GetPersonal(Guid id)
        {
          if (_context.Personal == null)
          {
              return NotFound();
          }
            var personal = await _context.Personal.FindAsync(id);

            if (personal == null)
            {
                return NotFound();
            }

            return personal;
        }

        // PUT: api/Personals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonal(Guid id, Personal personal)
        {
            if (id != personal.Id)
            {
                return BadRequest();
            }

            _context.Entry(personal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalExists(id))
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

        // POST: api/Personals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Personal>> PostPersonal(Personal personal)
        {
          if (_context.Personal == null)
          {
              return Problem("Entity set 'MyJournalDbContext.Personal'  is null.");
          }
            _context.Personal.Add(personal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonal", new { id = personal.Id }, personal);
        }

        // DELETE: api/Personals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonal(Guid id)
        {
            if (_context.Personal == null)
            {
                return NotFound();
            }
            var personal = await _context.Personal.FindAsync(id);
            if (personal == null)
            {
                return NotFound();
            }

            _context.Personal.Remove(personal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalExists(Guid id)
        {
            return (_context.Personal?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
