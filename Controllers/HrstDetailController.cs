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
    public class HrstDetailController : ControllerBase
    {
        private readonly HrstContext _context;

        public HrstDetailController(HrstContext context)
        {
            _context = context;
        }

        // GET: api/HrstDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrstDetail>>> GetHrstDetails()
        {
            return await _context.HrstDetails.ToListAsync();
        }

        // GET: api/HrstDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HrstDetail>> GetHrstDetail(int id)
        {
            var hrstDetail = await _context.HrstDetails.FindAsync(id);

            if (hrstDetail == null)
            {
                return NotFound();
            }

            return hrstDetail;
        }

        // GET: api/HrstDetail/user/email@example.com
        [HttpGet("user/{createdBy}")]
        public async Task<ActionResult<IEnumerable<HrstDetail>>> GetHrstByUser(string createdBy)
        {
            var hrstDetails = await _context.HrstDetails
                .Where(h => h.CreatedBy == createdBy)
                .ToListAsync();

            if (hrstDetails == null || !hrstDetails.Any())
            {
                return NotFound();
            }

            return hrstDetails;
        }

        // PUT: api/HrstDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrstDetail(int id, HrstDetail hrstDetail)
        {
            if (id != hrstDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(hrstDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrstDetailExists(id))
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

        // POST: api/HrstDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HrstDetail>> PostHrstDetail(HrstDetail hrstDetail)
        {
            _context.HrstDetails.Add(hrstDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrstDetail", new { id = hrstDetail.Id }, hrstDetail);
        }

        // DELETE: api/HrstDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrstDetail(int id)
        {
            var hrstDetail = await _context.HrstDetails.FindAsync(id);
            if (hrstDetail == null)
            {
                return NotFound();
            }

            _context.HrstDetails.Remove(hrstDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrstDetailExists(int id)
        {
            return _context.HrstDetails.Any(e => e.Id == id);
        }
    }
}
