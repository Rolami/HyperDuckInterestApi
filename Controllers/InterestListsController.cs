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
    public class InterestListsController : ControllerBase
    {
        private readonly HyperDuckInterestApiContext _context;

        public InterestListsController(HyperDuckInterestApiContext context)
        {
            _context = context;
        }

        // GET: api/InterestLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InterestList>>> GetInterestLists()
        {
          if (_context.InterestLists == null)
          {
              return NotFound();
          }
            return await _context.InterestLists.ToListAsync();
        }

        // GET: api/InterestLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InterestList>> GetInterestList(int id)
        {
          if (_context.InterestLists == null)
          {
              return NotFound();
          }
            var interestList = await _context.InterestLists.FindAsync(id);

            if (interestList == null)
            {
                return NotFound();
            }

            return interestList;
        }

        // PUT: api/InterestLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInterestList(int id, InterestList interestList)
        {
            if (id != interestList.InterestListId)
            {
                return BadRequest();
            }

            _context.Entry(interestList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterestListExists(id))
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

        // POST: api/InterestLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InterestList>> PostInterestList(InterestList interestList)
        {
          if (_context.InterestLists == null)
          {
              return Problem("Entity set 'HyperDuckInterestApiContext.InterestLists'  is null.");
          }
            _context.InterestLists.Add(interestList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInterestList", new { id = interestList.InterestListId }, interestList);
        }

        // DELETE: api/InterestLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterestList(int id)
        {
            if (_context.InterestLists == null)
            {
                return NotFound();
            }
            var interestList = await _context.InterestLists.FindAsync(id);
            if (interestList == null)
            {
                return NotFound();
            }

            _context.InterestLists.Remove(interestList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterestListExists(int id)
        {
            return (_context.InterestLists?.Any(e => e.InterestListId == id)).GetValueOrDefault();
        }
    }
}
