using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRSTAPI.Models;

namespace HRSTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpController : ControllerBase
    {
        private readonly HrstContext _context;

        public LookUpController(HrstContext context)
        {
            _context = context;
        }

        // GET: api/LookUp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LookUp>>> GetLookUps()
        {
            return await _context.LookUps.ToListAsync();
        }

        //// GET: api/LookUp/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<LookUp>> GetLookUp(int id)
        //{
        //    var lookUp = await _context.LookUps.FindAsync(id);

        //    if (lookUp == null)
        //    {
        //        return NotFound();
        //    }

        //    return lookUp;
        //}

        // GET: api/LookUp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<LookUp>>> GetLookUp(int id)
        {
            var lookUps = await _context.LookUps
                                        .Where(lookUp => lookUp.Category == id)
                                        .ToListAsync();

            if (!lookUps.Any())
            {
                return NotFound($"No lookup records found for category {id}.");
            }

            return Ok(lookUps);
        }


        // PUT: api/LookUp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLookUp(int id, LookUp lookUp)
        {
            if (id != lookUp.Id)
            {
                return BadRequest();
            }

            _context.Entry(lookUp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LookUpExists(id))
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

        // POST: api/LookUp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LookUp>> PostLookUp(LookUp lookUp)
        {
            _context.LookUps.Add(lookUp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLookUp", new { id = lookUp.Id }, lookUp);
        }

        // DELETE: api/LookUp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLookUp(int id)
        {
            var lookUp = await _context.LookUps.FindAsync(id);
            if (lookUp == null)
            {
                return NotFound();
            }

            _context.LookUps.Remove(lookUp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LookUpExists(int id)
        {
            return _context.LookUps.Any(e => e.Id == id);
        }
    }
}
