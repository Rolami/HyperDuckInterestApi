using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperDuckInterestApi.Data;
using HyperDuckInterestApi.Models;

namespace HyperDuckInterestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        private readonly HyperDuckInterestApiContext _context;

        public InterestsController(HyperDuckInterestApiContext context)
        {
            _context = context;
        }

        // GET: api/Interests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interests>>> GetInterests()
        {
          if (_context.Interests == null)
          {
              return NotFound();
          }
            return await _context.Interests.ToListAsync();
        }

        // GET: api/Interests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interests>> GetInterests(int id)
        {
          if (_context.Interests == null)
          {
              return NotFound();
          }
            var interests = await _context.Interests.FindAsync(id);

            if (interests == null)
            {
                return NotFound();
            }

            return interests;
        }

        // PUT: api/Interests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInterests(int id, Interests interests)
        {
            if (id != interests.InterestId)
            {
                return BadRequest();
            }

            _context.Entry(interests).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterestsExists(id))
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

        // POST: api/Interests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Interests>> PostInterests(Interests interests)
        {
          if (_context.Interests == null)
          {
              return Problem("Entity set 'HyperDuckInterestApiContext.Interests'  is null.");
          }
            _context.Interests.Add(interests);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInterests", new { id = interests.InterestId }, interests);
        }

        // DELETE: api/Interests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterests(int id)
        {
            if (_context.Interests == null)
            {
                return NotFound();
            }
            var interests = await _context.Interests.FindAsync(id);
            if (interests == null)
            {
                return NotFound();
            }

            _context.Interests.Remove(interests);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterestsExists(int id)
        {
            return (_context.Interests?.Any(e => e.InterestId == id)).GetValueOrDefault();
        }
    }
}
